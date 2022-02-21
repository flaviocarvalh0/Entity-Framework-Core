Adicionando o pacote para a uilização do EFCore SqlServer

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer

Adicionando o pacote do design para a utilização do MIgration

    dotnet add package Microsoft.EntityFrameworkCore.Design

    dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet

Usado para criar a tabela no banco 
    dotnet ef migrations add Inicial
Usado para persistir o dado e criar o nosso banco modelado da forma q definimos
    dotnet ef database update
