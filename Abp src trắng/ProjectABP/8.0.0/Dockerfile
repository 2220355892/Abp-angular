FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/ProjectABP.Web.Host/ProjectABP.Web.Host.csproj", "src/ProjectABP.Web.Host/"]
COPY ["src/ProjectABP.Web.Core/ProjectABP.Web.Core.csproj", "src/ProjectABP.Web.Core/"]
COPY ["src/ProjectABP.Application/ProjectABP.Application.csproj", "src/ProjectABP.Application/"]
COPY ["src/ProjectABP.Core/ProjectABP.Core.csproj", "src/ProjectABP.Core/"]
COPY ["src/ProjectABP.EntityFrameworkCore/ProjectABP.EntityFrameworkCore.csproj", "src/ProjectABP.EntityFrameworkCore/"]
WORKDIR "/src/src/ProjectABP.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ProjectABP.Web.Host", "src/ProjectABP.Web.Host"]
COPY ["src/ProjectABP.Web.Core", "src/ProjectABP.Web.Core"]
COPY ["src/ProjectABP.Application", "src/ProjectABP.Application"]
COPY ["src/ProjectABP.Core", "src/ProjectABP.Core"]
COPY ["src/ProjectABP.EntityFrameworkCore", "src/ProjectABP.EntityFrameworkCore"]
WORKDIR "/src/src/ProjectABP.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ProjectABP.Web.Host.dll"]
