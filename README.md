# What's new in .NET world?

A sample code for a talk "What's new in .NET world". This sample is written for .NET 7 and .NET 8, using C# 11 and C# 12.

The sample code and a separate presentation for ASP.NET Core Minimal APIs is available in [a separate GitHub repository](https://github.com/miroslavpopovic/minimal-apis-sample).

The older sample covering .NET 6 and .NET 7 is available in [another repository](https://github.com/miroslavpopovic/dotnet-6-and-7).

<!-- TOC -->
* [What's new in .NET world?](#whats-new-in-net-world)
  * [Presentations](#presentations)
  * [Languages](#languages)
    * [C#](#c)
      * [Version 11 (.NET 7)](#version-11-net-7)
      * [Version 12 (.NET 8)](#version-12-net-8)
    * [F#](#f)
      * [Version 7 (.NET 7)](#version-7-net-7)
      * [Version 8 (.NET 8)](#version-8-net-8)
    * [Visual Basic](#visual-basic)
  * [.NET BCL, SDK and tools](#net-bcl-sdk-and-tools)
    * [BCL library APIs](#bcl-library-apis)
      * [.NET 7](#net-7)
      * [.NET 8](#net-8)
    * [`System.Text.Json`](#systemtextjson)
      * [.NET 7](#net-7-1)
      * [.NET 8](#net-8-1)
    * [.NET SDK](#net-sdk)
      * [.NET 7](#net-7-2)
      * [.NET 8](#net-8-2)
    * [Tools](#tools)
      * [.NET 7](#net-7-3)
      * [.NET 8](#net-8-3)
  * [Performance improvements](#performance-improvements)
    * [.NET 7](#net-7-4)
    * [.NET 8](#net-8-4)
  * [Entity Framework Core](#entity-framework-core)
    * [.NET 7](#net-7-5)
    * [.NET 8](#net-8-5)
  * [ASP.NET Core](#aspnet-core)
    * [.NET 7](#net-7-6)
      * [Minimal APIs](#minimal-apis)
      * [SignalR](#signalr)
    * [.NET 8](#net-8-6)
      * [Minimal APIs](#minimal-apis-1)
      * [SignalR](#signalr-1)
  * [Blazor](#blazor)
    * [.NET 7](#net-7-7)
      * [Blazor Hybrid](#blazor-hybrid)
    * [.NET 8](#net-8-7)
  * [MAUI](#maui)
    * [.NET 7](#net-7-8)
    * [.NET 8](#net-8-8)
  * [gRPC](#grpc)
    * [.NET 7](#net-7-9)
    * [.NET 8](#net-8-9)
  * [Desktop](#desktop)
    * [Windows Forms](#windows-forms)
      * [.NET 7](#net-7-10)
      * [.NET 8](#net-8-10)
    * [WPF](#wpf)
      * [.NET 7](#net-7-11)
      * [.NET 8](#net-8-11)
  * [Monitoring and metrics](#monitoring-and-metrics)
    * [.NET 7](#net-7-12)
    * [.NET 8](#net-8-12)
  * [CoreWCF](#corewcf)
  * [YARP](#yarp)
  * [ML.NET](#mlnet)
    * [SynapseML for .NET](#synapseml-for-net)
  * [Microsoft Orleans](#microsoft-orleans)
  * [Dapr](#dapr)
  * [Community Toolkits](#community-toolkits)
  * [Cloud and dogfooding](#cloud-and-dogfooding)
  * [Visual Studio](#visual-studio)
  * [Visual Studio Code](#visual-studio-code)
  * [JetBrains tools](#jetbrains-tools)
  * [Dev tools](#dev-tools)
  * [GitHub Copilot](#github-copilot)
  * [AI](#ai)
  * [License](#license)
<!-- TOC -->

## Presentations

- TODO: [May 2023, Thrive Conference 2023](./2023-05-thrive-what-is-new-in-dotnet-world.pptx)

## Languages

### C#

A new proposals for C# features are available in [the C# language GitHub repository](https://github.com/dotnet/csharplang/tree/main/proposals).

#### Version 11 (.NET 7)

- Announcements, blog posts and videos
  - [Kathleen Dollard: Early peek at C# 11 features](https://devblogs.microsoft.com/dotnet/early-peek-at-csharp-11-features/)
  - [Bill Wagner: C# 11 preview: generic math, required members, and more](https://devblogs.microsoft.com/dotnet/csharp-11-preview-august-update/)
  - [Mads Torgersen: Welcome to C# 11](https://devblogs.microsoft.com/dotnet/welcome-to-csharp-11/)
  - [Oleg Kyrylchuk: Twelve C# 11 features](https://blog.okyrylchuk.dev/twelve-csharp-11-features)
  - [Nick Chapsas: Every single feature added in C# 11](https://www.youtube.com/watch?v=cqCBhkNroDI)
  - [What's new in C# 11](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)
- Raw string literals
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/raw-string-literal)
  - [Sample](./src/CSharp/Version11/RawStringLiteralsSample.cs)
- New lines inside the "holes" of interpolated strings
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/new-line-in-interpolation)
  - [Sample](./src/CSharp/Version11/RawStringLiteralsSample.cs)
- List patterns to match against lists and arrays
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/list-patterns)
  - [Sample](./src/CSharp/Version11/ListAndStringPatternsSample.cs)
- Pattern matching strings with spans
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/pattern-match-span-of-char-on-string)
  - [Sample](./src/CSharp/Version11/ListAndStringPatternsSample.cs)
- Auto-default structs
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/auto-default-structs)
  - [Sample](./src/CSharp/Version11/AutoDefaultStructsSample.cs)
- Required members
  - `public require string Name { get; init; }`
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/required-members)
  - [Sample](./src/CSharp/Version11/RequiredMembersSample.cs)
- Generic attributes
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/generic-attributes)
  - [Sample](./src/CSharp/Version11/GenericAttributesSample.cs)
  - [Manoj Choudhari: C# 11 - introducing support for generic attributes](https://thecodeblogger.com/2022/09/18/c-11-introducing-support-for-generic-attributes/)
- File-scoped types
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/file-local-types)
  - [Sample](./src/CSharp/Version11/AutoDefaultStructsSample.cs)
- UTF-8 string literals
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/utf8-string-literals)
- [Other new features...](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-11.0/)

#### Version 12 (.NET 8)

- Announcements and blog posts
  - [What's new in C# 12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)
  - [Kathleen Dollard: Check out new C# 12 preview features!](https://devblogs.microsoft.com/dotnet/check-out-csharp-12-preview/)
  - [Michael Shpilt: Looking at C# 12 proposals and beyond](https://michaelscodingspot.com/csharp-12-proposals/)
  - [Patrick Smacchia: C# 12 new features](https://blog.ndepend.com/c12-new-features/)
  - [Proposals](https://github.com/dotnet/csharplang/tree/main/proposals)
- Primary constructors for non-record classes and structs
  - [Sample](./src/CSharp/Version12/PrimaryConstructorsSample.cs)
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/primary-constructors)
- Using aliases for any type
  - [Sample](./src/CSharp/Version12/AliasAnyTypeSample.cs)
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/using-alias-types)
  - [Nick Chapsas: The most confusing C# 12 feature yet](https://youtu.be/4GeEvcKq8Lo)
- Default values for lambda expression parameters
  - [Sample](./src/CSharp/Version12/LambdaParametersSample.cs)
  - [Specification](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/lambda-method-group-defaults)

### F#

#### Version 7 (.NET 7)

- [Announcement](https://devblogs.microsoft.com/dotnet/announcing-fsharp-7/)
- Static abstract members in interfaces
- Easier Statically Resolved Type Parameters
- Required properties checking, init scope and init-only parameters
- Reference assemblies support
- F# self-contained deployment
- Native AOT

#### Version 8 (.NET 8)

- F# inline types and parameter name hints in Visual Studio
  - [Announcement](https://devblogs.microsoft.com/dotnet/fsharp-inline-hints-visual-studio/)

### Visual Basic

- **No new features in the language itself!**
  - Other than the ones that are shared with all .NET languages
- Some improvements, like refactorings, are available in Visual Studio 2022
- WinForms Visual Basic Application Framework has new features
  - [Announcement](https://devblogs.microsoft.com/dotnet/update-to-winforms-vb-appframework/)

## .NET BCL, SDK and tools

### BCL library APIs

#### .NET 7

- Announcements and blog posts
  - [Jon Douglas, Jeremy Likness and Angelos Petropoulos: .NET 7 is available today](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7/)
  - [What's new in .NET 7](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-7)
- Generic math
  - `System.Numerics`
    - `INumber<T>`, `IBinaryInteger`, `IFloatingPoint`, `IFloatingPointIeee754`, `INumberBase`, `ISignedNumber`
    - Separate interfaces for functions and operators – like `IAdditionOperators`
  - New C# feature - using static abstract methods in interfaces
  - [Announcement](https://devblogs.microsoft.com/dotnet/dotnet-7-generic-math/)
  - [Sample](./src/LibraryApis/DotNet7/GenericMathSample.cs)
- New Regex APIs
  - `RegexGenerator` and Roslyn analyzers [Demo]
  - `RegexOptions.NonBacktracking`
  - [Regex Source Generator announcements](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-2/#introducing-the-new-regex-source-generator)
  - [A lot of other improvements](https://devblogs.microsoft.com/dotnet/regular-expression-improvements-in-dotnet-7/)
  - [Sample](./src/LibraryApis/DotNet7/RegexImprovementsSample.cs)
- Rate limiting
  - Different algorithms: concurrency, token bucket, fixed window,  sliding window, partitioned...
  - `System.Threading.RateLimiting`
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-rate-limiting-for-dotnet/)
  - [Sample in Minimal APIs repo](https://github.com/miroslavpopovic/minimal-apis-sample)
- `Microseconds` and `Nanoseconds` in date and time types
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-4/#adding-microseconds-and-nanoseconds-to-timestamp-datetime-datetimeoffset-and-timeonly)
  - [Sample](./src/LibraryApis/DotNet7/MicrosecondsNanosecondsSample.cs)
- New `Stream` methods – `ReadExactly` and `ReadAtLeast`
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-5/#readexactly-and-readatleast)
- Tar archive support
  - `System.Formats.Tar` assembly
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-4/#added-new-tar-apis)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-6/#system-formats-tar-api-updates)
- Support for Unix file modes
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-7/#support-for-unix-file-modes)
- Networking improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/dotnet-7-networking-improvements/)
  - HTTP improvements
    - Improved handling of connection attempt failures
    - `HttpHeaders` read thread safety
    - Detect HTTP/2 and HTTP/3 protocol errors
    - HTTP/3 fixes
  - QUIC support
  - Security
    - Negotiate API
    - Options for certificate validation
  - Performance
  - WebSockets improvements

#### .NET 8

- Announcements and blog posts
- Native AOT
  - Reduced size of the single file apps
  - Console template has out of the box support for Native AOT with `dotnet new console --aot`
  - Various improvements and optimizations
  - Sample [CSharp project](./src/NativeAotEnabled/NativeAotEnabled.csproj) and [publish command](./publish-native-aot.ps1)
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-1/#native-aot)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-3/#native-code-generation)
  - [Announcement 3](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#native-aot-improvements)
- Utility methods for working with randomness
  - `GetItems` and `Shuffle`
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-1/#utility-methods-for-working-with-randomness)
- New performance focused types in the core libraries
  - `FroznDictionary<TKey, TValue>`and `FrozenSet<T>`
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-1/#new-performance-focused-types-in-the-core-libraries)
- `System.ComponentModel.DataAnnotations` extensions
  - `RequiredAttribute.DisallowAllDefaultValues` - prevents `Guid.Empty`, `0`, `false`, etc. from being valid
  - `LengthAttribute` can now set both upper and lower bounds for strings and collections
  - New `AllowedValuesAttribute` and `DeniedValuesAttribute`
  - New `Base64StringAttribute`
  - [Sample](./src/LibraryApis/DotNet8/DataAnnotationsImprovementsSample.cs)
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-2/#system-componentmodel-dataannotations-extensions)
- UTF8 improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#libraries-utf8-improvements)
- `TimeProvider` abstract class for time abstraction
  - Enables mocking in test scenarios
  - Also supported by other features that rely on time progression, such as `Task.Delay` and `Task.Async`
  - [Sample](./src/LibraryApis/DotNet8/TimeProviderSample.cs)
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#introducing-time-abstraction)
- Hardware intrinsic improvements
  - Performance optimization and hardware acceleration for Vector and matrix operations
  - `System.Numerics` and `System.Runtime.Intrinsics`
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-1/#system-numerics-and-system-runtime-intrinsics)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#system-runtime-intrinsics-vector512-and-avx-512)
- `System.Reflection`: introspection support for function pointers
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-2/#system-reflection-introspection-support-for-function-pointers)
- `ValidateOptionsResultBuilder`
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-3/#validateoptionsresultbuilder)
- New configuration binding source generator
  - Avoids reflection at runtime, and enables Native AOT scenarios
  - `Microsoft.Extensions.Configuration.Binder` NuGet package
  - `<EnableMicrosoftExtensionsConfigurationBinderSourceGenerator>` in the project file
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-3/#introducing-the-configuration-binding-source-generator)
- CodeGen improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#codegen)

### `System.Text.Json`

#### .NET 7

- Polymorphism
  - `JsonDerivedType` attribute
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-5/#polymorphism)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/system-text-json-in-dotnet-7/#type-hierarchies)
  - [Sample](./src/LibraryApis/DotNet7/JsonPolymorphismSample.cs)
- JSON contract customization
  - Adding type modifiers to `DefaultJsonTypeInfoResolver`
  - Creating custom `IJsonTypeInfoResolver`
  - Conditional property serialization
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-6/#json-contract-customization)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/system-text-json-in-dotnet-7/#contract-customization)
  - [Sample](./src/LibraryApis/DotNet7/JsonContractCustomizationSample.cs)
- Source generation improvements
  - support for `IAsyncEnumerable`, `JsonDocument` and `DateOnly`/`TimeOnly` types
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-5/#source-generation-improvements)
- `Utf8JsonReader.CopyString()` method
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-5/#utf8jsonreader-copystring)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/system-text-json-in-dotnet-7/#utf8jsonreader-copystring)
- Performance improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/performance_improvements_in_net_7/#json)
- Required members
  - [Announcement](https://devblogs.microsoft.com/dotnet/system-text-json-in-dotnet-7/#required-members)
- `JsonSerializerOptions.Default`
  - [Announcement](https://devblogs.microsoft.com/dotnet/system-text-json-in-dotnet-7/#jsonserializeroptions-default)

#### .NET 8

- Improvements
  - Missing member handling - `JsonUnmappedMemberHandling` - [Sample](./src/LibraryApis/DotNet8/JsonMissingMembersHandlingSample.cs)
  - Source generator support for `required` and `init` properties
  - Interface hierarchy support
  - `snake_case` and `kebab-case` support for property names - [Sample](./src/LibraryApis/DotNet8/JsonSnakeAndKebabCasePropertiesSample.cs)
  - `JsonSerializer.IsReflectionEnabledByDefault` property to help with Native AOT scenarios
    - Not all serialization options are supported - i.e., dynamic types are not
  - Unspeakable types support - i.e., local functions
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-1/#json-improvements)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#system-text-json-improvements)
- Populating read-only members
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#system-text-json-populating-read-only-members)

### .NET SDK

#### .NET 7

- Native AOT
  - No longer experimental
  - Generates code at build time instead of runtime
  - Improves startup time, memory usage, access to restricted platforms (no JIT), size on disk
  - Console apps and native libraries only
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-3/#faster-lighter-apps-with-native-aot)
  - [Specification](https://learn.microsoft.com/en-gb/dotnet/core/deploying/native-aot)
- New CLI parser
  - `dotnet new` improved CLI
  - `dotnet --info` updates
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-2/#sdk-improvements)
- Central Package Management – `Directory.Packages.props`
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-4/#central-package-management)
- Improved .NET host error messages – i.e., missing runtime errors
  - [Announcement](https://devblogs.microsoft.com/dotnet/dotnet-apphost-improvements/)
- `Console.ReadKey` improved, especially for Linux
  - [Announcement](https://devblogs.microsoft.com/dotnet/console-readkey-improvements-in-net-7/)
- Template authoring improvements
  - Constraints (OS, workload, host), multi-choice parameters, better exit codes and error reporting
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-6/#template-authoring)
- Built-in container support for .NET SDK
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-builtin-container-support-for-the-dotnet-sdk/)

#### .NET 8

- `dotnet publish` and `dotnet pack` produce Release output by default
  - [Sample](./publish-native-aot.ps1)
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-1/#dotnet-publish-and-dotnet-pack-produce-release-assets-by-default)
- `dotnet workload clean` command
  - Garbage collection for workloads, cleaning the orphaned packs
  - `--all` cleans every existing pack on the machine that is not from VS and is of current SDK workload installation type (file-based or MSI-based)
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-3/#dotnet-workload-clean-command)
- New, modern terminal build output from MSBuild
  - Use `/tl` switch - `dotnet build /tl`
  - [Sample](./build-modern.ps1)
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#msbuild-new-modern-terminal-build-output)
- Simplified build output path
  - `/artifacts` folder is used by default
  - `<ArtifactsPath>$(MSBuildThisFileDirectory)artifacts</ArtifactsPath>` in `Directory.Build.props` file (`dotnet new buildprops --use-artifacts`)
  - [Sample](./Directory.Build.props)
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-3/#simplified-output-path)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#sdk-simplified-output-path-updates)
- Better security with packages from Nuget.org
  - Prevents downloading packages from `http://` feeds, but allows overrides with `--force` flag
  - Signed package verification on Linux is on by default
  - Auditing NuGet package dependencies for security vulnerabilities
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-4/#template-engine-secure-experience-with-packages-from-nuget-org)
- .NET Container images improvements
  - Debian 12 (Bookworm) used as a default Linux distro
  - Using Ubuntu Chiseled container images with .NET 8
  - Running container images with non-root users - `USER app` inside Dockerfile, or `-u app` when launching image
    - Also helps with [Kubernetes "Restricted" hardening best practices](https://devblogs.microsoft.com/dotnet/running-nonroot-kubernetes-with-dotnet/)
  - `app` user available in all .NET 8 Linux images
  - All images are now using port `8080` by default (not requiring root permissions)
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-1/#net-container-images)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-1/#net-8-ubuntu-chiseled-container-images)
  - [Announcement 3](https://devblogs.microsoft.com/dotnet/securing-containers-with-rootless/)
- Expanded support for building containers from .NET CLI
  - This is actually available in .NET 7.0.200 SDK, but mentioning it here as it was not included in the initial .NET 7 release
  - Registry authentication
  - [Cross-architecture containers](https://devblogs.microsoft.com/dotnet/improving-multiplatform-container-support/)
  - Building multi-platform container images
  - Improved support for rootless containers
  - Easier to get started in Web SDK projects - add `<EnableSdkContainerSupport>`
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/updates-to-container-support-in-the-dotnet-sdk/)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-dotnet-8-preview-3/#building-multi-platform-container-images)

### Tools

#### .NET 7

- Hot Reload improvements for Blazor WebAssembly, iOS and Android
  - More lambda methods support
  - Adding new static fields, static methods, and non-virtual instance methods
  - Adding new classes
  - `dotnet watch` restarts for rude edits
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-net-7-preview-1/#hot-reload-improvements)
- NuGet 6.4
  - [Central Package Management](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-4/#central-package-management)
  - `GlobalPackageReference`
  - Improved VS performance
  - [Announcement](https://devblogs.microsoft.com/nuget/announcing-nuget-6-4-signed-central-delivered/)

#### .NET 8

- [Olia Gavrysh: Upgrading your .NET projects with Visual Studio](https://devblogs.microsoft.com/dotnet/upgrade-assistant-now-in-visual-studio/)
- Hot Reload supports modifying generics
  - [Announcement](https://devblogs.microsoft.com/dotnet/hot-reload-generics/)

## Performance improvements

### .NET 7

- Announcements and blog posts
  - [Stephen Toub: Performance improvements in .NET 7](https://devblogs.microsoft.com/dotnet/performance_improvements_in_net_7/)
  - [Kunal Pathak: Arm64 performance improvements in .NET 7](https://devblogs.microsoft.com/dotnet/arm64-performance-improvements-in-dotnet-7/)
  - [Jon Douglas, Jeremy Likness and Angelos Petropoulos: .NET 7 is available today](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7/)
  - [Jonathan Peppers: .NET 7 performance improvements in .NET MAUI](https://devblogs.microsoft.com/dotnet/dotnet-7-performance-improvements-in-dotnet-maui/)
  - [Brennan Conroy: Performance improvements in ASP.NET 7](https://devblogs.microsoft.com/dotnet/performance-improvements-in-aspnet-core-7/)
  - [TechEmpower Web Framework Benchmark: Round 21](https://www.techempower.com/benchmarks/#section=data-r21&hw=ph&test=plaintext)
  - [Dustin Moris: How fast is really ASP.NET Core](https://dusted.codes/how-fast-is-really-aspnet-core)
  - [nopCommerce: Update to .NET 7 - what updates it brings and how it may improve a software](https://www.nopcommerce.com/en/blog/dotnet-7-updates-and-nopcommerce-performance)
- Improvements in existing CodeGen / JIT features
  - Dynamic PGO
  - Arm64
  - Loop optimizations
  - Logging source generator improvements
  - On-Stack Replacement (OSR)
  - Mono performance improved
- Regex source generator and other regex performance improvements
- Reflection and Interop
- Threading improvement
- Primitive types parsing, formatting and equality
- Arrays, strings, `Collection`s and `Span`s
- LINQ `Min`, `Max`, `Sum`, `Average`
- JSON, XML, Compression, Cryptography, Diagnostics, Exceptions...

### .NET 8

- Announcements and blog posts
  - [Steven Giesel: .NET 8 performance edition](https://steven-giesel.com/blogPost/f6504300-7bf0-48d2-8a14-ba4e2bbea02e)

## Entity Framework Core

### .NET 7

- Announcements and blog posts
  - [Jeremy Likness: Announcing the Plan for EF7](https://devblogs.microsoft.com/dotnet/announcing-the-plan-for-ef7/)
  - [Jeremy Likness: Announcing Entity Framework Core 7 Release Candidate 1](https://devblogs.microsoft.com/dotnet/announcing-ef7-release-candidate-1/)
  - [Arthur Vickers: Entity Framework Core 7 (EF7) is available today](https://devblogs.microsoft.com/dotnet/announcing-ef7/)
  - [What's new in EF Core 7.0](https://learn.microsoft.com/en-gb/ef/core/what-is-new/ef-core-7.0/whatsnew)
- [JSON columns in relational databases](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#json-columns)
- [Bulk updates](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#executeupdate-and-executedelete-bulk-updates)
- [Performance improvements on inserts and updates (`SaveChanges`)](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#faster-savechanges)
- [Map CUD operations to stored procedures](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#stored-procedure-mapping)
- [Table-per-concrete-type (TPC) mapping](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#table-per-concrete-type-tpc-inheritance-mapping)
- [Override model building conventions](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#model-building-conventions)
- [Database scaffolding T4 templates](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#custom-reverse-engineering-templates)
- [Interceptors improvements](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#new-and-improved-interceptors-and-events)
  - Intercept, modify, and/or suppress EF core operation
- [Query enhancements](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#query-enhancements)
- ...

### .NET 8

- Announcements, blog posts and videos
  - [Plan for Entity Framework Core 8](https://learn.microsoft.com/en-gb/ef/core/what-is-new/ef-core-8.0/plan)
  - [Latest news and progress on .NET 8 and EF8](https://github.com/dotnet/efcore/issues/29989)
  - [What's new in EF Core 8](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-8.0/whatsnew)
  - [Nick Chapsas: Entity Framework Core vs Dapper Performance in 2023](https://youtu.be/Q4LtKa_HTHU)
- Raw SQL queries for unmapped types
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ef8-preview-1/#raw-sql-queries-for-unmapped-types)
- Lazy loading for no-tracking queries
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ef8-preview-1/#lazy-loading-for-no-tracking-queries)
- DateOnly/TimeOnly support on SQL Server
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ef8-preview-1/#dateonly-timeonly-supported-on-sql-server)
- JSON columns in SQLite
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ef8-preview-2/#json-columns-for-sqlite)
- SQL Server HierarchyId support
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ef8-preview-2/#sql-server-hierarchyid)
- Translating LINQ Contains to OpenJson query
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ef8-preview-4/)

## ASP.NET Core

### .NET 7

- Announcements, blog posts and videos
  - [Damian Edwards and David Fowler: Hidden gems and live coding with .NET 7](https://ignite.microsoft.com/en-US/sessions/639d9c8d-e826-4a51-9e75-4c2c402b410a)
  - [Andrea Chiarelli: What's new in .NET for authentication and authorization](https://auth0.com/blog/whats-new-in-dotnet-7-for-authentication-and-authorization/)
- `RateLimiting` middleware
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-4/#rate-limiting-middleware)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-rate-limiting-for-dotnet/)
  - [Improvements](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-1/#rate-limiting-middleware-improvements)
  - [Maarten Balliauw: ASP.NET Core limiting middleware in .NET 7](https://blog.maartenballiauw.be/post/2022/09/26/aspnet-core-rate-limiting-middleware.html)
  - [Maarten Balliauw: Rate limiting in web applications - Concepts and approaches](https://blog.maartenballiauw.be/post/2022/10/03/rate-limiting-web-applications-concepts-approaches.html)
- Output caching middleware
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-6/#output-caching-middleware)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-2/#output-caching-improvements)
- Incremental ASP.NET migration tooling
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/incremental-asp-net-to-asp-net-core-migration/)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/incremental-asp-net-migration-tooling-preview-2/)
  - [Announcement 3](https://devblogs.microsoft.com/dotnet/migrating-from-asp-net-to-asp-net-core-part-4/)
  - [Announcement 4](https://devblogs.microsoft.com/dotnet/migrating-from-asp-net-to-asp-net-core-part-5/)
  - [Sayed Ibrahim Hashimi: Migrating ASP.NET to ASP.NET Core in Visual Studio](https://devblogs.microsoft.com/dotnet/introducing-project-migrations-visual-studio-extension/)
- Authentication improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-5/#jwt-authentication-improvements-automatic-authentication-configuration)
  - This has been partially removed from .NET 7
- Kestrel improvements
  - [Support for WebSockets over HTTP/2](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-6/#kestrel-support-for-websockets-over-http-2)
  - [Performance improved on high core machines](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-6/#kestrel-performance-improvements-on-high-core-machines)
  - [HTTP/2 performance improvement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-4/#http-2-performance-improvements) - gRPC, file uploads
  - [HTTP/3 performance improvement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-1/#http-3-improvements)
  - [HTTP/3 WebTransport support (Experimental)](https://devblogs.microsoft.com/dotnet/experimental-webtransport-over-http-3-support-in-kestrel/)
- New problem details service
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-7/#new-problem-details-service)
- Request decompression middleware (Brotli, Deflate, and GZip)
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-6/#request-decompression-middleware)
- No longer required to use `[FromServices]` in action method parameters
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-2/#infer-api-controller-action-parameters-that-come-from-services)
- `TryParse` method support for action method parameters
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-3/#bind-using-tryparse-in-mvc-and-api-controllers)
- Dark mode for developer exception page
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-3/#developer-exception-page-dark-mode)
- Managing development-time JWTs with `dotnet user-jwt`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-5/#managing-development-time-jwts-with-dotnet-user-jwts)
- Performance improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/performance-improvements-in-aspnet-core-7/)

#### Minimal APIs

- Blog posts
  - [Christian Nagel: Minimal API growing with .NET 7](https://csharp.christiannagel.com/2023/05/03/minimal-api-growing-with-net-7/)
- [Sample](https://github.com/miroslavpopovic/minimal-apis-sample)
- `IEndpointFilter` support
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-3/#support-for-route-handler-filters-in-minimal-apis) - before rename
  - [Announcement 2]()
- `IFormFile` and `IFormFileCollection`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-net-7-preview-1/#minimal-api-improvements)
- Binding to `Stream` or `PipeReader`
- Binding a set of parameters into a single object with properties with `[AsParameters]`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-5/#minimal-api-parameter-binding-for-argument-lists)
- Binding arrays
- Endpoint description and summaries used for OpenAPI
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-2/#provide-endpoint-descriptions-and-summaries-for-minimal-apis)
- `IResult` implementations are now public for improved testability and have new interfaces
  - `IContentTypeHttpResult`, `IFileHttpResult`, `INestedHttpResult`, `IStatusCodeHttpResult`, `IValueHttpResult`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-3/#improved-unit-testability-for-minimal-route-handlers)
- Typed results – `Microsoft.AspNetCore.Http.TypedResults`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-4/#typed-results-for-minimal-apis)
- Self-describing minimal APIs
  - `IEndpointMetadataProvider`, `IEndpointParameterMetadataProvider`
  - Uses C# 11 static abstract interface members, works with `TypedResults`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-4/#self-describing-minimal-apis-with-iendpointmetadataprovider-and-iendpointparametermetadataprovider)
- Route groups with `MapGroup()`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-4/#route-groups)

#### SignalR

- Client source generator
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-net-7-preview-1/#signalr-client-source-generator)
- Dependency injection for hub methods
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-2/#dependency-injection-for-signalr-hub-methods)
- Invoke client results from server using Clients.Single(connId).InvokeAsync<T>()
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-4/#client-results-in-signalr)

### .NET 8

- Announcements and blog posts
  - [ASP.NET Core Roadmap for .NET 8](https://github.com/dotnet/aspnetcore/issues/44984)
  - [Tim Anderson: Is ASP.NET on the right path?](https://devclass.com/2023/05/18/is-asp-net-on-the-right-path-microsoft-net-8-preview-prompts-debate-and-visual-studio-17-6-rolls-out/)
  - [ByteHide: ASP.NET Core in .NET 8 is on the way! Discover the NEW features!](https://dev.to/bytehide/aspnet-core-in-net-8-is-on-the-way-discover-the-new-features-3k86)
- Improved authentication & authorization experience
  - Removal of Duende IdentityServer from templates
  - Improved auth for self-hosting solutions
    - Extended existing cookie-based auth to support customization in SPA apps
    - Modernized existing identity to support token-based auth
    - This is intended for single domain solutions, with no cloud authentication or third-party API requirements!
  - Improved documentation, with a starting point for all auth scenarios
  - [Identity API endpoints](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#identity-api-endpoints)
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#improved-authentication-authorization-experience)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/improvements-auth-identity-aspnetcore-8/)
- Support for Native AOT
  - Only a partial support, available for [some templates](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#native-aot-ready-project-templates)
  - [Top-level APIs annotated for trim warnings](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#asp-net-core-top-level-apis-annotated-for-trim-warnings)
  - [Reduced app size with configurable HTTPS support](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#reduced-app-size-with-configurable-https-support)
  - [Worker Service template received AOT support](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#reduced-app-size-with-configurable-https-support)
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#native-aot)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#asp-net-core-support-for-native-aot)
  - [Benchmarks](https://msit.powerbi.com/view?r=eyJrIjoiYTZjMTk3YjEtMzQ3Yi00NTI5LTg5ZDItNmUyMGRlOTkwMGRlIiwidCI6IjcyZjk4OGJmLTg2ZjEtNDFhZi05MWFiLTJkN2NkMDExZGI0NyIsImMiOjV9&pageName=ReportSectiond12fbb3dbabb493336cd)
  - [Getting started](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#getting-started-with-native-aot-deployment-in-asp-net-core)
- `SlimBuilder`
  - `WebApplication.CreateSlimBuilder` API
  - Initializes only the essential features to minimize the app size
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#additional-default-services-configured-in-the-slim-builder)
- Route tooling
  - Built on Roslyn, should work on any IDE
  - Route syntax highlighting
  - Autocomplete of parameter and route names
  - Autocomplete of route constraints
  - Route analyzers and fixers
  - Supporting Minimal APIs, Web APIs, and Blazor
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#route-tooling)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/aspnet-core-route-tooling-dotnet-8/)
- Route constraint performance improvement
  - Regex constraints are now compiled
  - Duplicate constraints are now shared between routes
  - The alpha constraint now uses source generated regex
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#route-constraint-performance-improvements)
- Request timeouts
  - Available for individual endpoints, controllers, or dynamically per request
  - `builder.Services.AddRequestTimeouts();`
  - `app.UseRequestTimeouts();`
  - `.WithRequestTimeout(timeout)` or `[RequestTimeout(timeout)]`
  - `HttpContext.RequestAborted` cancellation token is triggered upon expiration, but the app is not aborted
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#request-timeouts)
- Short circuit routes
  - `app.MapGet("/", () => "Hello World!").ShortCircuit();` - define a route to short circuit
  - `app.MapShortCircuit(404, "robots.txt", "favicon.ico");` - define endpoints and status codes to short circuit
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#short-circuit-routes)
- New analyzers for API development
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#new-analyzers-for-api-development)
- New analyzer to detect multiple `[FromBody]` attributes
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-2/#new-analyzer-to-detect-multiple-frombody-attributes)
- New options to keep the SPA development server running
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#new-option-to-keep-the-spa-development-server-running)
- Kestrel and HttpSys connection improvements
  - Support for named pipes in Kestrel
  - HTTP/3 enabled by default
  - HTTP/2 over TLS (HTTPS) support on macOS
  - New `HTTP_PORTS` and `HTTPS_PORTS` configuration options
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#support-for-named-pipes-in-kestrel)
  - [Performance improvements for named pipes transport](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-2/#new-iresettable-interface-in-objectpool)
- `IPNetwork.Parse` and `TryParse` methods
  - Support for creating `IPNetwork` instances from [CIDR notation](https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing)
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#ipnetwork-parse-and-tryparse)
- New APIs in `ProblemDetails` to support more resilient integrations
  - `TryWriteAsync` API used to have a fallback when `ProblemDetail` cannot be generated
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-2/#new-apis-in-problemdetails-to-support-more-resilient-integrations)
- New `IResettable` interface in `Microsoft.Extensions.ObjectPool`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-2/#new-iresettable-interface-in-objectpool)

#### Minimal APIs

- Request Delegate Generator (RDG) source generator
  - Enables Native AOT scenarios by removing runtime generation of the code
  - Still does not support all Minimal API features
  - `<EnableRequestDelegateGenerator>` in project file
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#minimal-apis-and-native-aot)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#logging-and-exception-handling-in-compile-time-generated-minimal-apis)
- No need for `[FromForm]` attribute for form-based parameters (`IFormCollection`, `IFormFile`, and `IFormFileCollection`)
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#expanded-support-for-form-binding-in-minimal-apis)
- API project template includes `.http` file (available for any API project)
  - [Sample](https://github.com/miroslavpopovic/minimal-apis-sample/blob/main/src/MinimalApis.MinimalSample/api.http)
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#api-project-template-includes-http-file)

#### SignalR

- Specify server timeout and keep alive settings using the `HubConnectionBuilder`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#specify-server-timeout-and-keep-alive-interval-settings-using-the-hubconnectionbuilder)

## Blazor

### .NET 7

- Support for `System.Security.Cryptography`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-7/#additional-system-security-cryptography-support-on-webassembly)
- Blazor custom elements are no longer experimental
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-6/#blazor-custom-elements-no-longer-experimental)
- QuickGrid component (experimental)
  - https://aspnet.github.io/quickgridsamples/
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-6/#experimental-quickgrid-component-for-blazor)
- New loading page
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-7/#new-blazor-loading-page)
- Interoperability between .NET 7 and JavaScript through .NET WebAssembly runtime
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/use-net-7-from-any-javascript-app-in-net-7/)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-1/#net-javascript-interop-on-webassembly)
  - [Alen Genzić: New JavaScript Interop Improvements in .NET 7 RC1](https://www.infoq.com/news/2022/10/javascript-interop-dotnet-7-rc-1/)
- WebAssembly multithreading (experimental)
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-2/#webassembly-multithreading-experimental)
- Empty Blazor project templates
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-6/#empty-blazor-project-templates)
- `@bind:get` (value), `@bind:set` (callback), `@bind:after` (async) modifiers
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-7/#blazor-data-binding-get-set-after-modifiers)
- `NavigationManager` – pass state
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-7/#pass-state-using-navigationmanager)
- Dynamic authentication requests in Blazor WebAssembly – custom params
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-1/#dynamic-authentication-requests-in-blazor-webassembly)
- Improved diagnostics for authentication in Blazor WebAssembly
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-2/#improved-diagnostics-for-authentication-in-blazor-webassembly)
- Blazor WebAssembly debugging improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-1/#blazor-webassembly-debugging-improvements)

#### Blazor Hybrid

- [Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/?view=aspnetcore-7.0)
- Running natively on Windows and macOS via MAUI
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-net-6-preview-4/#net-maui-blazor-apps)
  - [Edward Charbeneau: Blazor Hybrid apps with .NET MAUI](https://www.codemag.com/Article/2111092/Blazor-Hybrid-Web-Apps-with-.NET-MAUI)
- `BlazorWebView` for WPF, Windows Forms, and MAUI apps

### .NET 8

- Announcements and blog posts
  - [Jon Hilton: Big changes coming for Blazor in .NET 8](https://www.telerik.com/blogs/big-changes-coming-blazor-dotnet-8)
- (Just) Blazor
  - Previously "Blazor United" or "Full stack web UI with Blazor"
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#full-stack-web-ui-with-blazor)
- Server-side rendering with Blazor components
  - TODO: Demo needed here!
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#server-side-rendering-with-blazor-components)
  - [Form posts can also be handled with it](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#handling-form-posts-with-blazor-ssr)
- Streaming rendering with Blazor components
  - Needs `[StreamRendering(true)]` on the component
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#streaming-rendering-with-blazor-components)
- Rendering Razor components outside of ASP.NET Core
  - I.e., to a string or stream
  - Example use case: generate emails, static site content, etc.
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#render-razor-components-outside-of-asp-net-core)
- Support for Sections in Blazor
  - `SectionOutlet` and `SectionContent` components
  - Can be used as placeholders in layout that are filled in by specific pages
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#sections-support-in-blazor)
- Route to named elements
  - If HTML elements have the standard `id` attribute, Blazor will scroll the page when URL fragment matches the `id`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#route-to-named-elements-in-blazor)
- Monitoring Blazor Server circuit activity
  - Inbound circuit activity is any activity that originates from the browser, like UI events or JavaScript-to-.NET interop calls
  - `CircuitHandler.CreateInboundActivityHandler`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#monitor-blazor-server-circuit-activity)
- `QuickGrid` is now part of .NET 8
  - [Samples](https://aspnet.github.io/quickgridsamples/)
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-2/#blazor-quickgrid-component)
- Debugging and hot reload improvements
  - Hot reload support for instance fields, properties, and events for .NET on WebAssembly
  - Support for symbol servers when debugging .NET on WebAssembly
  - Blazor WebAssembly debugging in Firefox
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#hot-reload-support-for-instance-fields-properties-and-events-for-net-on-webassembly)
- Experimental Webcil format for .NET assemblies and Blazor WebAssembly apps
  - `<WasmEnableWebcil>true</WasmEnableWebcil>` in WebAssembly project file
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#experimental-webcil-format-for-net-assemblies)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#webcil-packaging-for-blazor-webassembly-apps)
- Improved Blazor WebAssembly performance with the jiterpreter
  - Replacing the interpreter bytecodes with tiny blobs of WebAssembly
  - Useful when AOT compiler is not an option, but can optimize AOT performance too
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-2/#improved-blazor-webassembly-performance-with-the-jiterpreter)

## MAUI

### .NET 7

- Announcements, blog posts, documentation
  - [Documentation](https://dotnet.microsoft.com/en-us/apps/maui)
  - [Michael Stonis: .NET MAUI eBook now available - Enterprise Application Patterns](https://devblogs.microsoft.com/dotnet/dotnet-maui-ebook-released/)
  - [David Ortinau: .NET MAUI - one codebase, many platforms](https://devblogs.microsoft.com/dotnet/introducing-dotnet-maui-one-codebase-many-platforms/)
  - [David Ortinau: .NET MAUI in .NET 7 Release Candidate 1](https://devblogs.microsoft.com/dotnet/dotnet-maui-in-dotnet-7-rc1/)
  - [David Ortinau: Announcing .NET MAUI for .NET 7 general availability](https://devblogs.microsoft.com/dotnet/dotnet-maui-dotnet-7/)
  - [James Montemagno: 5 .NET MAUI features for building great desktop apps](https://devblogs.microsoft.com/dotnet/5-dotnet-maui-desktop-features/)
  - [David Ramel: Did .NET MAUI ship too soon? Devs sound off on 'massive mistake'](https://visualstudiomagazine.com/articles/2022/09/29/net-maui-complaints.aspx)
  - [Miguel de Icaza: Twitter thread on .NET MAUI](https://twitter.com/migueldeicaza/status/1559898665350832128)
- Support for iOS, Android, macOS, Windows, Tizen
  - [Tizen announcement](https://devblogs.microsoft.com/dotnet/dotnet-maui-rc-2/)
- Essentials (previously Xamarin.Essentials) for common device features is included in core
  - [Announcement](https://devblogs.microsoft.com/dotnet/dotnet-maui-preview-14/)
- .NET MAUI Community Toolkit
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/introducing-the-net-maui-community-toolkit-preview/)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/announcing-the-dotnet-maui-community-toolkit-v13/)
  - [Announcement 3](https://devblogs.microsoft.com/dotnet/whats-new-in-the-dotnet-maui-community-toolkit/)
- Performance improvement over Xamarin.Forms
  - [Jonathan Peppers: Performance improvements in .NET MAUI](https://devblogs.microsoft.com/dotnet/performance-improvements-in-dotnet-maui/)
- maui-check tool – check and fix the requirements
- Supported in `Microsoft.Identity.Client` for authentication
  - [Sameer Khandekar: Authentication for .NET MAUI apps with MSAL.NET](https://devblogs.microsoft.com/dotnet/authentication-in-dotnet-maui-apps-msal/)

### .NET 8

- Announcements, blog posts, documentation
  - [Roadmap](https://github.com/dotnet/maui/wiki/Roadmap)
- Improving quality - resolving issues, merging pull requests
  - Most attention was given to `CollectionView`, `Shell` and drawing (shapes, shadows, clipping)
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-maui-in-dotnet-8-preview-3/#improving-quality)
- Improving memory management
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-maui-in-dotnet-8-preview-3/#improving-memory-management)
- New version of .NET Upgrade Assistant supports Xamarin.Forms upgrade to .NET MAUI
  - [Announcement](https://devblogs.microsoft.com/dotnet/upgrade-assistant-general-availability/)

## gRPC

### .NET 7

- JSON transcoding
  - Use gRPC services like RESTful HTTP APIs
  - OpenAPI support (Experimental)
  - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-grpc-json-transcoding-for-dotnet/)
  - [Announcement 2](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-rc-1/#experimental-openapi-support-for-grpc-json-transcoding)

### .NET 8

- gRPC JSON transcoding no longer requires `http.proto` and `annotations.proto`
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-1/#support-for-named-pipes-in-kestrel)
- Native AOT supported for both client and server apps
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-3/#grpc-and-native-aot)

## Desktop

### Windows Forms

#### .NET 7

- Accessibility improvements and fixes
  - [Announcement](https://devblogs.microsoft.com/dotnet/winforms-enhancements-in-dotnet-7/#accessibility-improvements-and-fixes)
- High DPI and scaling improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/winforms-enhancements-in-dotnet-7/#high-dpi-and-scaling-improvements)
- Databinding improvements
  - [Announcement](https://devblogs.microsoft.com/dotnet/winforms-enhancements-in-dotnet-7/#databinding-improvements)
- ComWrappers and native AOT
  - [Announcement](https://devblogs.microsoft.com/dotnet/winforms-enhancements-in-dotnet-7/#comwrappers-and-native-aot)
- Custom controls for WinForm's out-of-process designer
  - [Announcement](https://devblogs.microsoft.com/dotnet/custom-controls-for-winforms-out-of-process-designer/)
- Using MVVM with WinForms and going cross-platform with MAUI
  - [Announcement](https://devblogs.microsoft.com/dotnet/winforms-cross-platform-dotnet-maui-command-binding/)
- Improved code generation for `InitializeComponent`
  - [Announcement](https://devblogs.microsoft.com/dotnet/winforms-codegen-update/)
- WinForms Visual Basic Application Framework has new features
    - [Announcement](https://devblogs.microsoft.com/dotnet/update-to-winforms-vb-appframework/)

#### .NET 8

- TODO: ...

### WPF

#### .NET 7

- Performance
  - [Announcement](https://devblogs.microsoft.com/dotnet/wpf-on-dotnet-7/#performance)
- Accessibility
  - [Announcement](https://devblogs.microsoft.com/dotnet/wpf-on-dotnet-7/#accessibility)
- Bug fixes
  - [Announcement](https://devblogs.microsoft.com/dotnet/wpf-on-dotnet-7/#bug-fixes)

#### .NET 8

- TODO: ...

## Monitoring and metrics

### .NET 7

- Added metrics for `Microsoft.Extensions.Caching`
  - `MemoryCacheStatistics` – cache hit/miss/estimated size and count
  - `IMemoryCache.GetCurrentStatistics()`
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-4/#added-metrics-for-microsoft-extensions-caching)

### .NET 8

- Metrics added for ASP.NET Core hosting, Kestrel and SignalR
  - [Announcement](https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-8-preview-4/#asp-net-core-metrics)
- A new Azure Monitor OpenTelemetry distro library
  - Enables monitoring ASP.NET Core apps with Azure Monitor, based on the infrastructure of OpenTelemetry for .NET
  - [Announcement](https://devblogs.microsoft.com/dotnet/azure-monitor-opentelemetry-distro/)

## CoreWCF

- Community project
  - [CoreWCF on GitHub](https://devblogs.microsoft.com/dotnet/corewcf-v1-released/)
- Features are a subset of functionality from WCF
  - HTTP and NetTCP transports
  - `BasicHttpBinding`, `NetHttpBinding`, `NetTcpBinding`, `WebHttpBinding`, `WSHttpBinding` (some WS-* features are not supported)
  - Transport security, Username, Certificate and Windows auth, WS Federation...
  - WSDL generation
  - Partial configuration support including service and endpoints
  - Extensibility (`IServiceBehavior` and `IEndpointBehavior`)
- Not implemented
  - Transports other than HTTP and NetTCP
    - Named Pipes are coming in 1.4
  - Message security beyond Transport and Transport with Message Credentials
  - Distributed transactions
  - Message Queueing
    - Queue Transport is coming in 1.4
- 1.0 released in April 2022.
  - [Announcement](https://devblogs.microsoft.com/dotnet/corewcf-v1-released/)
- Project templates added in 1.1
  - [Announcement](https://devblogs.microsoft.com/dotnet/corewcf-1-1-0-and-project-templates/)
- 1.2 released in September 2022.
  - [Announcement](https://github.com/CoreWCF/CoreWCF/releases/tag/v1.2.0)
- 1.3 brought support for ASP.NET Core authorization
  - [Announcement](https://github.com/CoreWCF/CoreWCF/releases/tag/v1.3.0)
- 1.4 brings support for Named Pipes and Queue transports
  - [Announcement](https://github.com/CoreWCF/CoreWCF/releases/tag/v1.4.0-preview1)
- .NET Upgrade Assistant is able to migrate WCF services to CoreWCF
  - [Announcement](https://devblogs.microsoft.com/dotnet/migration-wcf-to-corewcf-upgrade-assistant/)
- Client support for calling WCF/CoreWCF with `System.ServiceModel` 6.0 is available
  - [Announcement](https://devblogs.microsoft.com/dotnet/wcf-client-60-has-been-released/)

## YARP

- YARP: Yet Another Reverse Proxy
- Announcements and blog posts
  - [YARP on GitHub](https://github.com/microsoft/reverse-proxy)
  - [Documentation](https://microsoft.github.io/reverse-proxy/)
  - [Sam Spencer: YARP 1.1 is here with new requested reverse proxy features](https://devblogs.microsoft.com/dotnet/yarp-reverse-proxy-1-1-release/)
  - [Byron Tardif: A heavy lift: Bringing Kestrel + YARP to Azure App Services](https://devblogs.microsoft.com/dotnet/bringing-kestrel-and-yarp-to-azure-app-services/)
- WebSockets over HTTP/2
  - [Documentation](https://microsoft.github.io/reverse-proxy/articles/websockets.html)
  - [Announcement](https://github.com/microsoft/reverse-proxy/releases/tag/v2.0.0-rc.1)

## ML.NET

- ML.NET is an open-source, cross-platform machine learning framework for .NET developers
  - [ML.NET on GitHub](https://github.com/dotnet/machinelearning)
  - [Documentation](https://dotnet.microsoft.com/en-us/apps/machinelearning-ai/ml-dotnet)
  - [Roadmap](https://github.com/dotnet/machinelearning/blob/main/ROADMAP.md)
  - [Model Builder release notes](https://github.com/dotnet/machinelearning-modelbuilder/tree/main/docs/release-notes)
- ML.NET 2.0 released on November 2022
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ml-net-2-0/)
  - Text Classification scenario in Model Builder
    - [Announcement](https://devblogs.microsoft.com/dotnet/introducing-the-ml-dotnet-text-classification-api-preview/)
  - Sentence Similarity API
    - [Announcement 1](https://devblogs.microsoft.com/dotnet/announcing-ml-net-2-0/#sentence-similarity-api)
    - [Announcement 2](https://devblogs.microsoft.com/dotnet/sentence-similarity-mlnet-model-builder/)
    - [Luis Quintanilla: Sentence similarity in ML.NET Model Builder](https://devblogs.microsoft.com/dotnet/sentence-similarity-mlnet-model-builder/)
  - Tokenizer support
    - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ml-net-2-0/#tokenizer-support)
  - Automated machine learning (AutoML) improvements
    - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-ml-net-2-0/#automated-machine-learning-automl-improvements)
- ML.NET 3.0 Preview 2 released May 16th 2023
  - [Announcement](https://github.com/dotnet/machinelearning/releases/tag/v3.0.0-Preview)
  - New AutoML features
  - Using TorchSharp for Object Detection
  - Upgraded libraries used to latest version
  - Compiled with .NET 8

### SynapseML for .NET

- Author, train, and use SynapseML model from C#, or any .NET language, with [.NET for Apache Spark](https://dotnet.microsoft.com/en-us/apps/data/spark) language bindings
- Enables distributed machine learning functionality
- [Announcement](https://devblogs.microsoft.com/dotnet/announcing-synapseml-for-dotnet/)
- [Documentation](https://microsoft.github.io/SynapseML/docs/about/)
- [SynapseML on GitHub](https://github.com/Microsoft/SynapseML)

## Microsoft Orleans

- Cloud native application framework for .NET
  - [Orleans on GitHub](https://github.com/dotnet/orleans)
  - [Documentation](https://learn.microsoft.com/en-us/dotnet/orleans/)
- Version 7.0 released with with .NET 7
  - [Announcement](https://devblogs.microsoft.com/dotnet/whats-new-in-orleans-7/)
  - Inlined with .NET versions
  - Performance improvements
  - Improved development experience
  - Simplified `Grain` and `Stream` identification

## Dapr

- APIs for building portable and reliable microservices
  - [Dapr on GitHub](https://github.com/dapr)
  - [Documentation](https://docs.dapr.io/)
- The current version is 1.10.x, with 1.11.0 in RC1 phase
- [Dapr is integrated into Azure Container Apps](https://learn.microsoft.com/en-us/azure/container-apps/dapr-overview)

## Community Toolkits

- [.NET Community Toolkit](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/introduction)
  - [Version 8.0 released in April 2022](https://devblogs.microsoft.com/dotnet/announcing-the-dotnet-community-toolkit-800/)
    - MVVM toolkit
      - Inspired by MvvmLight
      - Source generators for commands and observable properties
      - Improved messenger APIs
      - Sample app
    - Improved diagnostics API
    - Support for .NET 6
  - [Version 8.1 released in January 2023](https://devblogs.microsoft.com/dotnet/announcing-the-dotnet-community-toolkit-810/)
    - Custom attributes for `[ObservableProperty]`
    - MVVM Toolkit analyzers
    - MVVM Toolkit source generator optimizations
    - `IObservable<T>` messenger extensions
    - Support for .NET 7
  - [Version 8.2 released in April 2023](https://devblogs.microsoft.com/dotnet/announcing-the-dotnet-community-toolkit-820/)
    - Custom attributes for `[RelayCommand]`
      - I.e., adding `[property: JsonIgnore]` to the command method will add it to the generated command property
    - New `[ObservableProperty]` change hooks
    - MVVM Toolkit code fixers
    - MVVM Toolkit source generator optimizations
- [Windows Community Toolkit](https://docs.microsoft.com/en-us/windows/communitytoolkit/)
- [.NET  MAUI Community Toolkit](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/)
  - `FileSaver` and `FolderPicker` dialogs
  - [Announcement](https://devblogs.microsoft.com/dotnet/file-and-folder-dialogs-communitytoolkit/)

## Cloud and dogfooding

- [AppService is using Kestrel + YARP](https://devblogs.microsoft.com/dotnet/bringing-kestrel-and-yarp-to-azure-app-services/)
- [Azure Functions supports .NET 7](https://devblogs.microsoft.com/dotnet/dotnet-7-comes-to-azure-functions/)
- [Amazon EC2 and AWS Lambda support .NET 7](https://github.com/aws-samples/aws-net-guides/tree/master/RuntimeSupport/dotnet7)
- [Azure Active Directory Gateway on .NET 6](https://devblogs.microsoft.com/dotnet/azure-active-directorys-gateway-is-on-net-6-0/)
- [Microsoft Graph on .NET 6](https://devblogs.microsoft.com/dotnet/microsoft-graph-dotnet-6-journey/)
- [Azure Cosmos DB on .NET 6](https://devblogs.microsoft.com/dotnet/the-azure-cosmos-db-journey-to-net-6/)
- [Exchange Online on .NET 6](https://devblogs.microsoft.com/dotnet/exchange-online-journey-to-net-core/)
- [Microsoft Commerce on .NET 6](https://devblogs.microsoft.com/dotnet/microsoft-commerce-dotnet-6-migration-journey/)
- [Microsoft Teams Infrastructure and Assignments on .NET 6](https://devblogs.microsoft.com/dotnet/microsoft-teams-infrastructure-and-azure-communication-services-journey-to-dotnet-6/)
- [Microsoft Teams' Permission Service migration to .NET 6](https://devblogs.microsoft.com/dotnet/microsoft-teams-permission-service-migration-to-dotnet-6/)
- [Bing Ads on .NET 6](https://devblogs.microsoft.com/dotnet/microsoft-teams-assignments-service-dotnet-6-journey/)
- [OneService Journey to .NET 6](https://devblogs.microsoft.com/dotnet/one-service-journey-to-dotnet-6/)
- [Bing from .NET 5 to .NET 7+](https://devblogs.microsoft.com/dotnet/dotnet-performance-delivers-again-for-bing-from-dotnet-5-to-dotnet-7/)

## Visual Studio

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [Visual Studio 2022 Preview](https://visualstudio.microsoft.com/vs/preview/)
- [Visual Studio Blog (with announcements)](https://devblogs.microsoft.com/visualstudio/)
- Announcements and blog posts
  - [Sayed Ibrahim Hashimi: Port tunneling for ASP.NET Core projects](https://devblogs.microsoft.com/visualstudio/introducing-private-preview-port-tunneling-visual-studio-for-asp-net-core-projects/)
  - [Dante Gagne: Visual Studio Spell Checker preview](https://devblogs.microsoft.com/visualstudio/visual-studio-spell-checker-preview-now-available/)
  - [Sayed Ibrahim Hashimi: Web API development in VS 2022](https://devblogs.microsoft.com/visualstudio/web-api-development-in-visual-studio-2022/)
  - [Jessie Houghton: Git tooling preview features to enhance productivity](https://devblogs.microsoft.com/visualstudio/git-tooling-preview-features-to-enhance-productivity/)
  - [Mads Kristensen: Cool features in Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/cool-features-in-visual-studio-2022/)
  - [Jordan Matthiesen: Visual Studio 2022 for Mac is now available](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-for-mac-is-now-available/)
  - [Kaitlin Brooks, Cherry Wang, Dante Gagne: Visual Studio UI refresh](https://devblogs.microsoft.com/visualstudio/visual-studio-ui-refresh/)
- Visual Studio 2022 17.1
  - [Announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-1-is-now-available/)
  - Faster code search with indexed Find in files
  - Improved Git tooling
  - Improved productivity with Solution Filters
- Visual Studio 2022 17.2
  - [Announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-2-is-now-available/)
  - Source Link in Go to Implementation
  - Raw string literals
  - Debugging collections
  - Improved Razor editor
  - Improved Azure development support
  - Improved Git tooling
- Visual Studio 2022 17.3
  - [Announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-3-is-now-available/)
  - MAUI support
  - Support for Microsoft Teams development
  - Support for deployment to Azure Container Apps
  - Live unit testing
- Visual Studio 2022 17.4
  - [Announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-4/)
  - .NET 7 support
  - [Support for Arm64 building and debugging](https://devblogs.microsoft.com/visualstudio/arm64-visual-studio/)
  - Visual Studio installation rollback
  - Selection match highlight
  - Audio cues
  - DataTable visualizer
  - Performance improvements
- Visual Studio 2022 17.5
  - [Announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-5-released/)
  - All-in-one search
  - AI-powered, intent-based suggestions
  - Debugger text visualizer - URL encode/decode, Base64 encode/decode, JWT decode
  - Faster .NET builds
  - Improved Razor and C# experience
  - API development inner loop
    - Support for `.http`/`.rest` files
  - Improved Dev Tunnels configuration and management
  - Accessibility checker
  - Always update on close functionality
  - [Performance improvements](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-5-performance-enhancements/)
  - [Visual Studio 2022 17.5 for Mac](https://devblogs.microsoft.com/visualstudio/visual-studio-for-mac-17-5-is-now-available/)
- Visual Studio 2022 17.6 Preview 1
  - [Announcement](https://devblogs.microsoft.com/visualstudio/try-visual-studio-2022-v17-6-preview-1/)
  - Brace Pair colorization
  - Git line un-staging
  - GitHub issues
  - IntelliCode API usage examples for C#
  - Visualizers support for .NET remote debugging
  - .NET MAUI tooling for ARM64 devices
- Visual Studio 2022 17.6 Preview 2
  - [Announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-v17-6-preview-2-is-now-available/)
  - Git stage and commit during build and improved merge dialog
  - Breakpoint groups
  - Profiler live graph for .NET on WSL
  - Android manifest editor
- Visual Studio 2022 17.6
  - [Announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-6-performance-enhancements/)
  - Performance improvements for solution open, close, git file history, git branch switch, lightbulb actions, performance profiler
  - [All-in-one search](https://devblogs.microsoft.com/visualstudio/all-in-one-search-available-in-17-6/)
- Visual Studio 2022 17.7 Preview 1
  - [Announcement](https://devblogs.microsoft.com/visualstudio/visual-studio-2022-17-7-preview-1-is-here/)
  - Comparing files in Solution Explorer
  - Multi-branch graph & git repository improvements
  - Copy and trim indentation
  - All-in-one search enhancements
  - Publish Blazor WebAssembly to Azure Static Web Apps

## Visual Studio Code

- [Visual Studio Code](https://code.visualstudio.com/)
- [Visual Studio Code Blog](https://code.visualstudio.com/blogs)
- Polyglot Notebooks
  - C#, F#, PowerShell, JavaScript, HTML, T-SQL
  - [Announcement](https://devblogs.microsoft.com/dotnet/announcing-polyglot-notebooks-harness-the-power-of-multilanguage-notebooks-in-visual-studio-code/)
  - [Claudia Regio: .NET Interactive Notebooks is now Polyglot Notebooks!](https://devblogs.microsoft.com/dotnet/dotnet-interactive-notebooks-is-now-polyglot-notebooks/)
- https://vscode.dev/
- Visual Studio Code Server

## JetBrains tools

- [JetBrains](https://www.jetbrains.com/)
- [The .NET tools blog](https://blog.jetbrains.com/dotnet/)
- [ReSharper](https://www.jetbrains.com/resharper/)
- [Rider](https://www.jetbrains.com/rider/)
- [Fleet](https://www.jetbrains.com/fleet/)

## Dev tools

- [Microsoft Dev Box](https://azure.microsoft.com/en-us/products/dev-box/)
  - Workstation in the cloud
  - [Ruben Rios: Turbocharge your Visual Studio experience with Microsoft Dev Box](https://devblogs.microsoft.com/visualstudio/turbocharge-your-visual-studio-experience-with-microsoft-dev-box/)
  - [Josh Zimmerman: Microsoft Dev Box for Microsoft engineers](https://devblogs.microsoft.com/engineering-at-microsoft/dev-box-for-microsoft-engineers/)
- [GitHub Codespaces](https://github.com/features/codespaces)
  - Dedicated dev environments
  - Press `.` in any GitHub repository in browser, to open in VS Code (https://github.dev/)
- [Dev Home](https://learn.microsoft.com/en-us/windows/dev-home/)
  - [Announcement](https://devblogs.microsoft.com/visualstudio/devdrive/)
- [Dev Drive](https://learn.microsoft.com/en-us/windows/dev-drive/)
  - [Announcement](https://devblogs.microsoft.com/visualstudio/devdrive/)
  - [Copy-on-write and best practices](https://devblogs.microsoft.com/engineering-at-microsoft/dev-drive-and-copy-on-write-for-developer-performance/)

## GitHub Copilot

- [GitHub Copilot](https://copilot.github.com/)
- [Documentation](https://docs.github.com/en/copilot)
- Announcements and blog posts
  - [Mads Kristensen: GitHub Copilot in Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/github-copilot-in-visual-studio-2022/)
  - [Mark Wilson-Thomas: GitHub Copilot Chat for Visual Studio 2022](https://devblogs.microsoft.com/visualstudio/github-copilot-chat-for-visual-studio-2022/)
  - [Introducing GitHub Copilot X](https://github.com/features/preview/copilot-x)

## AI

- Getting started with OpenAI in .NET by Luis Quintanilla
  - [Transform your business with smart .NET apps powered by Azure and ChatGPT](https://devblogs.microsoft.com/dotnet/transform-business-smart-dotnet-apps-azure-chatgpt/)
  - [Get started with OpenAI in .NET](https://devblogs.microsoft.com/dotnet/getting-started-azure-openai-dotnet/)
  - [Get started with OpenAI Completions with .NET](https://devblogs.microsoft.com/dotnet/get-started-with-open-ai-completions-with-dotnet/)
  - [Level up your GPT game with prompt engineering](https://devblogs.microsoft.com/dotnet/gpt-prompt-engineering-openai-azure-dotnet/)
  - [Object detection in ML.NET Model Builder](https://devblogs.microsoft.com/dotnet/object-detection-ml-dotnet-model-builder/)
  - [Getting started with ChatGPT in .NET](https://devblogs.microsoft.com/dotnet/get-started-chatgpt-azure-dotnet/)
  - [Transform your business with smart .NET apps powered by Azure and ChatGPT](https://devblogs.microsoft.com/dotnet/transform-business-smart-dotnet-apps-azure-chatgpt/)

## License

See [LICENSE](LICENSE) file.
