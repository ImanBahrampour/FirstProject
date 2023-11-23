FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/FirstProject.Web.Host/FirstProject.Web.Host.csproj", "src/FirstProject.Web.Host/"]
COPY ["src/FirstProject.Web.Core/FirstProject.Web.Core.csproj", "src/FirstProject.Web.Core/"]
COPY ["src/FirstProject.Application/FirstProject.Application.csproj", "src/FirstProject.Application/"]
COPY ["src/FirstProject.Core/FirstProject.Core.csproj", "src/FirstProject.Core/"]
COPY ["src/FirstProject.EntityFrameworkCore/FirstProject.EntityFrameworkCore.csproj", "src/FirstProject.EntityFrameworkCore/"]
WORKDIR "/src/src/FirstProject.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FirstProject.Web.Host", "src/FirstProject.Web.Host"]
COPY ["src/FirstProject.Web.Core", "src/FirstProject.Web.Core"]
COPY ["src/FirstProject.Application", "src/FirstProject.Application"]
COPY ["src/FirstProject.Core", "src/FirstProject.Core"]
COPY ["src/FirstProject.EntityFrameworkCore", "src/FirstProject.EntityFrameworkCore"]
WORKDIR "/src/src/FirstProject.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FirstProject.Web.Host.dll"]
