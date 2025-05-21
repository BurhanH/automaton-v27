# automaton-v27

Automation testing framework (API) - an example. Based on C#, .Net8, MSTest, XUnit, Refit

[![GitHub](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/BurhanH/automaton-v27/blob/master/LICENSE)
[![MSTest](https://github.com/BurhanH/automaton-v27/actions/workflows/dotnet-mstest.yml/badge.svg)](https://github.com/BurhanH/automaton-v27/actions/workflows/dotnet-mstest.yml)
[![XUnit](https://github.com/BurhanH/automaton-v27/actions/workflows/dotnet-xunit.yml/badge.svg)](https://github.com/BurhanH/automaton-v27/actions/workflows/dotnet-xunit.yml)
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

## Getting Started

This section explains how to set up the project locally and run the tests.

### Cloning the Repository

1.  Open your terminal or command prompt.
2.  Navigate to the directory where you want to clone the project.
3.  Run the following command:

    ```bash
    git clone https://github.com/BurhanH/automaton-v27.git
    ```
4.  Change into the cloned directory:

    ```bash
    cd automaton-v27
    ```

### Installing Dependencies

This project uses .NET 8. Ensure you have the .NET 8 SDK installed. You can download it from [here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

Once the SDK is installed, open your terminal in the root directory of the cloned project and run the following command to restore the necessary packages for all projects (ClientApi, MSTestTestFramework, and XUnitTestFramework):

```bash
dotnet restore ClientApi/ClientApi.sln && dotnet restore MSTestTestFramework/MSTestTestFramework.sln && dotnet restore XUnitTestFramework/XUnitTestFramework.sln
```
Or, if you are in the root of the repository, you can also restore all projects by iterating through solution files:
```bash
for sln_file in $(find . -name '*.sln'); do dotnet restore $sln_file; done
```

### Running Tests

You can run tests using either MSTest or XUnit. Make sure you are in the root directory of the project in your terminal.

#### MSTest

To run the MSTest tests, navigate to the MSTest project directory and use the `dotnet test` command:

```bash
cd MSTestTestFramework
dotnet test
cd .. 
```
This command will discover and execute all tests within the `MSTestTestFramework` project.

#### XUnit

To run the XUnit tests, navigate to the XUnit project directory and use the `dotnet test` command:

```bash
cd XUnitTestFramework
dotnet test
cd ..
```
This command will discover and execute all tests within the `XUnitTestFramework` project.

## Documentation and Distributives

1. [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
2. [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
3. [MSTest](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-mstest)
4. [XUnit](https://xunit.net/)
5. [Refit](https://reactiveui.github.io/refit/)
6. [GitHub Actions](https://github.com/features/actions)

## Contributing

We welcome contributions to improve and expand this testing framework! If you'd like to contribute, please follow these general steps:

1.  **Fork the Repository:**
    Start by forking the main repository to your own GitHub account.

2.  **Create a New Branch:**
    Before making any changes, create a new branch in your forked repository. This helps keep your changes organized and separate from the `main` branch. Choose a descriptive branch name (e.g., `feature/add-new-endpoint-tests`, `bugfix/fix-auth-issue`).
    ```bash
    git checkout -b your-branch-name
    ```

3.  **Make Your Changes:**
    Implement your feature, fix the bug, or improve the documentation. Ensure your code adheres to the existing style and that you add or update tests as necessary.

4.  **Commit Your Changes:**
    Once you're satisfied with your changes, commit them with a clear and concise commit message.
    ```bash
    git add .
    git commit -m "Your descriptive commit message"
    ```

5.  **Push to Your Fork:**
    Push your new branch and its commits to your forked repository on GitHub.
    ```bash
    git push origin your-branch-name
    ```

6.  **Submit a Pull Request (PR):**
    Go to the original repository on GitHub and open a new pull request. Select your forked repository's branch to be merged into the main repository's `main` branch (or the appropriate target branch).
    Provide a clear title and description for your PR, outlining the changes you've made and why.

7.  **Discussion and Review:**
    Your PR will be reviewed, and there might be some discussion or requests for changes. Once everything is approved, your contribution will be merged.

Thank you for your interest in contributing!
