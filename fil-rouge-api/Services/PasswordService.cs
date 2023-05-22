using System.Text;

namespace fil_rouge_api.Services
{
    public static class PasswordService
    {
        public static string GetPassword(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + "La puissance de la secret key"));
        }
    }
}
