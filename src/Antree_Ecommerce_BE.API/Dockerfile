FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Antree_Ecommerce_BE.API/Antree_Ecommerce_BE.API.csproj", "src/Antree_Ecommerce_BE.API/"]
COPY ["src/Antree_Ecommerce_BE.Application/Antree_Ecommerce_BE.Application.csproj", "src/Antree_Ecommerce_BE.Application/"]
COPY ["src/Antree_Ecommerce_BE.Contract/Antree_Ecommerce_BE.Contract.csproj", "src/Antree_Ecommerce_BE.Contract/"]
COPY ["src/Antree_Ecommerce_BE.Domain/Antree_Ecommerce_BE.Domain.csproj", "src/Antree_Ecommerce_BE.Domain/"]
COPY ["src/Antree_Ecommerce_BE.Persistence/Antree_Ecommerce_BE.Persistence.csproj", "src/Antree_Ecommerce_BE.Persistence/"]
COPY ["src/Antree_Ecommerce_BE.Infrastructure/Antree_Ecommerce_BE.Infrastructure.csproj", "src/Antree_Ecommerce_BE.Infrastructure/"]
COPY ["src/Antree_Ecommerce_BE.Presentation/Antree_Ecommerce_BE.Presentation.csproj", "src/Antree_Ecommerce_BE.Presentation/"]
RUN dotnet restore "src/Antree_Ecommerce_BE.API/Antree_Ecommerce_BE.API.csproj"
COPY . .
WORKDIR "/src/src/Antree_Ecommerce_BE.API"
RUN dotnet build "Antree_Ecommerce_BE.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Antree_Ecommerce_BE.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Antree_Ecommerce_BE.API.dll"]
