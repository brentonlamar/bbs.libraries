# Gets Version from AsseblyInfo.cs updates nuspec's version
if [ "$TRAVIS_BRANCH" == "adding-nuget" ]; then
	echo "========================================================="
	echo "Updating nuspec version"

	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Contracts/BBS.Libraries.Contracts.nuspec
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Emails/BBS.Libraries.Emails.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Enums/BBS.Libraries.Enums.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Extensions/BBS.Libraries.Extensions.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.IO/BBS.Libraries.IO.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Logging/BBS.Libraries.Logging.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Logging.AppInsights/BBS.Libraries.Logging.AppInsights.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.SQL/BBS.Libraries.SQL.nuspec   
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Templating/BBS.Libraries.Templating.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Templating.Handlebars/BBS.Libraries.Templating.Handlebars.nuspec  
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\11.0.${TRAVIS_BUILD_NUMBER}.0\2|g" ./BBS.Libraries.Templating.Razor/BBS.Libraries.Templating.Razor.nuspec  

	echo "========================================================="

	echo "Starting to pack the NuGet packages"

	nuget pack ./BBS.Libraries.Contracts/BBS.Libraries.Contracts.nuspec 
	nuget pack ./BBS.Libraries.Emails/BBS.Libraries.Emails.nuspec 
	nuget pack ./BBS.Libraries.Enums/BBS.Libraries.Enums.nuspec 
	nuget pack ./BBS.Libraries.Extensions/BBS.Libraries.Extensions.nuspec 
	nuget pack ./BBS.Libraries.IO/BBS.Libraries.IO.nuspec 
	nuget pack ./BBS.Libraries.Logging/BBS.Libraries.Logging.nuspec 
	nuget pack ./BBS.Libraries.Logging.AppInsights/BBS.Libraries.Logging.AppInsights.nuspec 
	nuget pack ./BBS.Libraries.SQL/BBS.Libraries.SQL.nuspec 
	nuget pack ./BBS.Libraries.Templating/BBS.Libraries.Templating.nuspec 
	nuget pack ./BBS.Libraries.Templating.Handlebars/BBS.Libraries.Templating.Handlebars.nuspec 
	nuget pack ./BBS.Libraries.Templating.Razor/BBS.Libraries.Templating.Razor.nuspec 

	echo "Finished packing."

	echo "Deploying to public hosting server"	
	
	nuget push ./*.nupkg -s https://www.nuget.org/api/v2/package -ApiKey $PublicNugetAPIKey -NonInteractive
	
fi