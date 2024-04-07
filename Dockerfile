##See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["jobseeker_jobs_api/jobseeker_jobs_api.csproj", "jobseeker_jobs_api/"]
RUN dotnet restore "jobseeker_jobs_api/jobseeker_jobs_api.csproj"
COPY . .
WORKDIR "/src/jobseeker_jobs_api"
RUN dotnet build "jobseeker_jobs_api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "jobseeker_jobs_api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "jobseeker_jobs_api.dll"]
