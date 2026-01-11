using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharp14Demo
{
    public static class ExtensionExample
    {
        extension(string value)
        {
            /// <summary>
            ///  Remove special characters from a string.
            /// </summary>
            /// <returns></returns>
            public string RemoveSpecialCharacters()
            {               
                // Keep Unicode letters (\p{L}), numbers (\p{N}) and whitespace (\s).
                // Removes punctuation, symbols, and other special characters (including underscores).
                return Regex.Replace(value, @"[^\p{L}\p{N}\s]", string.Empty);
            }

            /// <summary>
            /// clip a string from a particular position
            /// </summary>
            /// <param name="startIndex"></param>
            /// <returns></returns>
            public string ClipStart(int startIndex)
            {
                if (string.IsNullOrEmpty(value) || value.Length <= startIndex)
                    return value;

                return value.Substring(startIndex);
            }
        }

        #region Old Legacy Extension method

        /// <summary>
        /// Old Legacy Extension method to remove special characters from a string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string LegacyRemoveSpecialCharacters(this string value)
        {
            // Keep Unicode letters (\p{L}), numbers (\p{N}) and whitespace (\s).
            // Removes punctuation, symbols, and other special characters (including underscores).
            return Regex.Replace(value, @"[^\p{L}\p{N}\s]", string.Empty);
        }

        /// <summary>
        /// Old Legacy Extension method to clip a string from the start.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public static string LegacyClipStart(this string value, int startIndex)
        {
            if (string.IsNullOrEmpty(value) || value.Length <= startIndex)
                return value;
            return value.Substring(startIndex);
        }
        #endregion
    }
}
