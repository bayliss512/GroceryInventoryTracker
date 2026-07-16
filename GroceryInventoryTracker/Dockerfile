# Build the web project only; the Tests project isn't needed in the runtime image.
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["GroceryInventoryTracker/GroceryInventoryTracker.csproj", "GroceryInventoryTracker/"]
RUN dotnet restore "GroceryInventoryTracker/GroceryInventoryTracker.csproj"

COPY GroceryInventoryTracker/ GroceryInventoryTracker/
WORKDIR /src/GroceryInventoryTracker
RUN dotnet publish -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "GroceryInventoryTracker.dll"]
