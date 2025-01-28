# Cinema Booking API Challenge

## Learning Objectives
- Use ASP.NET and Entity Framework to build a RESTful API
- Use object-oriented programming to manage source code complexity
- Use an API client (Postman, Insomnia, etc.) to test-drive code

## Instructions

It's time to use everything you've learned up to this point! Your task is to build a complete API in C# using ASP.NET and Entity Framework. Treat this challenge like a real project, not just an exercise to complete. Take time to read documentation, experiment & discuss ideas with your peers and teachers.

1. Fork this repository
2. Clone your fork to your machine
3. Open the api-cinema-challenge solution with Visual Studio
4. Create appsettings.json with your own db credentials.  Note that the Data folder already contains a CinemaContext which you may use to add your DbSets.
5. Create a complete ERD to describe the model of your data and the relationships between each entity
6. Check the Program.cs and make any changes needed before starting.
7. Separate out your code in the Data context with seeders, Models, Repository layer, Endpoints layer (controllers).
8. Finally your task is to develop the API that [satisfies this API spec](https://boolean-uk.github.io/csharp-api-cinema-challenge/)


Pay close attention to the details of each endpoint. How you choose to implement the solution is up to you, there are no wrong answers, but the inputs and outputs must match the provided API documentation exactly.

## Extensions

[Here is an extension API spec.](https://boolean-uk.github.io/csharp-api-cinema-challenge/extensions)

It contains a few new routes, different approaches to data mutation and, most importantly, an entirely different response format for each request.

## Bonus
- When creating and entity that contains a reference to another entity, if that other entity does not exist then create that other entity if the data is correct.

### Tips
- Beware of cyclical Json and Db Entities reference
  - Use decorators to ignore model values to json ignore
  - You could create different Data Transfer Objects to avoid those dependencies
Entity with cyclical dependance: 
```json
{
  "id": 0,
  "name": "string",
  "otherEntity": {
    "id": 0,
    "entity": { // <------- Root entity is repeated here, resulting for child entity being repeated and goes on and on.
        "id": 0,
        "otherEntity" {
            ...The whole structure repeats infinitely...
        }
    }
  }t .
}
```

## Entity Diagram
CHECK IMAGE FOLDER FOR ENTITY DIAGRAM

Current:
- Create the ERD
- Create models
- Create Controllers with routes to satisfy the API
- Create Relationships between the components as shown in the ERD

## Useful Resources

You'll need to do a fair amount of research in order to complete this challenge. Make liberal use of StackOverflow, search engines, YouTube and the teaching team.

Here are some reference documentation links that will be useful:

- [Enitity Framwork Core Documentation](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)
- [model-json-ignore-properties](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/ignore-properties?pivots=dotnet-7-0)
