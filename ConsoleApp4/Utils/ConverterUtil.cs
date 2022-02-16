namespace ConsoleApp4.Utils
{
    /// <summary>
    /// This class converts data types
    /// </summary>
    public static class ConverterUtil
    {
        /// <summary>
        /// This method converts int in bool
        /// </summary>
        /// <param name="value">This method accepts int value</param>
        ///<returns>
        /// This method returns true if entered 1, or false in other cases
        /// </returns>
        public static bool ConvertToBool(int value) => value == 1;
    }
}