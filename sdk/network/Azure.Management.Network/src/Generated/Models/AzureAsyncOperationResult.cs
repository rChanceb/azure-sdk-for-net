// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> The response body contains the status of the specified asynchronous operation, indicating whether it has succeeded, is in progress, or has failed. Note that this status is distinct from the HTTP status code returned for the Get Operation Status operation itself. If the asynchronous operation succeeded, the response body includes the HTTP status code for the successful request. If the asynchronous operation failed, the response body includes the HTTP status code for the failed request and error information regarding the failure. </summary>
    internal partial class AzureAsyncOperationResult
    {
        /// <summary> Initializes a new instance of AzureAsyncOperationResult. </summary>
        internal AzureAsyncOperationResult()
        {
        }

        /// <summary> Initializes a new instance of AzureAsyncOperationResult. </summary>
        /// <param name="status"> Status of the Azure async operation. </param>
        /// <param name="error"> Details of the error occurred during specified asynchronous operation. </param>
        internal AzureAsyncOperationResult(NetworkOperationStatus? status, Error error)
        {
            Status = status;
            Error = error;
        }

        /// <summary> Status of the Azure async operation. </summary>
        public NetworkOperationStatus? Status { get; set; }
        /// <summary> Details of the error occurred during specified asynchronous operation. </summary>
        public Error Error { get; set; }
    }
}
