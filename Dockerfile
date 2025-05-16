FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["bil.csproj", "./"]
RUN dotnet restore "bil.csproj"
COPY . .
RUN dotnet build "bil.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "bil.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bil.dll"] 
