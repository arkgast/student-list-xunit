#!/bin/bash

# Commands used in this project 

# Create a solution file
dotnet new sln -n student-list-xunit

# Create a library
dotnet new classlib -o StudentList.Services

# Create a test project using xunit framework
dotnet new xunit -o StudentList.Tests

# Add project references
dotnet sln add StudentList.Services/StudentList.Services.csproj
dotnet sln add StudentList.Tests/StudentList.Tests.csproj

# Build to make sure that everything is working as expected
dotnet build student-list-xunit.sln
