using System.Text;

namespace fil_rouge_api.Services
{
    public static class PasswordService
    {
        private static readonly string _securityPasswordKey = "La puissance de la secret key";

        public static string EncryptPassword(string? password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + _securityPasswordKey));
        }

        public static string EncryptPassword(string? password, string? secretKey)
        {
            if (string.IsNullOrEmpty(password)) return "";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + secretKey));
        }

        private static string DecryptPassword(string? cryptedString)
        {
            if (string.IsNullOrEmpty(cryptedString)) return "";
            string decriptedString = Encoding.UTF8.GetString(Convert.FromBase64String(cryptedString));
            return decriptedString.Substring(0, decriptedString.Length - _securityPasswordKey.Length);
        }
    }
}
