#FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
#WORKDIR /app
#EXPOSE 80
#
## Build the app
#FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
#WORKDIR /src
#COPY Service2.csproj ./
#RUN dotnet restore "./Service2.csproj"
#COPY . .
#WORKDIR "/src"
#RUN dotnet build "Service2.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "Service2.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Service2.dll"]

# Use the ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Build the app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY Service2.csproj ./
RUN dotnet restore "./Service2.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Service2.dll"]