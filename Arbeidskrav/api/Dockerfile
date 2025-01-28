# Byggefasen
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Kopier prosjektfilene
COPY . ./

# Gjenopprett avhengigheter
RUN dotnet restore Arbeidskrav.csproj

# Publiser prosjektet
RUN dotnet publish Arbeidskrav.csproj -c Release -o out

# Kjøringsfasen
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Kopier den publiserte utgaven fra byggefasen
COPY --from=build /app/out .

# Start applikasjonen
ENTRYPOINT ["dotnet", "Arbeidskrav.dll"]
