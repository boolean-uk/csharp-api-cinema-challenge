# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Expose port
EXPOSE 8080

# Run your app
ENTRYPOINT ["dotnet", "api-cinema-challenge.dll"]


# Create the image with 
# sudo docker build -t dockerimage .

# Run a container
# sudo docker run -p 8080:8080   -e ASPNETCORE_URLS="http://+:8080"   -e DOTNET_ENVIRONMENT=Development   dockerimage