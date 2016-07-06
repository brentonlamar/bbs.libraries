# Gets Version from AsseblyInfo.cs updates nuspec's version
if [ "$TRAVIS_BRANCH" == "adding-nuget" ]; then
	declare regex="AssemblyVersion\(\"([0-9]+.[0-9]+.[0-9]+.[0-9]+)\"\)"
	#declare file_content=$( cat $AssemblyFilePath)
	
	declare file_content= cat ./BBS.Libraries.Contracts/BBS.Libraries.Contracts.nuspec

	echo "Updating nuspec version"

	echo "Contracts nuspec before sed:"
	cat file_content
		sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Contracts/BBS.Libraries.Contracts.nuspec
	echo "Contracts nuspec after sed:"

	cat file_content #just to see what happens!
	
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Emails/BBS.Libraries.Emails.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Enums/BBS.Libraries.Enums.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Extensions/BBS.Libraries.Extensions.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.IO/BBS.Libraries.IO.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Logging/BBS.Libraries.Logging.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Logging.AppInsights/BBS.Libraries.Logging.AppInsights.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.SQL/BBS.Libraries.SQL.nuspec   
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Templating/BBS.Libraries.Templating.nuspec 
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Templating.Handlebars/BBS.Libraries.Templating.Handlebars.nuspec  
	sed -i "s|\(<version>\)[^<>]*\(</version>\)|\1${BASH_REMATCH[1]}\2|g" ./BBS.Libraries.Templating.Razor/BBS.Libraries.Templating.Razor.nuspec  

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


	# if [[ ${IsUploadingNugetToPrivateServer,,} == "true" ]]; then
	# 		echo "Deploying to private hosting server"
	# 		nuget push ./*.nupkg -s $PrivateNugetServerURL $PrivateNugetAPIKey
	# fi

	# if [[ ${IsUploadingNugetToPublicServer,,} == "true" ]]; then
			echo "Deploying to public hosting server"
			nuget push ./*.nupkg $PublicNugetAPIKey
	# fi
fi