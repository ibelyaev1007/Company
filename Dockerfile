FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-image
WORKDIR /home/app
COPY ./*.sln ./
COPY ./*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done
RUN dotnet restore
COPY . .
RUN dotnet publish ./MyCompany/MyCompany.csproj -o /publish/
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /publish
COPY --from=build-image /publish .
ENV ASPNETCORE_URLS=https://+:5001;http://+:5000
ENTRYPOINT ["dotnet", "MyCompany.dll"] 
