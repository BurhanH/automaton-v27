# automaton-v27

Automation testing framework (API) - an example. Based on C#, .Net8, MSTest, XUnit, Refit

[![GitHub](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/BurhanH/automaton-v27/blob/master/LICENSE)
[![MSTest tests](https://github.com/BurhanH/automaton-v27/actions/workflows/dotnet-mstest.ymll/badge.svg)](https://github.com/BurhanH/automaton-v27/actions/workflows/dotnet-mstest.yml)
[![XUnit tests](https://github.com/BurhanH/automaton-v27/actions/workflows/dotnet-xunit.yml/badge.svg)](https://github.com/BurhanH/automaton-v27/actions/workflows/dotnet-xunit.yml)
![](https://badgen.net/static/made/by%20human/green)

This testing framework to test REST API for [https://jsonplaceholder.typicode.com](https://jsonplaceholder.typicode.com). Simple calls like GET, PATCH, DELETE.

## Requirements
.Net8, Refit 8.0.0, <br>
MSTest<br>
XUnit<br>

## Project structure
```text
-- automaton-v27
   `-- .github
       `-- workflows
           |-- dotnet-mstest.yml
           |-- dotnet-xunit.yml
   `-- ClientApi
       |-- ClientApi.csproj
       |-- ClientApi.sln
       |-- IApiClient.cs
       |-- PostCommentResponse.cs
       |-- PostResponse.cs
   `-- MSTestTestFramework
       |-- ClientApiTest.cs
       |-- GlobalUsing.cs
       |-- MSTestTestFramework.csproj
       |-- MSTestTestFramework.sln
   `-- MSTestTestFramework
       |-- ClientApiTest.cs
       |-- GlobalUsing.cs
       |-- XUnitTestFramework.csproj
       |-- XUnitTestFramework.sln
   |-- .gitignore
   |-- LICENSE
   |-- README.md
```

## Documentation and Distributives

1. [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
2. [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
3. [MSTest](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-mstest)
4. [XUnit](https://xunit.net/)
5. [Refit](https://reactiveui.github.io/refit/)
6. [GitHub Actions](https://github.com/features/actions)
