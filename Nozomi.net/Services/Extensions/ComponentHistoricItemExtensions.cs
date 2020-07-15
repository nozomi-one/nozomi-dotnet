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
    /// Extension methods for ComponentHistoricItemService.
    /// </summary>
    public static partial class ComponentHistoricItemExtensions
    {
            /// <summary>
            /// Obtain all the component historical values created
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='componentGuid'>
            /// The unique identifier of the component.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results in 100s.
            /// </param>
            public static object All(this IComponentHistoricItemService operations, string componentGuid, int? index = 0)
            {
                return AllAsync(operations, componentGuid, index).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtain all the component historical values created
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='componentGuid'>
            /// The unique identifier of the component.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results in 100s.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AllAsync(this IComponentHistoricItemService operations, 
                string componentGuid, int? index = 0, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations
                    .AllAsync(componentGuid, index, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
