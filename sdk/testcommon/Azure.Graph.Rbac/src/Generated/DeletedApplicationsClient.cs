// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Graph.Rbac.Models;

namespace Azure.Graph.Rbac
{
    /// <summary> The DeletedApplications service client. </summary>
    public partial class DeletedApplicationsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DeletedApplicationsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of DeletedApplicationsClient for mocking. </summary>
        protected DeletedApplicationsClient()
        {
        }
        /// <summary> Initializes a new instance of DeletedApplicationsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tenantID"> The tenant ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal DeletedApplicationsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string tenantID, Uri endpoint = null, string apiVersion = "1.6")
        {
            RestClient = new DeletedApplicationsRestClient(clientDiagnostics, pipeline, tenantID, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Restores the deleted application in the directory. </summary>
        /// <param name="objectId"> Application object ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Application>> RestoreAsync(string objectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.Restore");
            scope.Start();
            try
            {
                return await RestClient.RestoreAsync(objectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Restores the deleted application in the directory. </summary>
        /// <param name="objectId"> Application object ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Application> Restore(string objectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.Restore");
            scope.Start();
            try
            {
                return RestClient.Restore(objectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Hard-delete an application. </summary>
        /// <param name="applicationObjectId"> Application object ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> HardDeleteAsync(string applicationObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.HardDelete");
            scope.Start();
            try
            {
                return await RestClient.HardDeleteAsync(applicationObjectId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Hard-delete an application. </summary>
        /// <param name="applicationObjectId"> Application object ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response HardDelete(string applicationObjectId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.HardDelete");
            scope.Start();
            try
            {
                return RestClient.HardDelete(applicationObjectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of deleted applications in the directory. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Application> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Application>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(filter, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Application>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of deleted applications in the directory. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Application> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<Application> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(filter, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Application> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of deleted applications in the directory. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Application> ListNextAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            async Task<Page<Application>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.ListNext");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Application>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.ListNext");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of deleted applications in the directory. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Application> ListNext(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Page<Application> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.ListNext");
                scope.Start();
                try
                {
                    var response = RestClient.ListNext(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Application> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeletedApplicationsClient.ListNext");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
