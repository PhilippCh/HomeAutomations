FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HomeAutomations.Scale2Mqtt/HomeAutomations.Scale2Mqtt.csproj", "HomeAutomations.Scale2Mqtt/"]
RUN dotnet restore "HomeAutomations.Scale2Mqtt/HomeAutomations.Scale2Mqtt.csproj"
COPY . .
WORKDIR "/src/HomeAutomations.Scale2Mqtt"
RUN dotnet build "HomeAutomations.Scale2Mqtt.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HomeAutomations.Scale2Mqtt.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeAutomations.Scale2Mqtt.dll"]
