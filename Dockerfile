FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

RUN apt-get update -y \
    && apt-get upgrade -y \
    && apt-get install git -y

# Copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore

# Copy everything else and build
RUN dotnet build -c Release HomeAutomations/HomeAutomations.csproj

FROM netdaemon/netdaemon4:24.43.0

WORKDIR /data

COPY --from=build-env /app/HomeAutomations/bin/Release/net8.0 .
