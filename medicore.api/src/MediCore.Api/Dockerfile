FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
ARG source
WORKDIR /app
EXPOSE 5001
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "MediCore.Api.dll"]
