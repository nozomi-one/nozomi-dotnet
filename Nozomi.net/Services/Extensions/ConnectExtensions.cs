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
    /// Extension methods for ConnectService.
    /// </summary>
    public static partial class ConnectExtensions
    {
            /// <summary>
            /// Allows the client to validate his API key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string Validate(this IConnectService operations)
            {
                return ValidateAsync(operations).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Allows the client to validate his API key.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ValidateAsync(this IConnectService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateAsync(cancellationToken)
                    .ConfigureAwait(false))
                    return _result.Body;
            }

    }
}
