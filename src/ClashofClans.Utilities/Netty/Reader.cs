using System.Text;
using ClashofClans.Utilities.Compression.ZLib;
using DotNetty.Buffers;

namespace ClashofClans.Utilities.Netty
{
    /// <summary>
    ///     This implements a few extensions for games from Supercell
    /// </summary>
    public static class Reader
    {
        /// <summary>
        ///     Decodes a string based on the length
        /// </summary>
        /// <param name="byteBuffer"></param>
        /// <returns></returns>
        public static string ReadScString(this IByteBuffer byteBuffer)
        {
            var length = byteBuffer.ReadInt();

            if (length <= 0 || length > 900000)
                return string.Empty;

            return byteBuffer.ReadString(length, Encoding.UTF8);
        }

        /// <summary>
        /// Decodes a compressed string
        /// </summary>
        /// <param name="byteBuffer"></param>
        /// <param name="indicator"></param>
        /// <returns></returns>
        public static string ReadCompressedString(this IByteBuffer byteBuffer, bool indicator = true)
        {
            if(indicator)
                byteBuffer.ReadByte();

            var compressedLength = byteBuffer.ReadInt() - 4;
            byteBuffer.ReadIntLE();

            var compressedBytes = byteBuffer.ReadBytes(compressedLength);

            return ZlibStream.UncompressString(compressedBytes.Array);
        }
    }
}