# WebUITestFramework

##### Resources
- [SpecFlow Project Template with dotnet new](https://specflow.org/blog/specflow-project-template-with-dotnet-new/)
- [SpecFlow context injection](https://docs.specflow.org/projects/specflow/en/latest/Bindings/Context-Injection.html)

### Getting started
- [Install Docker](https://www.docker.com/products/docker-desktop)
- [Install .Net Core SDK](https://dotnet.microsoft.com/download)
- [Clone this repositiry to your machine](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository)


### Run tests
#### Terminal/CMD
- Mac: [Open the Terminal app](https://www.howtogeek.com/682770/how-to-open-the-terminal-on-a-mac/) and [navigate to the repository folder](https://www.macworld.com/article/2042378/master-the-command-line-navigating-files-and-folders.html)
- Windows: [Open command prompt in repository folder](https://helpdeskgeek.com/how-to/open-command-prompt-folder-windows-explorer/)
- Execute the below commands

#### Run the tests on your machine OR...

```
cd src
dotnet test
```


#### ...in [Docker](https://www.docker.com/)

```
docker build -t test-box .
docker run test-box
```


#### Expected output
```
-> Using default config
Test run for /APITestFramework/src/bin/Debug/netcoreapp3.1/APITestFramwwork.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.6.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.
-> Loading plugin /APITestFramework/src/bin/Debug/netcoreapp3.1/TechTalk.SpecFlow.xUnit.SpecFlowPlugin.dll
-> Using default config

Test Run Successful.
Total tests: 16
     Passed: 16
 Total time: 4.1265 Seconds
 ```

### [Visual Studio Code](https://code.visualstudio.com/)

Dotnet core tests can be debugged and run from VS code.

Required extensions:
- [.Net Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
- [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
- [Cucumber (Gherkin) Full Support](https://marketplace.visualstudio.com/items?itemName=alexkrechik.cucumberautocomplete)
- [Specflow Tools](https://marketplace.visualstudio.com/items?itemName=amillard98.specflow-tools)

Include the below setting in .vscode/settings.json
```
"dotnet-test-explorer.testProjectPath" : "./src"
 ```


### Troubleshooting

###### Mac MSBuild error
- Issue: The below error when building the project
 ```
error MSB4018: The "GenerateFeatureFileCodeBehindTask" task failed unexpectedly.
 ```
- Fix: Run the below in Terminal
 ```
export MSBUILDSINGLELOADCONTEXT=1
 ```

###### Mac ChromeDriver error
 - Issue: “chromedriver” cannot be opened because the developer cannot be verified.
 - Fix: Run the below in Terminal
```
xattr -d com.apple.quarantine chromedriver
 ```