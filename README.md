# FindingJsonDotNet

I'm reacquainting  myself with C# and learning the new ASP.NET Core.  Finding a good library for JSON serialization/deserialization was harder than I expected, so I thought I'd document how I did it.

To prepare, 
see https://dotnet.github.io/.
for instructions on downloading and installing free Visual Studio and Open Source ASP.NET Core,

To build this package:

1. If on Windows, download and install VisualStudio 2015 rev 3.
2. Install ASP.Net Core
3. ```git clone git@github.com:rstinejr/FindingJsonDotNet.git```
4. ```cd FindingJsonDotNet```
5. ```dotnet restore```
6. ```cd src```
7. ```dotnet build```.  Or, to build and run, ```dotnet run```

If you want to use Json.Net in your own VisualStudio project, use NuGet to import
package Newtonsoft.Json:
1. Right click on *References* in the Solutions pane
2. Select "Manage NuGet Packages..."
3. In the NuGet window, select *Browse*
4. Install the "Newtonsoft.Json package.

Otherwise, download the package from
http://www.newtonsoft.com/json/help/html/Introduction.htm. There is also
API documentation at the site.

I'm no lawyer, but the only licensing restrictions of note appear to be:

1. The license must accompany the code.
2. The author is not liable for any damage caused by use of the software.
