FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Assignment.Web.Host/Assignment.Web.Host.csproj", "src/Assignment.Web.Host/"]
COPY ["src/Assignment.Web.Core/Assignment.Web.Core.csproj", "src/Assignment.Web.Core/"]
COPY ["src/Assignment.Application/Assignment.Application.csproj", "src/Assignment.Application/"]
COPY ["src/Assignment.Core/Assignment.Core.csproj", "src/Assignment.Core/"]
COPY ["src/Assignment.EntityFrameworkCore/Assignment.EntityFrameworkCore.csproj", "src/Assignment.EntityFrameworkCore/"]
WORKDIR "/src/src/Assignment.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Assignment.Web.Host", "src/Assignment.Web.Host"]
COPY ["src/Assignment.Web.Core", "src/Assignment.Web.Core"]
COPY ["src/Assignment.Application", "src/Assignment.Application"]
COPY ["src/Assignment.Core", "src/Assignment.Core"]
COPY ["src/Assignment.EntityFrameworkCore", "src/Assignment.EntityFrameworkCore"]
WORKDIR "/src/src/Assignment.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Assignment.Web.Host.dll"]
