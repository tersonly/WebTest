FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
#监听的端口 不填默认是80
ENV ASPNETCORE_URLS http://+:8088
FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
#将context文件复制到src中
COPY . .
RUN dotnet restore "WebTest.csproj"
RUN dotnet build "WebTest.csproj" -c Release -o /app
FROM build AS publish
RUN dotnet publish "WebTest.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebTest.dll"]