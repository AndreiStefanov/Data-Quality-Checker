# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiază doar .csproj întâi — Docker cache-uiește layer-ul de restore
# dacă nu s-au schimbat dependențele
COPY ["Data Quality Checker/Data Quality Checker.csproj", "Data Quality Checker/"]
RUN dotnet restore "Data Quality Checker/Data Quality Checker.csproj"

# Copiază restul și build
COPY . .
WORKDIR "/src/Data Quality Checker"
RUN dotnet publish "Data Quality Checker.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 2: Runtime (fără SDK — imagine finală cu sute de MB mai mică)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Data_Quality_Checker.dll"]