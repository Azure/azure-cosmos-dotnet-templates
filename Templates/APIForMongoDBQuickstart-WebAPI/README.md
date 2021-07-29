# .NET Core Quickstart Template for the API for MongoDB

## Install the Template

This quickstart is built as a template to be installed using the dotnet CLI. You can install the template locally after cloning this repository using the following commands. The template will also be pushed to NuGet in the near future.

Install the template from the root folder of this project.

```cmd
dotnet new -i .\
```

Once the template is installed, create a new project.

```cmd
cd preferred\location\of\project
dotnet new cosmosmongo-webapi
```

## Setup the Project

### Provision a Cosmos DB API for MongoDB account

Follow [these instructions](https://docs.microsoft.com/en-us/azure/cosmos-db/create-mongodb-dotnet#create-a-database-account) to create a database account.

### Update secrets

Modify the `appsettings.json` file to match your configuration. Enter your connection string and modify the database and collection names if you created them with different names.

Find your connection string by selecting your Cosmos DB account in the Azure portal. Click Connection String in the left navigation, and then click Read-write Keys. Use the copy buttons on the right side of the screen to copy the Primary Connection String.

```json
  "DatabaseSettings": {
    "MongoConnectionString": "<enter connection string here>",
    "DatabaseName": "cosmicworks",
    "ProductCollectionName": "products"
  }
```

### Load sample data

Use [mongoimport](https://docs.mongodb.com/database-tools/mongoimport/#mongodb-binary-bin.mongoimport) to load the sample products provided in the `Data` folder of this project. Mongoimport is a command line tool that allows you to easily import small amounts of JSON, CSV or TSV data. [Download](https://www.mongodb.com/try/download/database-tools) the tool and run the following from the root folder to load the sample data. Update the host, port, username, and password with values from the Connection String left navigation blade in the Azure portal. Be sure to also update the database and collection names if you named yours differently.

```cmd
mongoimport --host <HOST>:<PORT> -u <USERNAME> -p <PASSWORD> --db cosmicworks --collection products --ssl --jsonArray --writeConcern="{w:0}" --file Data/products.json
```

> Note: If you would like to skip this step you can create documents with the correct schema via the POST endpoint provided in this project.

## Run the Project

Enter the following at the command line from the root directory of the project.

```cmd
dotnet run 
```

After the application is running, navigate to [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html) to see the swagger documentation for the web api and to submit sample requests.

Click on the API you would like to test and select "Try it out".

![try-swagger](../../Images/try-swagger.png)
