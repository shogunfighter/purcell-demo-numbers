### Clone project

```
$ git clone https://github.com/shogunfighter/purcell-demo-numbers
```

### XUnit Test template
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

-- do this one time, if you don't have xunit added yet
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