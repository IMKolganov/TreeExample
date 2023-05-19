FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TreeExample/TreeExample.csproj", "TreeExample/"]
RUN dotnet restore "TreeExample/TreeExample.csproj"
COPY . .
WORKDIR "/src/TreeExample"
RUN dotnet build "TreeExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TreeExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TreeExample.dll"]
