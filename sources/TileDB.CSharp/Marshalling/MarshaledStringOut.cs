using System;
using System.Runtime.InteropServices;
using System.Text;
using TileDB.CSharp;

namespace TileDB.Interop
{
    internal static class MarshaledStringOut
    {
        /// <summary>
        /// Encodes a read-only span of bytes into a string, using the default encoding.
        /// </summary>
        public static string GetString(ReadOnlySpan<byte> span) =>
            Encoding.ASCII.GetString(span);

        public static string GetString(ReadOnlySpan<byte> span, DataType dataType) =>
            dataType switch
            {
                DataType.StringAscii => Encoding.ASCII.GetString(span),
                DataType.StringUtf8 => Encoding.UTF8.GetString(span),
                DataType.StringUtf16 => Encoding.Unicode.GetString(span),
                DataType.StringUtf32=> Encoding.UTF32.GetString(span),
                _ => throw new ArgumentOutOfRangeException(nameof(dataType), dataType, "Unsupported string data type.")
            };

        /// <summary>
        /// Encodes a null-terminated pointer of bytes into a string, using the default encoding.
        /// </summary>
        public static unsafe string GetStringFromNullTerminated(sbyte* ptr)
        {
            var span = MemoryMarshalCompat.CreateReadOnlySpanFromNullTerminated((byte*)ptr);
            return GetString(span);
        }
    }
}
