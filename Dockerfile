FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /src
COPY *.sln .
COPY BLOGIT.UserInterface/*.csproj KingdomProfile/
RUN dotnet restore KingdomProfile/*.csproj
COPY . .

#Publishing
FROM base AS publish
WORKDIR /src/KingdomProfile
RUN dotnet publish -c Release -o /src/publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
#ENTRYPOINT ["dotnet", "KingdomProfile.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet KingdomProfile.dll