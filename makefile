all:
	make interpreter
	
interpreter:
	mkdir ./bin/
	dotnet build src/Hades.Core/Hades.Core.csproj -o bin/

run:
	dotnet run --project src/Hades.Core/Hades.Core.csproj

