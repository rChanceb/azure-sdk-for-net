// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary>
    /// TokensOperations operations.
    /// </summary>
    public partial interface ITokensOperations
    {
        /// <summary>
        /// Gets the properties of the specified token.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='tokenName'>
        /// The name of the token.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Token>> GetWithHttpMessagesAsync(string resourceGroupName, string registryName, string tokenName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a token for a container registry with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='tokenName'>
        /// The name of the token.
        /// </param>
        /// <param name='tokenCreateParameters'>
        /// The parameters for creating a token.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Token>> CreateWithHttpMessagesAsync(string resourceGroupName, string registryName, string tokenName, Token tokenCreateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a token from a container registry.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='tokenName'>
        /// The name of the token.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string registryName, string tokenName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a token with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='tokenName'>
        /// The name of the token.
        /// </param>
        /// <param name='tokenUpdateParameters'>
        /// The parameters for updating a token.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Token>> UpdateWithHttpMessagesAsync(string resourceGroupName, string registryName, string tokenName, TokenUpdateParameters tokenUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the tokens for the specified container registry.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<IPage<Token>>> ListWithHttpMessagesAsync(string resourceGroupName, string registryName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a token for a container registry with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='tokenName'>
        /// The name of the token.
        /// </param>
        /// <param name='tokenCreateParameters'>
        /// The parameters for creating a token.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Token>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string registryName, string tokenName, Token tokenCreateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a token from a container registry.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='tokenName'>
        /// The name of the token.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string registryName, string tokenName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a token with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='tokenName'>
        /// The name of the token.
        /// </param>
        /// <param name='tokenUpdateParameters'>
        /// The parameters for updating a token.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Token>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string registryName, string tokenName, TokenUpdateParameters tokenUpdateParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the tokens for the specified container registry.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<IPage<Token>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
