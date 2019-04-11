// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BastionHostsOperations.
    /// </summary>
    public static partial class BastionHostsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            public static void Delete(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName)
            {
                operations.DeleteAsync(resourceGroupName, bastionHostName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, bastionHostName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            public static BastionHost Get(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName)
            {
                return operations.GetAsync(resourceGroupName, bastionHostName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BastionHost> GetAsync(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, bastionHostName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Bastion Host operation.
            /// </param>
            public static BastionHost CreateOrUpdate(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName, BastionHost parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, bastionHostName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Bastion Host operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BastionHost> CreateOrUpdateAsync(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName, BastionHost parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, bastionHostName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Bastion Hosts in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<BastionHost> List(this IBastionHostsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Bastion Hosts in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BastionHost>> ListAsync(this IBastionHostsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Bastion Host associated with a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            public static IPage<BastionHostIPConfiguration> ListVnet(this IBastionHostsOperations operations, string resourceGroupName, string virtualNetworkName)
            {
                return operations.ListVnetAsync(resourceGroupName, virtualNetworkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Bastion Host associated with a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BastionHostIPConfiguration>> ListVnetAsync(this IBastionHostsOperations operations, string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVnetWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            public static void BeginDelete(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName)
            {
                operations.BeginDeleteAsync(resourceGroupName, bastionHostName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, bastionHostName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Bastion Host operation.
            /// </param>
            public static BastionHost BeginCreateOrUpdate(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName, BastionHost parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, bastionHostName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Bastion Host.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='bastionHostName'>
            /// The name of the Bastion Host.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Bastion Host operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BastionHost> BeginCreateOrUpdateAsync(this IBastionHostsOperations operations, string resourceGroupName, string bastionHostName, BastionHost parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, bastionHostName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Bastion Hosts in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BastionHost> ListNext(this IBastionHostsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Bastion Hosts in a resource group.
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
            public static async Task<IPage<BastionHost>> ListNextAsync(this IBastionHostsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Bastion Host associated with a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BastionHostIPConfiguration> ListVnetNext(this IBastionHostsOperations operations, string nextPageLink)
            {
                return operations.ListVnetNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Bastion Host associated with a virtual network.
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
            public static async Task<IPage<BastionHostIPConfiguration>> ListVnetNextAsync(this IBastionHostsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListVnetNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
