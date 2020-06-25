// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Nozomi.net
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubComputeService.
    /// </summary>
    public static partial class SubComputeExtensions
    {
            /// <summary>
            /// Obtains all of the relevant Sub Computes you own.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results of every x items.
            /// </param>
            public static object GET(this ISubCompute operations, int index)
            {
                return operations.GETAsync(index).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtains all of the relevant Sub Computes you own.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results of every x items.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GETAsync(this ISubCompute operations, int index, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GETWithHttpMessagesAsync(index, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Obtains all of the relevant child computes the parent compute has.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parentComputeGuid'>
            /// The parent compute that has these computes as its child.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results of every x items.
            /// </param>
            public static object GET1(this ISubCompute operations, string parentComputeGuid, int? index = 0)
            {
                return operations.GET1Async(parentComputeGuid, index).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtains all of the relevant child computes the parent compute has.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parentComputeGuid'>
            /// The parent compute that has these computes as its child.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results of every x items.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GET1Async(this ISubCompute operations, string parentComputeGuid, int? index = 0, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GET1WithHttpMessagesAsync(parentComputeGuid, index, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Obtains all of the relevant parent computes the child compute has.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='childComputeGuid'>
            /// The child compute that has these computes as its parent.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results of every x items.
            /// </param>
            public static object GET2(this ISubCompute operations, string childComputeGuid, int? index = 0)
            {
                return operations.GET2Async(childComputeGuid, index).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtains all of the relevant parent computes the child compute has.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='childComputeGuid'>
            /// The child compute that has these computes as its parent.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results of every x items.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GET2Async(this ISubCompute operations, string childComputeGuid, int? index = 0, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GET2WithHttpMessagesAsync(childComputeGuid, index, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Obtains the specific sub compute.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parentComputeGuid'>
            /// The parent compute key.
            /// </param>
            /// <param name='childComputeGuid'>
            /// The child compute key.
            /// </param>
            public static object GET3(this ISubCompute operations, string parentComputeGuid = default(string), string childComputeGuid = default(string))
            {
                return operations.GET3Async(parentComputeGuid, childComputeGuid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtains the specific sub compute.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parentComputeGuid'>
            /// The parent compute key.
            /// </param>
            /// <param name='childComputeGuid'>
            /// The child compute key.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GET3Async(this ISubCompute operations, string parentComputeGuid = default(string), string childComputeGuid = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GET3WithHttpMessagesAsync(parentComputeGuid, childComputeGuid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
