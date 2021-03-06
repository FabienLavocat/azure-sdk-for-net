// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ClustersOperations.
    /// </summary>
    public static partial class ClustersOperationsExtensions
    {
            /// <summary>
            /// Update cluster configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='parameters'>
            /// The parameters which contains the property value and property name which
            /// used to update the cluster configuration
            /// </param>
            public static Cluster Update(this IClustersOperations operations, string resourceGroupName, string clusterName, ClusterUpdateParameters parameters)
            {
                return operations.UpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update cluster configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='parameters'>
            /// The parameters which contains the property value and property name which
            /// used to update the cluster configuration
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> UpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, ClusterUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            public static Cluster Get(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.GetAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> GetAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='parameters'>
            /// Put Request
            /// </param>
            public static Cluster Create(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.CreateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='parameters'>
            /// Put Request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> CreateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            public static void Delete(this IClustersOperations operations, string resourceGroupName, string clusterName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List cluster resource by resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            public static IPage<Cluster> ListByResourceGroup(this IClustersOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List cluster resource by resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Cluster>> ListByResourceGroupAsync(this IClustersOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Cluster> List(this IClustersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Cluster>> ListAsync(this IClustersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update cluster configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='parameters'>
            /// The parameters which contains the property value and property name which
            /// used to update the cluster configuration
            /// </param>
            public static Cluster BeginUpdate(this IClustersOperations operations, string resourceGroupName, string clusterName, ClusterUpdateParameters parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update cluster configuration
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='parameters'>
            /// The parameters which contains the property value and property name which
            /// used to update the cluster configuration
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> BeginUpdateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, ClusterUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='parameters'>
            /// Put Request
            /// </param>
            public static Cluster BeginCreate(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, clusterName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the resource belongs or get created
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster resource
            /// </param>
            /// <param name='parameters'>
            /// Put Request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Cluster> BeginCreateAsync(this IClustersOperations operations, string resourceGroupName, string clusterName, Cluster parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, clusterName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List cluster resource by resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Cluster> ListByResourceGroupNext(this IClustersOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List cluster resource by resource group
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
            public static async Task<IPage<Cluster>> ListByResourceGroupNextAsync(this IClustersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List cluster resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Cluster> ListNext(this IClustersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List cluster resource
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
            public static async Task<IPage<Cluster>> ListNextAsync(this IClustersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
