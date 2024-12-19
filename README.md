DotNetCoreWebAPI [![CodeQL](https://github.com/vulna-felickz/DotNetCoreWebAPI/workflows/CodeQL/badge.svg)](https://github.com/vulna-felickz/DotNetCoreWebAPI/actions?query=workflow:"CodeQL")

- This repo is intentionally not able to download dependenceis from package registry to test failure scenarios with Code Scanning




## Setup Private Registry 

![image](https://github.com/user-attachments/assets/d2b0cef4-21a5-4f69-b8f0-79003b6593da)


### Before

` Error: Command 'dotnet restore --no-dependencies "/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.sln" --packages "/home/runner/work/_temp/codeql_databases/csharp/working/packages" /p:DisableImplicitNuGetFallbackFolder=true --verbosity normal /p:TargetFrameworkRootPath="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot" /p:NetCoreTargetingPackRoot="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot"' failed with exit code 1`

+

`Restored 0 packages`


```
[2024-12-19 17:49:18] [build-stdout] [001] Checking NuGet feed responsiveness: True
  [2024-12-19 17:49:18] [build-stdout] [001] Checking Nuget feeds...
  [2024-12-19 17:49:18] [build-stdout] [001] Found 1 nuget.config files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI: /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/nuget.config.
  [2024-12-19 17:49:18] [build-stdout] [001] Getting Nuget feeds from '/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/nuget.config'...
  [2024-12-19 17:49:18] [build-stdout] [001] Running 'dotnet nuget list source --format Short --configfile "/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/nuget.config"'
  [2024-12-19 17:49:18] [build-stdout] [001] Found 1 Nuget feeds in nuget.config files: https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:49:18] [build-stdout] [001] Getting Nuget feeds in folder '/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI'...
  [2024-12-19 17:49:18] [build-stdout] [001] Running 'dotnet nuget list source --format Short' in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI
  [2024-12-19 17:49:19] [build-stdout] [001] Found 1 Nuget feeds (with inherited ones) in nuget.config files: https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:49:19] [build-stdout] [001] Checking if Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' is reachable...
  [2024-12-19 17:49:19] [build-stdout] [001] Querying Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' failed in a timely manner. Considering the feed for use. The reason for the failure: Response status code does not indicate success: 401 (Unauthorized).
  [2024-12-19 17:49:19] [build-stdout] [001] Found 0 packages.config files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:49:19] [build-stdout] [001] Found 1 solution files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:49:19] [build-stdout] [001] Restoring solution /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.sln...
  [2024-12-19 17:49:19] [build-stdout] [001] Running 'dotnet restore --no-dependencies "/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.sln" --packages "/home/runner/work/_temp/codeql_databases/csharp/working/packages" /p:DisableImplicitNuGetFallbackFolder=true --verbosity normal /p:TargetFrameworkRootPath="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot" /p:NetCoreTargetingPackRoot="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot"'
  [2024-12-19 17:49:27] [build-stderr] [001] Error: Command 'dotnet restore --no-dependencies "/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.sln" --packages "/home/runner/work/_temp/codeql_databases/csharp/working/packages" /p:DisableImplicitNuGetFallbackFolder=true --verbosity normal /p:TargetFrameworkRootPath="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot" /p:NetCoreTargetingPackRoot="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot"' failed with exit code 1
  [2024-12-19 17:49:27] [build-stdout] [001] Found 1 project files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:49:27] [build-stdout] [008] Restoring project /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.csproj...
  [2024-12-19 17:49:27] [build-stdout] [008] Running 'dotnet restore --no-dependencies "/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.csproj" --packages "/home/runner/work/_temp/codeql_databases/csharp/working/packages" /p:DisableImplicitNuGetFallbackFolder=true --verbosity normal /p:TargetFrameworkRootPath="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot" /p:NetCoreTargetingPackRoot="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot"'
  [2024-12-19 17:49:35] [build-stderr] [008] Error: Command 'dotnet restore --no-dependencies "/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.csproj" --packages "/home/runner/work/_temp/codeql_databases/csharp/working/packages" /p:DisableImplicitNuGetFallbackFolder=true --verbosity normal /p:TargetFrameworkRootPath="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot" /p:NetCoreTargetingPackRoot="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot"' failed with exit code 1
  [2024-12-19 17:49:35] [build-stdout] [001] Restored 0 packages
  [2024-12-19 17:49:35] [build-stdout] [001] Found 0 packages in project.assets.json files
  [2024-12-19 17:49:35] [build-stdout] [001] No fallback Nuget feeds specified. Adding default feed: https://api.nuget.org/v3/index.json
  [2024-12-19 17:49:35] [build-stdout] [001] Adding feeds from nuget.config to fallback restore: True
  [2024-12-19 17:49:35] [build-stdout] [001] Using Nuget feeds from nuget.config files as fallback feeds: https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:49:35] [build-stdout] [001] Checking fallback Nuget feed reachability on feeds: https://api.nuget.org/v3/index.json, https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:49:35] [build-stdout] [001] Checking if Nuget feed 'https://api.nuget.org/v3/index.json' is reachable...
  [2024-12-19 17:49:35] [build-stdout] [001] Querying Nuget feed 'https://api.nuget.org/v3/index.json' succeeded.
  [2024-12-19 17:49:35] [build-stdout] [001] Checking if Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' is reachable...
  [2024-12-19 17:49:35] [build-stdout] [001] Querying Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' failed in a timely manner. Not considering the feed for use. The reason for the failure: Response status code does not indicate success: 401 (Unauthorized).
  [2024-12-19 17:49:35] [build-stdout] [001] Reachable fallback Nuget feeds: https://api.nuget.org/v3/index.json
  [2024-12-19 17:49:35] [build-stdout] [001] Found 2 packages that are not yet restored
  [2024-12-19 17:49:35] [build-stdout] [001] Creating fallback nuget.config file /home/runner/work/_temp/codeql_databases/csharp/working/nugetconfig/nuget.config.
  [2024-12-19 17:49:35] [build-stdout] [009] Restoring package swashbuckle.aspnetcore...
  [2024-12-19 17:49:35] [build-stdout] [004] Restoring package swashbuckle.aspnetcore.annotations...
  [2024-12-19 17:49:35] [build-stdout] [004] Running 'dotnet new console --no-restore --output "/home/runner/work/_temp/codeql_databases/csharp/working/BEF24BC91621B09A5DAE65A39C5C5EDF/missingpackages_workingdir"'
  [2024-12-19 17:49:35] [build-stdout] [009] Running 'dotnet new console --no-restore --output "/home/runner/work/_temp/codeql_databases/csharp/working/DB651595203149290BF1EFF75ED74403/missingpackages_workingdir"'
  [2024-12-19 17:49:36] [build-stdout] [009] Running 'dotnet add "/home/runner/work/_temp/codeql_databases/csharp/working/DB651595203149290BF1EFF75ED74403/missingpackages_workingdir" package "swashbuckle.aspnetcore" --no-restore'
  [2024-12-19 17:49:37] [build-stdout] [004] Running 'dotnet add "/home/runner/work/_temp/codeql_databases/csharp/working/BEF24BC91621B09A5DAE65A39C5C5EDF/missingpackages_workingdir" package "swashbuckle.aspnetcore.annotations" --no-restore'
  [2024-12-19 17:49:37] [build-stdout] [009] Running 'dotnet restore --no-dependencies "/home/runner/work/_temp/codeql_databases/csharp/working/DB651595203149290BF1EFF75ED74403/missingpackages_workingdir" --packages "/home/runner/work/_temp/codeql_databases/csharp/working/missingpackages" /p:DisableImplicitNuGetFallbackFolder=true --verbosity normal --configfile "/home/runner/work/_temp/codeql_databases/csharp/working/nugetconfig/nuget.config" --force'
  [2024-12-19 17:49:38] [build-stdout] [004] Running 'dotnet restore --no-dependencies "/home/runner/work/_temp/codeql_databases/csharp/working/BEF24BC91621B09A5DAE65A39C5C5EDF/missingpackages_workingdir" --packages "/home/runner/work/_temp/codeql_databases/csharp/working/missingpackages" /p:DisableImplicitNuGetFallbackFolder=true --verbosity normal --configfile "/home/runner/work/_temp/codeql_databases/csharp/working/nugetconfig/nuget.config" --force'
  [2024-12-19 17:49:40] [build-stdout] [001] Adding .NET Framework DLLs
  [2024-12-19 17:49:40] [build-stdout] [001] Running 'dotnet --list-runtimes'
  [2024-12-19 17:49:40] [build-stdout] [001] .NET runtime location selected: /usr/share/dotnet/packs/Microsoft.NETCore.App.Ref/8.0.11/ref
  [2024-12-19 17:49:40] [build-stdout] [001] ASP.NET runtime location selected: /usr/share/dotnet/packs/Microsoft.AspNetCore.App.Ref/8.0.11/ref
  [2024-12-19 17:49:40] [build-stdout] [001] Indexing 524 assemblies...
  [2024-12-19 17:49:41] [build-stdout] [001] Read 524 assembly infos
  [2024-12-19 17:49:41] [build-stdout] [001] Analyzing /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.sln...
  [2024-12-19 17:49:42] [build-stdout] [001] Reference list contains 524 assemblies
  [2024-12-19 17:49:42] [build-stdout] [001] After conflict resolution, reference list contains 309 assemblies
  [2024-12-19 17:49:42] [build-stdout] [001] Found 0 resource files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:49:42] [build-stdout] [001] Generating source file for implicit usings. Namespaces: Microsoft.AspNetCore.Builder, Microsoft.AspNetCore.Hosting, Microsoft.AspNetCore.Http, Microsoft.AspNetCore.Routing, Microsoft.Extensions.Configuration, Microsoft.Extensions.DependencyInjection, Microsoft.Extensions.Hosting, Microsoft.Extensions.Logging, System, System.Collections.Generic, System.IO, System.Linq, System.Net.Http, System.Net.Http.Json, System.Threading, System.Threading.Tasks
  [2024-12-19 17:49:42] [build-stdout] [001] Found 0 razor view files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:49:42] [build-stdout] [001] 
  [2024-12-19 17:49:42] [build-stdout] [001] Build analysis summary:
  [2024-12-19 17:49:42] [build-stdout] [001]      4 source files found on the filesystem
  [2024-12-19 17:49:42] [build-stdout] [001]      1 source files have been generated
  [2024-12-19 17:49:42] [build-stdout] [001]      1 solution files found on the filesystem
  [2024-12-19 17:49:42] [build-stdout] [001]      1 project files found on the filesystem
  [2024-12-19 17:49:42] [build-stdout] [001]    309 resolved references
  [2024-12-19 17:49:42] [build-stdout] [001]      0 unresolved references
  [2024-12-19 17:49:42] [build-stdout] [001]    215 resolved assembly conflicts
  [2024-12-19 17:49:42] [build-stdout] [001]      0 restored .NET framework variants
  [2024-12-19 17:49:42] [build-stdout] [001] Build analysis completed in 00:00:26.1008403
  [2024-12-19 17:49:42] [build-stdout] [001] 
  [2024-12-19 17:49:42] [build-stdout] [001] Extracting...
  [2024-12-19 17:49:49] [build-stdout] [001] Extraction completed in 00:00:33.3090827
```

### After

`Restored 10 packages`

```
  [2024-12-19 17:52:42] [build-stdout] [001] Checking NuGet feed responsiveness: True
  [2024-12-19 17:52:42] [build-stdout] [001] Checking Nuget feeds...
  [2024-12-19 17:52:42] [build-stdout] [001] Found 1 nuget.config files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI: /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/nuget.config.
  [2024-12-19 17:52:42] [build-stdout] [001] Getting Nuget feeds from '/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/nuget.config'...
  [2024-12-19 17:52:42] [build-stdout] [001] Running 'dotnet nuget list source --format Short --configfile "/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/nuget.config"'
  [2024-12-19 17:52:42] [build-stdout] [001] Setting up Dependabot proxy at http://127.0.0.1:49152
  [2024-12-19 17:52:43] [build-stdout] [001] Found 1 Nuget feeds in nuget.config files: https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:52:43] [build-stdout] [001] Getting Nuget feeds in folder '/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI'...
  [2024-12-19 17:52:43] [build-stdout] [001] Running 'dotnet nuget list source --format Short' in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI
  [2024-12-19 17:52:43] [build-stdout] [001] Setting up Dependabot proxy at http://127.0.0.1:49152
  [2024-12-19 17:52:43] [build-stdout] [001] Found 1 Nuget feeds (with inherited ones) in nuget.config files: https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:52:43] [build-stdout] [001] Checking if Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' is reachable...
  [2024-12-19 17:52:45] [build-stdout] [001] Didn't receive answer from Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' in 1000ms.
  [2024-12-19 17:52:46] [build-stdout] [001] Querying Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' succeeded.
  [2024-12-19 17:52:46] [build-stdout] [001] Found 0 packages.config files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:52:46] [build-stdout] [001] Found 1 solution files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:52:46] [build-stdout] [001] Restoring solution /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.sln...
  [2024-12-19 17:52:46] [build-stdout] [001] Running 'dotnet restore --no-dependencies "/home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.sln" --packages "/home/runner/work/_temp/codeql_databases/csharp/working/packages" /p:DisableImplicitNuGetFallbackFolder=true --verbosity normal /p:TargetFrameworkRootPath="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot" /p:NetCoreTargetingPackRoot="/home/runner/work/_temp/codeql_databases/csharp/working/emptyFakeDotnetRoot"'
  [2024-12-19 17:52:46] [build-stdout] [001] Setting up Dependabot proxy at http://127.0.0.1:49152
  [2024-12-19 17:52:55] [build-stdout] [001] Found 1 project files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:52:55] [build-stdout] [001] Restored 10 packages
  [2024-12-19 17:52:55] [build-stdout] [001] Found 7 packages in project.assets.json files
  [2024-12-19 17:52:55] [build-stdout] [001] No fallback Nuget feeds specified. Adding default feed: https://api.nuget.org/v3/index.json
  [2024-12-19 17:52:55] [build-stdout] [001] Adding feeds from nuget.config to fallback restore: True
  [2024-12-19 17:52:55] [build-stdout] [001] Using Nuget feeds from nuget.config files as fallback feeds: https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:52:55] [build-stdout] [001] Checking fallback Nuget feed reachability on feeds: https://api.nuget.org/v3/index.json, https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:52:55] [build-stdout] [001] Checking if Nuget feed 'https://api.nuget.org/v3/index.json' is reachable...
  [2024-12-19 17:52:55] [build-stdout] [001] Querying Nuget feed 'https://api.nuget.org/v3/index.json' succeeded.
  [2024-12-19 17:52:55] [build-stdout] [001] Checking if Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' is reachable...
  [2024-12-19 17:52:55] [build-stdout] [001] Querying Nuget feed 'https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json' succeeded.
  [2024-12-19 17:52:55] [build-stdout] [001] Reachable fallback Nuget feeds: https://api.nuget.org/v3/index.json, https://pkgs.dev.azure.com/felickz2/_packaging/felickz2/nuget/v3/index.json
  [2024-12-19 17:52:55] [build-stdout] [001] Adding .NET Framework DLLs
  [2024-12-19 17:52:55] [build-stdout] [001] Indexing 641 assemblies...
  [2024-12-19 17:52:56] [build-stdout] [001] Read 323 assembly infos
  [2024-12-19 17:52:56] [build-stdout] [001] Analyzing /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI/DotNetCoreWebAPI.sln...
  [2024-12-19 17:52:57] [build-stdout] [001] Reference list contains 293 assemblies
  [2024-12-19 17:52:57] [build-stdout] [001] After conflict resolution, reference list contains 293 assemblies
  [2024-12-19 17:52:57] [build-stdout] [001] Found 0 resource files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:52:57] [build-stdout] [001] Generating source file for implicit usings. Namespaces: Microsoft.AspNetCore.Builder, Microsoft.AspNetCore.Hosting, Microsoft.AspNetCore.Http, Microsoft.AspNetCore.Routing, Microsoft.Extensions.Configuration, Microsoft.Extensions.DependencyInjection, Microsoft.Extensions.Hosting, Microsoft.Extensions.Logging, System, System.Collections.Generic, System.IO, System.Linq, System.Net.Http, System.Net.Http.Json, System.Threading, System.Threading.Tasks
  [2024-12-19 17:52:58] [build-stdout] [001] Found 0 razor view files in /home/runner/work/DotNetCoreWebAPI/DotNetCoreWebAPI.
  [2024-12-19 17:52:58] [build-stdout] [001] 
  [2024-12-19 17:52:58] [build-stdout] [001] Build analysis summary:
  [2024-12-19 17:52:58] [build-stdout] [001]      4 source files found on the filesystem
  [2024-12-19 17:52:58] [build-stdout] [001]      1 source files have been generated
  [2024-12-19 17:52:58] [build-stdout] [001]      1 solution files found on the filesystem
  [2024-12-19 17:52:58] [build-stdout] [001]      1 project files found on the filesystem
  [2024-12-19 17:52:58] [build-stdout] [001]    293 resolved references
  [2024-12-19 17:52:58] [build-stdout] [001]      0 unresolved references
  [2024-12-19 17:52:58] [build-stdout] [001]      0 resolved assembly conflicts
  [2024-12-19 17:52:58] [build-stdout] [001]      1 restored .NET framework variants
  [2024-12-19 17:52:58] [build-stdout] [001] Build analysis completed in 00:00:17.4175991
  [2024-12-19 17:52:58] [build-stdout] [001] 
  [2024-12-19 17:52:58] [build-stdout] [001] Extracting...
  [2024-12-19 17:53:06] [build-stdout] [001] Extraction completed in 00:00:25.7815668
```
