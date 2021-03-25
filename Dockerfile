FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR ./KingdomProfile

COPY *.sln .
COPY KingdomProfile.csproj KingdomProfile/
RUN dotnet restore KingdomProfile.csproj
COPY . .
RUN dotnet build

#Publishing
FROM base AS publish
RUN dotnet publish -c Release -o /src/publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
#ENTRYPOINT ["dotnet", "KingdomProfile.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet KingdomProfile.dll
