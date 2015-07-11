namespace Fixtures.SwaggerBatBodyFile
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class FilesExtensions
    {
            /// <summary>
            /// Get file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static System.IO.Stream GetFile(this IFiles operations)
            {
                return Task.Factory.StartNew(s => ((IFiles)s).GetFileAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<System.IO.Stream> GetFileAsync( this IFiles operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<System.IO.Stream> result = await operations.GetFileWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Get empty file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static System.IO.Stream GetEmptyFile(this IFiles operations)
            {
                return Task.Factory.StartNew(s => ((IFiles)s).GetEmptyFileAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<System.IO.Stream> GetEmptyFileAsync( this IFiles operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<System.IO.Stream> result = await operations.GetEmptyFileWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}