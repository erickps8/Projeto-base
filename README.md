# Projeto Base para API .NET 8

Este repositório fornece uma base inicial para a criação de uma API utilizando .NET 8. A estrutura inclui funcionalidades de autenticação e autorização com Identity, documentação Swagger integrada e exemplos de endpoints para facilitar o desenvolvimento.

## Funcionalidades
- **Autenticação e autorização** com Identity, utilizando claims para controle de acesso.
- **Documentação automática** com Swagger, já configurada.
- **EndPoints de exemplo** para facilitar o desenvolvimento e a integração com a arquitetura.

## Requisitos
- **.NET 8** (Certifique-se de ter o SDK do .NET 8 instalado)
- **PostgreSQL** (ou outro banco de dados, ajustando a string de conexão)

## Instalação

### Passo 1: Instalar o template
1. Abra o prompt de comando de sua preferência (cmd, PowerShell, Console, GitBash, etc.) e execute o seguinte comando para instalar o template:
    ```bash
    dotnet new -i Erick.Pinheiro.Template.Api
    ```

### Passo 2: Criar o novo projeto
2. Navegue até o diretório onde deseja criar o novo projeto e execute o comando:
    ```bash
    dotnet new doom-template -n [NomeDoProjeto]
    ```

Agora você terá a base do seu projeto criada e pronta para configurar.

## Configuração

### No Visual Studio

1. Com o Visual Studio aberto, abra o projeto `[NomeDoProjeto].Api`. Em seguida, edite o arquivo `appsettings.json` e ajuste a `ConnectionString` para o seu banco de dados.
   
2. Abra o **Console do Gerenciador de Pacotes** (Package Manager Console) e execute os seguintes comandos para aplicar as migrações e criar as tabelas no banco de dados:
    - Para criar as tabelas do contexto do **Identity**:
      ```bash
      update-database -Context ApplicationDbContext
      ```

    - Para criar as tabelas do restante do projeto (exemplo de tabela):
      ```bash
      update-database -Context AppDbContext
      ```

### No VSCode (usando a dotnet CLI)

1. Com o VSCode aberto, abra o projeto `[NomeDoProjeto].Api` e edite o arquivo `appsettings.json` para ajustar a `ConnectionString` com as configurações do seu banco de dados.

2. Abra o terminal integrado do VSCode e execute os seguintes comandos:
    - Para criar as tabelas do contexto do **Identity**:
      ```bash
      dotnet ef database update --context ApplicationDbContext
      ```

    - Para criar as tabelas do restante do projeto (exemplo de tabela):
      ```bash
      dotnet ef database update --context AppDbContext
      ```

## Execução

Agora que as configurações estão concluídas, basta:

1. Definir o projeto `[NomeDoProjeto].Api` como projeto padrão.
2. Executar o projeto. Isso abrirá o navegador com a documentação Swagger.
3. Na documentação Swagger, você encontrará os endpoints de autenticação de usuário e os exemplos de endpoints para guiar o desenvolvimento.
4. Analise os exemplos de código e desenvolva seus próprios métodos. **Lembre-se de excluir os métodos de exemplo quando terminar a implementação**.

## Conclusão
Sua API está pronta para ser personalizada e expandida conforme necessário. Aproveite a estrutura inicial para integrar suas funcionalidades e construir a lógica de negócios.

Se tiver dúvidas ou precisar de mais informações, consulte a [documentação do .NET 8](https://learn.microsoft.com/dotnet/).
