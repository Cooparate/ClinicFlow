# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ClinicFlow.API/ClinicFlow.API.csproj", "ClinicFlow.API/"]
COPY ["ClinicFlow.Models/ClinicFlow.Models.csproj", "ClinicFlow.Models/"]
COPY ["ClinicFlow.Services/ClinicFlow.Services.csproj", "ClinicFlow.Services/"]
COPY ["ClinicFlow.Repositories/ClinicFlow.Repositories.csproj", "ClinicFlow.Repositories/"]
COPY ["ClinicFlow.Commons/ClinicFlow.Commons.csproj", "ClinicFlow.Commons/"]
COPY ["ClinicFlow.DTOs/ClinicFlow.DTOs.csproj", "ClinicFlow.DTOs/"]
COPY ["MayNghien.Infrastructures/MayNghien.Infrastructures.csproj", "MayNghien.Infrastructures/"]

RUN dotnet restore "./ClinicFlow.API/ClinicFlow.API.csproj"
COPY . .
WORKDIR "/src/ClinicFlow.API"
RUN dotnet build "./ClinicFlow.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ClinicFlow.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClinicFlow.API.dll"]