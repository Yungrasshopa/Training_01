# make a new solution
dotnet new sln --name Animals
dotnet new console -o Animals.UI
dotnet sln add Animals.UI
dotnet new classlib -o Animals.Library
dotnet sln add Animals.Library