namespace RedisViewer.Extenders
{
    public static class StringExtenders
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsSpecified(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}