[![](https://img.shields.io/nuget/v/soenneker.together.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.together.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.together.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.together.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.together.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.together.openapiclient/actions/workflows/codeql.yml)
[![](https://img.shields.io/nuget/dt/soenneker.together.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.together.openapiclient/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Together.OpenApiClient
A Kiota-generated client for Together AI's inference, model, file, fine-tuning, and deployment APIs.

## Installation

```bash
dotnet add package Soenneker.Together.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Together.OpenApiClient;
using Soenneker.Together.OpenApiClient.Models;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.together.ai/v1/")
};

httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", togetherApiKey);

var authentication = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authentication, httpClient: httpClient);
var together = new TogetherOpenApiClient(adapter);

WhoamiResponse? account =
    await together.Whoami.GetAsync(cancellationToken: cancellationToken);
```

Reuse the `TogetherOpenApiClient`, request adapter, and `HttpClient` rather than creating them for every request.

Generated request builders follow the API path hierarchy. For example, `/chat/completions` is exposed through `together.Chat.Completions`, and `/files/upload` through `together.Files.Upload`.

Inference, fine-tuning, deployment, and other mutation endpoints may incur charges. Validate request models and cancellation behavior before using them in automated flows.
