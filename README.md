#Modelo MVC com Migrations

1. Caso queira usar outra versão do DotNet que não seja o 6.0, troque <TargetFramework>net6.0</TargetFramework> para a versão desejada.
2. Exclua as pastas obj/ e bin/ com todo o seu conteudo.
3. Troque o nome do arquivo ModeloMigrationsMVC.csproj para o nome da sua aplicação.
4. Troque a senha de acesso ao servidor postgres no arquivo appsettings.json, retirando as "".
5. troque TODAS 20 as palavras ModeloMigrationsMVC para o nome da sua aplicação, inclusive as palavras compostas, ex: "ModeloMigrationsMVCContext" para "NomeDaSuaAplicacaoContext", Caso utilize o vs code é só usar a lupa e trocar tudo de uma vez.
> Na busca vai aparecer 23 palavras, mas 3 delas estão no README.
6. Quando finalizar a troca das palavras, verifique se existem as pastas obj/ e bin/ e caso existam, exclua as pastas com todo o seu conteudo.
7. Utilize o comando dotnet restore caso esteja utilizando o vscode.
8. No vscode utilize o comando dotnet ef migrations add NomeDaMigration
9. No vscode utilize o comando dotnet ef database update


