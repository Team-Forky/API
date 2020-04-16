# 401 Mid-term Project 

## Project Hospitaller- Back end
---
### We are deployed on Azure!
* Back end - https://hospitaller-team-forky-api.azurewebsites.net
* Fron end - https://hospitallerfe-teamforky.azurewebsites.net


---
## Web Application

The API consists of 3 Tables that consists of Patients, Resources, & Patient Resources.
The backend was written in C# using ASP.NET Core 2, Entity Framework Core, and the MVC framework.

* With this API, a care-taker will be able to enter, retrieve, update, or remove a patient from a database. 
* Care-taker will be able to enter a patients name, age, status, and check in date/time when created.
---

## Tools Used
Microsoft Visual Studio Community 2019

- C#
- ASP.Net Core
- Entity Framework
- MVC
- Azure

---

## Getting Started

Clone this repository to your local machine.

```
$ git clone https://github.com/Team-Forky/API.git
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2017 (or greater) to build the web application. The solution file is located in the AmandaFE subdirectory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. Before running the application, the provided code-first migration will need to be applied to the SQL server of your choice configured in the /Team-Forky-API/Team-Forky-API/appsettings.json file. This requires the Microsoft.EntityFrameworkCore.Tools NuGet package and can be run from the NuGet Package Manager Console:
```
Update-Database
```
Once the database has been created, the application can be run. Options for running and debugging the application using IIS Express or Kestrel are provided within Visual Studio. From the command line, the following will start an instance of the Kestrel server to host the application:
```
cd YourRepo/YourProject
dotnet run
```
---

## Overview

### Reading all patients
* [route/api/Patients]()
* [Overview of Recent Posts]()

### Viewing a patient
* route/api/Patient/{id}
* [Details of Post]()

### Creating a patient
* route
* [Post Creation]()

### Updating a patient
* route
* [Enriching Post]()


---
## Data Flow (Frontend, Backend, REST API)
![Data Flow Diagram](assets/ERD.png)

---
## Data Model

### Overall Project Schema
***[Add a description of your DB schema. Explain the relationships to me.]***
[Database Schema]()

---
## Model Properties and Requirements

### Patients

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Name | string | YES |
| Birthday | string | YES |
| Status | enum | YES |
| CheckIn | string | YES |

### Resources

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Name | string | YES |
| Description | string | YES |
| Type | enum | YES |

### PatientResources

| Parameter | Type | Required |
| --- | --- | --- |
| PatientID  | int | YES |
| ResourcesID | int | YES |

---

## Change Log
1.1: *Deploy database and backend with dummy DTO data for Patient* - 13 April 2020  

---

## Authors
Joseph Hangarter
Teddy Damian
---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
