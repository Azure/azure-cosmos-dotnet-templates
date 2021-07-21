# Azure Cosmos DB .NET Templates

This project contains .NET templates and samples for Cosmos DB. The table below contains the current list of templates.

|API |Template Type|Installation Short Name|Instructions|
|----|-------------|-----------------------|------------|
|API for MongoDB|Web API quickstart|cosmosmongo-webapi|[README.md](./Templates/APIForMongoDBQuickstart-WebAPI/README.md)|

## Install the Templates

These templates can be installed using the dotnet CLI. You can install the templates locally after cloning this repository using the following commands. They will also be pushed to NuGet in the near future.

Install the templates from the root folder of this project.

```cmd
dotnet new -i .\
```

Once they are installed, create a new project. For example, the following commands will create the API for MongoDB Web API quickstart.

```cmd
cd preferred\location\of\project
dotnet new cosmosmongo-webapi
```

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft 
trademarks or logos is subject to and must follow 
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.
