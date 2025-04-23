### Clone project

```
$ git clone https://github.com/shogunfighter/purcell-demo-numbers
```

```
~ from root
$ dotnet new xunit -n MissingNumberApp.Tests
$ dotnet add MissingNumberApp.Tests/MissingNumberApp.Tests.csproj 
$ reference MissingNumberApp/MissingNumberApp.csproj
```

### Test cases

```
~ from root
$ cd MissingNumberApp.Tests
$ dotnet add package xunit
$ dotnet add package xunit.runner.visualstudio\
$ dotnet test
```

### Run Code

```
~ from root
$ cd MissingNumberApp
$ dotnet run
```