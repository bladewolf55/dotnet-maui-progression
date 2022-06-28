# .NET MAUI Progressing From a Default Project

## Introduction
A set of .NET MAUI solutions progressing from the default project, showing how to implement MVVM, automated testing, styles, CI/CD, and other stuff.

## Environment
> Changing the environment? Change the CI/CD pipeline!

Install                          | Version    
---------------------------------|------------
.NET                             | 6
PowerShell                       | 7.x
Visual Studio                    | VS 2022 17.3 Preview (at time of writing)

Sources:
*   [.NET](https://dotnet.microsoft.com/download/dotnet)
*   [PowerShell](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell-core-on-windows)
*   [Visual Studio](https://visualstudio.microsoft.com/downloads/)

## Getting Started
> Be sure to use the correct versions from above.

**Environment**  
1.  Install PowerShell 7.x.
1.  Install .NET 6.x.

```powershell
$ErrorActionPreference = 'Stop'
# other installations
```

**Application** 
```powershell
# Clone source
$ErrorActionPreference = 'Stop'
$userRoot = $env:userprofile
cd "$userRoot/source/repos"
git clone https://github.com/bladewolf55/dotnet-maui-progression.git
cd dotnet-maui-progression
# Build app
# ./build.ps1 <== TBD
```

## What's in the Repo
*   The `docs` folder contains the blog posts.
*   The src folder contains a folder-per-blog-part.

Each part's solution is the state at the *end* of the blog post.

