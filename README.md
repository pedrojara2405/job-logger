### JobLogger ###

#Info about the original code snipped:
"The code is used to log different messages throughout an application. We want the ability to be able to log to a text file, the console and/or the database. Messages can be marked as message, warning or error. We also want the ability to selectively be able to choose what gets logged, such as to be able to log only errors or only errors and warnings."

#JobLogger repository contains solutions for backend and frontend projects in order to reach a real scenario from a bit part of the recruitment process related to candidates, taken as base the previous info about the original code snipped.

#Epic:
As a Recluter User, 
I want to have a Job Logger system which I can to signing and to make maintenance about candidate info. I also want the ability to selectively be able to choose what gets logged, such as to be able to log only errors or only errors and warnings. Even more I want to have the ability to be able to log to a text file, the console and/or the database
so that I can manage the candidate data and log all events about related to candidate maintenance such as messages, warnings and/or errors throught different selectable contexts.

#User Story US001:
As a Recluter User, 
I want to be able signing and to make maintenance about candidate info 
so that i can to do CRUD process about candidates.

#Acceptance Criteria (US001):

Ensures that Recluter User is able to:

- Sign in to Job Logger application
- Navigate to Candidate Maintenance
- Create/Read/Update/and Delete candidate data

#User Story US002:
As a Recluter User, 
I want to selectively be able to choose what gets logged, such as to be able to log only errors or only errors and warnings. Even more I want to have the ability to be able to log to a text file, the console and/or the database
so that the application can to log many kind of events such as messages, warnings and/or errors, which the application could support concurencia for many selective contexts such as text file, console and/or database

#Acceptance Criteria (US002):

Ensures that the system is able to:

- Log events related to signing user and candidate´s maintenance such as messages, warnings and/or errors, which the application could support multi-thread for only one instance, using Singleton constructor pattern
- Support many kind of context to log messages such as text file, console and/or database.

#Technologies used:
-C#
-ASP.NET
-WebAPI
-Javascript
-Bootstrap
-HTML
-SQL
-Unit Testing
-AngularJS 
-ORM

#Requirements
Sql Management Studio 2012 or over, in order to support LocalDb
Visual Studio 2012 or over
NodeJs

=======================================================================================================
#.gitignore file:
Created by https://www.gitignore.io/api/macos,windows,angular,visualstudio,visualstudiocode

#Old.JobLogger.Console:
Contains the original code snipped about JobLogger class. All this code was commented because this produced 17 compilation errors.

#Api.JobLogger
It is a Web API project using MVC templatete. Even more to apply ORM, was added Entity Framework with Code First model and to keep a source control about DDL files, we used Entity Framework Migrations.

#SQL LocalDB instance was used as Database repository
The application connect using a new login with User ID = RecluterUser and Password = ruPw123

#Api.JobLogger.Tests
Contains all developed unit tests about Api.JobLogger project. Mainly unit tests about controllers