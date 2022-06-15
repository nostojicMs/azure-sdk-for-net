// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppBuilderResourceOperationSource : IOperationSource<AppBuilderResource>
    {
        private readonly ArmClient _client;

        internal AppBuilderResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppBuilderResource IOperationSource<AppBuilderResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppBuilderResourceData.DeserializeAppBuilderResourceData(document.RootElement);
            return new AppBuilderResource(_client, data);
        }

        async ValueTask<AppBuilderResource> IOperationSource<AppBuilderResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppBuilderResourceData.DeserializeAppBuilderResourceData(document.RootElement);
            return new AppBuilderResource(_client, data);
        }
    }
}
