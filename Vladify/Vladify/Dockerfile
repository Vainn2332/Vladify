@ -0,0 +1,29 @@
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080 

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["Vladify/Vladify.csproj", "Vladify/"]
COPY ["Vladify.BusinessLogic/Vladify.BusinessLogic.csproj", "Vladify.BusinessLogic/"]
COPY ["Vladify.DataAccess/Vladify.DataAccess.csproj", "Vladify.DataAccess/"]

RUN dotnet restore "Vladify/Vladify.csproj"

COPY . .

WORKDIR "/src/Vladify"

RUN dotnet build "Vladify.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vladify.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

USER app

ENTRYPOINT ["dotnet", "Vladify.dll"]
