# SeaCertsBlazor

[![Board Status](https://dev.azure.com/tc-tibo/4dd797bf-468b-4734-809d-7a5d7e801e2d/98f281cb-b20c-4b34-9384-beeaf67bef78/_apis/work/boardbadge/04d8c3b1-ac45-422d-9c05-c39db02d017d?columnOptions=2&columns=To%20Do,Doing,Done)](https://dev.azure.com/tc-tibo/4dd797bf-468b-4734-809d-7a5d7e801e2d/_boards/board/t/98f281cb-b20c-4b34-9384-beeaf67bef78/Microsoft.RequirementCategory/)

# Introduction 

This is the prototype for the digital CDN Application Form as part of TC's Seafarer Credentials Project. It is written in Blazor and is strictly for development purposes. Actual development will be hosted in TC's official Github home.

# Getting Started

1.	Installation process

To install this project, clone locally, open https://github.com/tc-tibo/SeaCertsBlazor/blob/master/CDTS%20Blazor.sln file in Visual Studio, and then publish to your desired location.

2.	Software dependencies

The following are managed via NuGet package manager in Visual Studio:
  -https://www.nuget.org/packages/GoC.WebTemplate-Components.Core
  -https://www.nuget.org/packages/Microsoft.Azure.Storage.Blob
  -https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design
  
The Target framework is .NET Core 3.1, which is available for download from [Microsoft](https://dotnet.microsoft.com/download/dotnet-core/3.1).

3.	Latest releases

Releases are continuosly deployed to:

https://seacertsblazor.azurewebsites.net/

Upon commits to master.

4.	API references

None.

# Build and Test

The solution can be built from Visual Studio's "Build" menu or from Ctrl+Shift+B from keyboard. There are currently no unit tests.

# Contribute

Some ideas:
  - implement localization using CDTS
  - add test scripts
  - containerize using Docker
  - set up AKS
