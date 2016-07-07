#Updates AssemblyInfo.cs version.
#Major and Minor have to be updated manually.

#Contracts

echo "Adjusting Contracts AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Contracts/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Contracts/Properties/AssemblyInfo.cs

echo "Adjusted Contracts AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Contracts/Properties/AssemblyInfo.cs  | head -1

#Emails

echo "Adjusting Emails AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Emails/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Emails/Properties/AssemblyInfo.cs

echo "Adjusted Emails AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Emails/Properties/AssemblyInfo.cs  | head -1 

#Enums

echo "Adjusting Enums AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Enums/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Enums/Properties/AssemblyInfo.cs

echo "Adjusted Enums AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Enums/Properties/AssemblyInfo.cs  | head -1 

#Extensions

echo "Adjusting Extensions AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Extensions/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Extensions/Properties/AssemblyInfo.cs

echo "Adjusted Extensions AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Extensions/Properties/AssemblyInfo.cs  | head -1 

#IO

echo "Adjusting IO AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.IO/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.IO/Properties/AssemblyInfo.cs

echo "Adjusted IO AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.IO/Properties/AssemblyInfo.cs  | head -1 

#Logging

echo "Adjusting Logging AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Logging/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Logging/Properties/AssemblyInfo.cs

echo "Adjusted Logging AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Logging/Properties/AssemblyInfo.cs  | head -1 


#Logging.AppInsights

echo "Adjusting Logging.AppInsights AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Logging.AppInsights/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Logging.AppInsights/Properties/AssemblyInfo.cs

echo "Adjusted Logging.AppInsights AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Logging.AppInsights/Properties/AssemblyInfo.cs  | head -1 

#SQL

echo "Adjusting SQL AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.SQL/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.SQL/Properties/AssemblyInfo.cs

echo "Adjusted SQL AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.SQL/Properties/AssemblyInfo.cs  | head -1 

#Templating

echo "Adjusting Templating AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Templating/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Templating/Properties/AssemblyInfo.cs

echo "Adjusted Templating AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Templating/Properties/AssemblyInfo.cs  | head -1 


#Templating.Handlebars

echo "Adjusting Templating.Handlebars AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Templating.Handlebars/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Templating.Handlebars/Properties/AssemblyInfo.cs

echo "Adjusted Templating.Handlebars AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Templating.Handlebars/Properties/AssemblyInfo.cs  | head -1 


#Templating.Razor

echo "Adjusting Templating.Razor AssemblyVersion from:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Templating.Razor/Properties/AssemblyInfo.cs  | head -1

# Updates AssemblyVersion for Nuget creation.
sed -ri "s/AssemblyVersion\(\"([0-9]+.[0-9]+.)[0-9]+.[0-9]+\"\)/AssemblyVersion(\"\1${TRAVIS_BUILD_NUMBER}.0\")/g" ./BBS.Libraries.Templating.Razor/Properties/AssemblyInfo.cs

echo "Adjusted Templating.Razor AssemblyVersion to:"
tail -2 $TRAVIS_BUILD_DIR/BBS.Libraries.Templating.Razor/Properties/AssemblyInfo.cs  | head -1 