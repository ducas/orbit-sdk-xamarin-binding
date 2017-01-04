MDTOOL ?= /Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool

.PHONY: all clean OrbitSdk.iOS

package: all 
	nuget pack ./OrbitSdk.nuspec -version $(VERSION)
	mv *.nupkg ./build/

clean:
	$(MDTOOL) build -t:Clean OrbitSdk.sln
	rm -rf ./build

all: clean OrbitSdk.iOS 

OrbitSdk.iOS:
	$(MDTOOL) build -c:Release ./OrbitSdk.iOS/OrbitSdk.iOS.csproj
	mkdir -p ./build/Xamarin.iOS10
	mv ./OrbitSdk.iOS/bin/Release/OrbitSdk.iOS.dll ./build/Xamarin.iOS10
