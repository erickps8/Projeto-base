using System;
using System.Collections.Generic;
using System.Text;
using Template.Business.Interfaces;
using Template.Business.Models;
using Template.Data.Context;

namespace Template.Data.Repository
{
    public class ExampleRepository : Repository<Example>, IExampleRepository
    {
        public ExampleRepository(AppDbContext myDbContext) : base(myDbContext)
        {

        }
    }
}
