FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["OrderDetail/OrderDetail.csproj", "OrderDetail/"]
RUN dotnet restore "OrderDetail/OrderDetail.csproj"
COPY . .
WORKDIR "/src/OrderDetail"
RUN dotnet build "OrderDetail.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "OrderDetail.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OrderDetail.dll"]