# 1. Set base image
FROM mcr.microsoft.com/dotnet/sdk:8.0

# 2. Set working directory
WORKDIR /App

# 3. Copy source code and restore dependencies
COPY . ./
RUN dotnet restore

# 4. Build and publish the app
RUN dotnet publish -c Release -o out

# 5. Set working directory to output folder
WORKDIR /App/out

# 6. Run the application
ENTRYPOINT ["dotnet", "BooksApi.dll"]