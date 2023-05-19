using System.Runtime.CompilerServices;

namespace fil_rouge_api.Extensions
{
    public static class MyStringExtensions
    {
        public static string Capitalize(this string message)
        {
            return message[0].ToString().ToUpper() + message.Substring(1);
        }
    }
}
