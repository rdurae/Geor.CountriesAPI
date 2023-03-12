FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/Geor.CountriesAPI.Web.Host/Geor.CountriesAPI.Web.Host.csproj", "src/Geor.CountriesAPI.Web.Host/"]
COPY ["src/Geor.CountriesAPI.Web.Core/Geor.CountriesAPI.Web.Core.csproj", "src/Geor.CountriesAPI.Web.Core/"]
COPY ["src/Geor.CountriesAPI.Application/Geor.CountriesAPI.Application.csproj", "src/Geor.CountriesAPI.Application/"]
COPY ["src/Geor.CountriesAPI.Core/Geor.CountriesAPI.Core.csproj", "src/Geor.CountriesAPI.Core/"]
COPY ["src/Geor.CountriesAPI.EntityFrameworkCore/Geor.CountriesAPI.EntityFrameworkCore.csproj", "src/Geor.CountriesAPI.EntityFrameworkCore/"]
WORKDIR "/src/src/Geor.CountriesAPI.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Geor.CountriesAPI.Web.Host", "src/Geor.CountriesAPI.Web.Host"]
COPY ["src/Geor.CountriesAPI.Web.Core", "src/Geor.CountriesAPI.Web.Core"]
COPY ["src/Geor.CountriesAPI.Application", "src/Geor.CountriesAPI.Application"]
COPY ["src/Geor.CountriesAPI.Core", "src/Geor.CountriesAPI.Core"]
COPY ["src/Geor.CountriesAPI.EntityFrameworkCore", "src/Geor.CountriesAPI.EntityFrameworkCore"]
WORKDIR "/src/src/Geor.CountriesAPI.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Geor.CountriesAPI.Web.Host.dll"]
