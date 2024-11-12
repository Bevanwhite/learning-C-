
testapi:
	cd ${name} && dotnet run

testrestore:
	cd ${name} && dotnet restore && dotnet build

testnew:
	dotnet new console -n ${name}

