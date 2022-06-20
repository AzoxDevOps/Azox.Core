namespace Azox.Core.Extensions
{
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public static bool IsNullOrEmpty(this string str) =>
            string.IsNullOrEmpty(str);

        /// <summary>
        /// 
        /// </summary>
        public static byte[] ToByteArrayASCII(this string str) =>
            Encoding.ASCII.GetBytes(str);

        /// <summary>
        /// 
        /// </summary>
        public static byte[] ToByteArrayUTF8(this string str) =>
            Encoding.UTF8.GetBytes(str);
    }
}
