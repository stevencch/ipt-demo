## Setup IPT demo
### Database
- Run the database_creation.sql to generate db, which create db schema and sp, also insert the test data.
### Server
- Update connection string in appsettings.development.json
- Run Demo.Ipt.Web Project
- There are two verisons of repository. the api is using EF as default, the alternative is Stored Procedure with Dapper
- There are two test projects. one is unit test, the other is integration test.
### Client
- Run npm start, test react app with mock server.
- Run npm run start-integration, test react app with Web Api.
### Azure
- setup CI/CD to deploy app from Github to Azure
- https://demo-ipt.azurewebsites.net/
