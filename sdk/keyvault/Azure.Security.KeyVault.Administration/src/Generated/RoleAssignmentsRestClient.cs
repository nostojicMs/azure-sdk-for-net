// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Security.KeyVault.Administration.Models;

namespace Azure.Security.KeyVault.Administration
{
    internal partial class RoleAssignmentsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of RoleAssignmentsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RoleAssignmentsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string apiVersion = "7.3")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateDeleteRequest(string vaultBaseUrl, string scope, string roleAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignments/", false);
            uri.AppendPath(roleAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a role assignment. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignment to delete. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/> or <paramref name="roleAssignmentName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string vaultBaseUrl, string scope, string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentName));
            }

            using var message = CreateDeleteRequest(vaultBaseUrl, scope, roleAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 404:
                    return message.Response;
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a role assignment. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignment to delete. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/> or <paramref name="roleAssignmentName"/> is null. </exception>
        public Response Delete(string vaultBaseUrl, string scope, string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentName));
            }

            using var message = CreateDeleteRequest(vaultBaseUrl, scope, roleAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 404:
                    return message.Response;
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string vaultBaseUrl, string scope, string roleAssignmentName, RoleAssignmentCreateParameters parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignments/", false);
            uri.AppendPath(roleAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a role assignment. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignment to create. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to create. It can be any valid GUID. </param>
        /// <param name="parameters"> Parameters for the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/>, <paramref name="roleAssignmentName"/> or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<KeyVaultRoleAssignment>> CreateAsync(string vaultBaseUrl, string scope, string roleAssignmentName, RoleAssignmentCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateRequest(vaultBaseUrl, scope, roleAssignmentName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        KeyVaultRoleAssignment value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = KeyVaultRoleAssignment.DeserializeKeyVaultRoleAssignment(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a role assignment. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignment to create. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to create. It can be any valid GUID. </param>
        /// <param name="parameters"> Parameters for the role assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/>, <paramref name="roleAssignmentName"/> or <paramref name="parameters"/> is null. </exception>
        public Response<KeyVaultRoleAssignment> Create(string vaultBaseUrl, string scope, string roleAssignmentName, RoleAssignmentCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateRequest(vaultBaseUrl, scope, roleAssignmentName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        KeyVaultRoleAssignment value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = KeyVaultRoleAssignment.DeserializeKeyVaultRoleAssignment(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string vaultBaseUrl, string scope, string roleAssignmentName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignments/", false);
            uri.AppendPath(roleAssignmentName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the specified role assignment. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignment. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/> or <paramref name="roleAssignmentName"/> is null. </exception>
        public async Task<Response<KeyVaultRoleAssignment>> GetAsync(string vaultBaseUrl, string scope, string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentName));
            }

            using var message = CreateGetRequest(vaultBaseUrl, scope, roleAssignmentName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KeyVaultRoleAssignment value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = KeyVaultRoleAssignment.DeserializeKeyVaultRoleAssignment(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the specified role assignment. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignment. </param>
        /// <param name="roleAssignmentName"> The name of the role assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/> or <paramref name="roleAssignmentName"/> is null. </exception>
        public Response<KeyVaultRoleAssignment> Get(string vaultBaseUrl, string scope, string roleAssignmentName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleAssignmentName == null)
            {
                throw new ArgumentNullException(nameof(roleAssignmentName));
            }

            using var message = CreateGetRequest(vaultBaseUrl, scope, roleAssignmentName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KeyVaultRoleAssignment value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = KeyVaultRoleAssignment.DeserializeKeyVaultRoleAssignment(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForScopeRequest(string vaultBaseUrl, string scope, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleAssignments", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets role assignments for a scope. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignments. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignments at or above the scope. Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleAssignmentListResult>> ListForScopeAsync(string vaultBaseUrl, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListForScopeRequest(vaultBaseUrl, scope, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleAssignmentListResult.DeserializeRoleAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets role assignments for a scope. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignments. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignments at or above the scope. Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="scope"/> is null. </exception>
        public Response<RoleAssignmentListResult> ListForScope(string vaultBaseUrl, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListForScopeRequest(vaultBaseUrl, scope, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleAssignmentListResult.DeserializeRoleAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListForScopeNextPageRequest(string nextLink, string vaultBaseUrl, string scope, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets role assignments for a scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignments. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignments at or above the scope. Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="vaultBaseUrl"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleAssignmentListResult>> ListForScopeNextPageAsync(string nextLink, string vaultBaseUrl, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListForScopeNextPageRequest(nextLink, vaultBaseUrl, scope, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleAssignmentListResult.DeserializeRoleAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets role assignments for a scope. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role assignments. </param>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role assignments at or above the scope. Use $filter=principalId eq {id} to return all role assignments at, above or below the scope for the specified principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="vaultBaseUrl"/> or <paramref name="scope"/> is null. </exception>
        public Response<RoleAssignmentListResult> ListForScopeNextPage(string nextLink, string vaultBaseUrl, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListForScopeNextPageRequest(nextLink, vaultBaseUrl, scope, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleAssignmentListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleAssignmentListResult.DeserializeRoleAssignmentListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
