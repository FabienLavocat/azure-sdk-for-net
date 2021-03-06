// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobOperations.
    /// </summary>
    public static partial class JobOperationsExtensions
    {
            /// <summary>
            /// Gets statistics of the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// Job Information ID.
            /// </param>
            public static JobStatistics GetStatistics(this IJobOperations operations, string accountName, System.Guid jobIdentity)
            {
                return operations.GetStatisticsAsync(accountName, jobIdentity).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets statistics of the specified job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// Job Information ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobStatistics> GetStatisticsAsync(this IJobOperations operations, string accountName, System.Guid jobIdentity, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatisticsWithHttpMessagesAsync(accountName, jobIdentity, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the job debug data information specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            public static JobDataPath GetDebugDataPath(this IJobOperations operations, string accountName, System.Guid jobIdentity)
            {
                return operations.GetDebugDataPathAsync(accountName, jobIdentity).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the job debug data information specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobDataPath> GetDebugDataPathAsync(this IJobOperations operations, string accountName, System.Guid jobIdentity, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDebugDataPathWithHttpMessagesAsync(accountName, jobIdentity, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Builds (compiles) the specified job in the specified Data Lake Analytics
            /// account for job correctness and validation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to build a job.
            /// </param>
            public static JobInformation Build(this IJobOperations operations, string accountName, BuildJobParameters parameters)
            {
                return operations.BuildAsync(accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Builds (compiles) the specified job in the specified Data Lake Analytics
            /// account for job correctness and validation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to build a job.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobInformation> BuildAsync(this IJobOperations operations, string accountName, BuildJobParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BuildWithHttpMessagesAsync(accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels the running job specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID to cancel.
            /// </param>
            public static void Cancel(this IJobOperations operations, string accountName, System.Guid jobIdentity)
            {
                operations.CancelAsync(accountName, jobIdentity).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels the running job specified by the job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID to cancel.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CancelAsync(this IJobOperations operations, string accountName, System.Guid jobIdentity, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelWithHttpMessagesAsync(accountName, jobIdentity, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Submits a job to the specified Data Lake Analytics account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// The job ID (a GUID) for the job being submitted.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to submit a job.
            /// </param>
            public static JobInformation Create(this IJobOperations operations, string accountName, System.Guid jobIdentity, CreateJobParameters parameters)
            {
                return operations.CreateAsync(accountName, jobIdentity, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits a job to the specified Data Lake Analytics account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// The job ID (a GUID) for the job being submitted.
            /// </param>
            /// <param name='parameters'>
            /// The parameters to submit a job.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobInformation> CreateAsync(this IJobOperations operations, string accountName, System.Guid jobIdentity, CreateJobParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(accountName, jobIdentity, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the job information for the specified job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            public static JobInformation Get(this IJobOperations operations, string accountName, System.Guid jobIdentity)
            {
                return operations.GetAsync(accountName, jobIdentity).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the job information for the specified job ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='jobIdentity'>
            /// JobInfo ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobInformation> GetAsync(this IJobOperations operations, string accountName, System.Guid jobIdentity, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(accountName, jobIdentity, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the jobs, if any, associated with the specified Data Lake Analytics
            /// account. The response includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            public static IPage<JobInformationBasic> List(this IJobOperations operations, string accountName, ODataQuery<JobInformation> odataQuery = default(ODataQuery<JobInformation>), string select = default(string), bool? count = default(bool?))
            {
                return ((IJobOperations)operations).ListAsync(accountName, odataQuery, select, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the jobs, if any, associated with the specified Data Lake Analytics
            /// account. The response includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accountName'>
            /// The Azure Data Lake Analytics account to execute job operations on.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// OData Select statement. Limits the properties on each entry to just those
            /// requested, e.g. Categories?$select=CategoryName,Description. Optional.
            /// </param>
            /// <param name='count'>
            /// The Boolean value of true or false to request a count of the matching
            /// resources included with the resources in the response, e.g.
            /// Categories?$count=true. Optional.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobInformationBasic>> ListAsync(this IJobOperations operations, string accountName, ODataQuery<JobInformation> odataQuery = default(ODataQuery<JobInformation>), string select = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(accountName, odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the jobs, if any, associated with the specified Data Lake Analytics
            /// account. The response includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobInformationBasic> ListNext(this IJobOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the jobs, if any, associated with the specified Data Lake Analytics
            /// account. The response includes a link to the next page of results, if any.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobInformationBasic>> ListNextAsync(this IJobOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
