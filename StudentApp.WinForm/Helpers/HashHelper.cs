using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.WinForm.Helpers
{
    public class HashHelper
    {
        public string HashString(string text)
        {
            var sha = new System.Security.Cryptography.SHA256Managed();
            var textBytes = Encoding.UTF8.GetBytes(text);
            var hashedBytes = sha.ComputeHash(textBytes);
            string hash=BitConverter.ToString(hashedBytes);
            return hash.Replace("-",string.Empty);
        }
    }
}
