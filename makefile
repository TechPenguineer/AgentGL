all:
	make interpreter
	
interpreter:
	dotnet build src/Hades.Core/Hades.Core.csproj

run:
	dotnet run --project src/Hades.Core/Hades.Core.csproj
