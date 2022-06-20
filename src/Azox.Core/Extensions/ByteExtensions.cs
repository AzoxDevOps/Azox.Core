namespace Azox.Core.Extensions
{
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public static class ByteExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static string ToASCIIString(this byte[] source)=>
            Encoding.ASCII.GetString(source);

        /// <summary>
        /// 
        /// </summary>
        public static string ToHexString(this byte[] source)=>
            string.Join(string.Empty, source.Select(x => x.ToString("X2")));

        /// <summary>
        /// 
        /// </summary>
        public static string ToUTF8String(this byte[] source) =>
            Encoding.UTF8.GetString(source);
    }
}
