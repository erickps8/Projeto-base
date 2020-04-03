using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Business.Interfaces;
using Template.Business.Models;
using Template.Business.Notifications;

namespace Template.Business.Servicecs
{
    public abstract class BaseService
    {
        private readonly INotificator _notificator;

        public BaseService(INotificator notificator)
        {
            _notificator = notificator;
        }

        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notify(error.ErrorMessage);
            }
        }

        protected void Notify(string mensagem)
        {
            _notificator.Handle(new Notification(mensagem));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validation, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validation.Validate(entidade);

            if (validator.IsValid) return true;

            Notify(validator);

            return false;
        }
    }
}
