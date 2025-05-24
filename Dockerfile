# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY KronosDashboard/*.csproj ./KronosDashboard/
RUN dotnet restore

# Copy everything else and build
COPY . .
WORKDIR /app/KronosDashboard
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/KronosDashboard/out ./
EXPOSE 80
ENTRYPOINT ["dotnet", "KronosDashboard.dll"]
