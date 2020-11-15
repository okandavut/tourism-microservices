<h2 align="center"> Tourism Microservices</h2> 

## Table of Contents

- [Introduction](#introduction)
- [Structure](#structure)
- [Technologies](#technologies)
- [Feedback](#feedback)
- [Build Process](#build-process)
- [Contributors](#contributors)


## Introduction

This project developed for learning how is the ASP .NET Core Microservices and Ocelot working. Project has two ASP .NET Core Microservice and one API Gateway which is working with Ocelot. Also includes the ElasticSearch for log requests and responses.

## Structure
- Api-gateway (.NET Core 3.1 Project with Ocelot)
- Hotels Api (.NET Core 3.1 Project)
- Tours Api (.NET Core 3.1 Project)


    ![Project structure](/project-structre.png)

## Technologies

- [ASP .NET Core 3.1](https://docs.microsoft.com/)
- [Ocelot](https://github.com/ThreeMammals/Ocelot)
- [Elastic Search - Kibana](https://www.elastic.co/)
- [PostgreSQL](https://www.postgresql.org/)

## Feedback

Feel free to send me feedback on [Twitter](https://twitter.com/okandavutcom) or [file an issue](https://github.com/okandavut/tourism-microservices/issues/new). Feature requests are always welcome. If you wish to contribute, please open your pull request and add me reviewer.

If there's anything you'd like to chat about, please feel free send me dm on [Twitter](https://twitter.com/okandavutcom)!


## Build Process

- Clone the projects
- Download PostgreSQL and create ToursDb and HotelsDb (check appsettings.json for db and user informations.)
- Open with Visual Studio or launch with <b>"dotnet run"</b>

## Contributors


<!-- markdownlint-enable -->
<!-- prettier-ignore-end -->
<!-- ALL-CONTRIBUTORS-LIST:END -->

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="https://medium.com/@okandavut"><img src="https://avatars3.githubusercontent.com/u/10600157?v=4" width="100px;" alt=""/><br /><sub><b>Okan DAVUT</b></sub></a><br /><a href="#infra-okandavut" title="Infrastructure (Hosting, Build-Tools, etc)">🚇</a> <a href="https://github.com/okandavut/tourism-microservices/commits?author=okandavut" title="Tests">⚠️</a> <a href="https://github.com/okandavut/tourism-microservices/commits?author=okandavut" title="Code">💻</a></td>
  </tr>
</table>

<!-- markdownlint-enable -->
<!-- prettier-ignore-end -->
<!-- ALL-CONTRIBUTORS-LIST:END -->

## LICENSE
[MIT](LICENSE)




