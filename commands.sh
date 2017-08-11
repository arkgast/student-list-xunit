#!/bin/bash

# Commands used in this project 

# Create a solution file
dotnet new sln -n student-list-xunit

# Create a library
dotnet new classlib -o StudentList.Services

# Create a test project using xunit framework
dotnet new xunit -o StudentList.Tests

# Create a console project
dotnet new console -o StudentList.Console

# Add project references
dotnet sln add StudentList.Services/StudentList.Services.csproj
dotnet sln add StudentList.Tests/StudentList.Tests.csproj
dotnet sln add StudentList.Console/StudentList.Console.csproj

# Build to make sure that everything is working as expected
dotnet build student-list-xunit.sln

# Add moq framekwork
dotnet add StudentList.Tests/StudentList.Tests package moq

# Add StudentList.Services reference to StudentList.Tests in order to perform tests
dotnet add StudentList.Tests/StudentList.Tests.csproj reference StudentList.Services/StudentList.Services.csproj
dotnet add StudentList.Console/StudentList.Console.csproj reference StudentList.Services/StudentList.Services.csproj

# Test
dotnet test StudentList.Tests/StudentList.Tests.csproj
