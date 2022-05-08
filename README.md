## Setup IPT demo
### Database
- Run the database_creation.sql to generate db
### Server
- Update connection string in appsettings.development.json
- Run Demo.Ipt.Web Project
- There are two verisons of repository, the api is using EF as default. the alternative is Stored Procedure with Dapper
### Client
- Run npm start, test app with mock server
- Run npm run start-integration, test app with Web Api
### Azure
- setup Git Action to deploy app to Azure
- https://demo-ipt.azurewebsites.net/
