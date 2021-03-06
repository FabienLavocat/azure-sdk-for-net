// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearningCompute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearningCompute;
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with ErrorResponseWrapper
    /// information.
    /// </summary>
    public class ErrorResponseWrapperException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public ErrorResponseWrapper Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseWrapperException class.
        /// </summary>
        public ErrorResponseWrapperException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseWrapperException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorResponseWrapperException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseWrapperException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ErrorResponseWrapperException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
