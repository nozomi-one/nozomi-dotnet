// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Threading;
using System.Threading.Tasks;

namespace Nozomi.net.Services.Extensions
{
    /// <summary>
    /// Extension methods for WebsocketCommandPropertyService.
    /// </summary>
    public static partial class WebsocketCommandPropertyExtensions
    {
            /// <summary>
            /// Retrieves all websocket command properties owned by the stated user with a
            /// pagination of
            /// 1000 items.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list you are viewing, in 1000s.
            /// </param>
            public static object GET(this IWebsocketCommandProperty operations, int? index = 0)
            {
                return operations.GETAsync(index).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves all websocket command properties owned by the stated user with a
            /// pagination of
            /// 1000 items.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list you are viewing, in 1000s.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GETAsync(this IWebsocketCommandProperty operations, int? index = 0, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GETWithHttpMessagesAsync(index, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves all websocket command properties relevant to its parent command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='commandGuid'>
            /// The unique identifier of the command.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list you are viewing, in 1000s.
            /// </param>
            public static object GET1(this IWebsocketCommandProperty operations, string commandGuid = default(string), int? index = 0)
            {
                return operations.GET1Async(commandGuid, index).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves all websocket command properties relevant to its parent command.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='commandGuid'>
            /// The unique identifier of the command.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list you are viewing, in 1000s.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GET1Async(this IWebsocketCommandProperty operations, string commandGuid = default(string), int? index = 0, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GET1WithHttpMessagesAsync(commandGuid, index, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
