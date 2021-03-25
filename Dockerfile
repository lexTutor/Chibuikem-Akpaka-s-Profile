FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /src
COPY *.sln .
COPY KingdomProfile/*.csproj KingdomProfile/
RUN dotnet restore KingdomProfile/*.csproj
COPY . .

#Publishing
FROM base AS publish
WORKDIR /src/KingdomProfile
RUN dotnet publish -c Release -o /src/publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "KingdomProfile.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet KingdomProfile.dll