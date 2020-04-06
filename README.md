# Projeto-base
- Projeto base para criação de API Dot Net Core
- Documentação com swagger já configurado;
- Sistema de autorização e autenticação com Identity baseado em claims;
- EndPoints de exemplo para nortear o desenvolvedor diante da arquitetura;

### Requisitos
- Dot .Net 3.1
- Postgres Sql

### Instalação
- Primeiro precisamos obter o pack de instalação da API, abra o prompt de comando de sua preferência (cmd, power shell, console, gitBash, etc.) e execute o comando:
	> dotnet new -i Erick.Pinheiro.Template.Api
	
- Ainda no prompt de comando, navegue até a pasta onde deseja guardar o projeto e execute o seguinte comando:
	> dotnet  new doom-template -n [NomeDoProjeto] 
	
- Pronto, agora a base da sua API está disponível e só precisa de pequenas configurações.

### Configurações

- #### No Visual Studio
1. com o Visual Studio aberto, abra o projeto [NomeDoProjeto].Api acesse o arquivo appsettings.json e ajuste a connectionString com as configuração do seu banco de dados.

2. Abra o console do Visual Studio:
- No console informe o projeto padrão como [NomeDoProjeto].Identity para criar as tabelas do contexto do Identity.
	> update-database -Context ApplicationDbContext
		
- Ainda no console informe o projeto padrão como [NomeDoProjeto].Data para criar as tabelas do contexto do restante do projeto(no caso a tabela de exemplo).
	> update-database -Context AppDbContext

### Pronto!
- Agora basta definir [NomeDoProjeto].Api como projeto padrão e executar.
- Abrirá o navegador com o Swagger e os EndPoints de autenticação de usuário e os de exemplo.
- Navegue pelo código analisando os exemplos para desenvolver os seus próprios métodos e por fim exclua todos os métodos de exemplo.
