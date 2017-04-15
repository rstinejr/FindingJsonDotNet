# FindingJsonDotNet

I'm reacquainting  myself with C# and learning the new ASP.NET Core.  Finding a good library for JSON serialization/deserialization was harder than I expected, so I thought I'd document how I did it.

## Setup

To prepare, 
see https://dotnet.github.io/.
for instructions on downloading and installing free Visual Studio and Open Source ASP.NET Core,

This project was built and run on a 64-bit Windows 10 Pro, with dotnet version 1.0.0 and VisualStudo 2015 release 3.

## Building Project

To build this package:

1. If on Windows, download and install VisualStudio 2015 rev 3.
2. Install ASP.Net Core
3. `git clone git@github.com:rstinejr/FindingJsonDotNet.git`
4. `cd FindingJsonDotNet`
5. `dotnet restore`
6. `cd src`
7. `dotnet build`.  Or, to build and run, `dotnet run`

## Creating JSON, Deserializing JSON

This program illustrates creating a JSON string and then deserializing the string into 
a class instance.  Output from running is:

```
src> dotnet run
Project src (.NETCoreApp,Version=v1.0) was previously compiled. Skipping compilation.
Roll Tide! {"School":"University of Alabama","Sport":"Football","Ranking":1}
Deserialized: School 'University of Alabama', Sport 'Football', City: ''
```

Note that the JSON string has a field that the class lacks (viz., *Ranking*), and the
Class has a field that the JSON lacks (viz., *City*). Deserialization ignores the
unmapped fields from JSON and uses the default values for fields that the JSON lacks.

## Configuring Your Projects

If you want to use Json.Net in your own VisualStudio project, use NuGet to import
package Newtonsoft.Json:

1. Right click on *References* in the Solutions pane
2. Select "Manage NuGet Packages..."
3. In the NuGet window, select *Browse*
4. Install the "Newtonsoft.Json package.

Otherwise, download the package from
http://www.newtonsoft.com/json/help/html/Introduction.htm. There is also
API documentation at the site.

## Licenses

The license for my work is in file `LICENSE`. In a nutshell, do what you want with this other than claim you wrote it or blame 
me for any problems.

The licensing for Json.Net is only slightly more restrictive.  I'm no lawyer, but the only constraints appear to be:

1. The license must accompany the code.
2. The author is not liable for any damage caused by use of the software.
