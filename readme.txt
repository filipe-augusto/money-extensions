-dotnet new classlib -o MoneyExtesion
-dotnet new mstest -o MoneyExtesion.Tests
-dotnet new sln

-dotnet sln add .\MoneyExtesion
-dotnet sln add .\MoneyExtesion.Tests

entrar na pasta MoneyExtesion.Tests[para adicionar a referenc].
-dotnet add reference ..\MoneyExtesion\



