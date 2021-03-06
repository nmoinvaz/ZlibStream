// Copyright (c) Six Labors and contributors.
// See LICENSE for more details.

namespace SixLabors.ZlibStream
{
    /// <summary>
    /// Provides enumeration of flushing strategies for Zlib.
    /// </summary>
    public enum ZlibFlushStrategy
    {
        /// <summary>
        /// No flush.
        /// </summary>
        ZNOFLUSH,

        /// <summary>
        /// Partial flush.
        /// </summary>
        ZPARTIALFLUSH,

        /// <summary>
        /// Sync flush.
        /// </summary>
        ZSYNCFLUSH,

        /// <summary>
        /// Full flush.
        /// </summary>
        ZFULLFLUSH,

        /// <summary>
        /// Finish compression or decompression.
        /// </summary>
        ZFINISH,
    }
}
