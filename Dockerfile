# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY src/CoreBusiness.API .

RUN dotnet restore CoreBusiness.API.csproj

RUN dotnet publish CoreBusiness.API.csproj \
    -c Release \
    -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0

RUN apt-get update && \
    apt-get install -y curl && \
    rm -rf /var/lib/apt/lists/*

RUN useradd -m appuser

WORKDIR /app

COPY --from=build /app/publish .

RUN chown -R appuser:appuser /app

USER appuser

EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

HEALTHCHECK --interval=30s --timeout=5s --start-period=10s --retries=3 \
 CMD curl --fail http://localhost:8080/api/Health || exit 1

ENTRYPOINT ["dotnet", "CoreBusiness.API.dll"]