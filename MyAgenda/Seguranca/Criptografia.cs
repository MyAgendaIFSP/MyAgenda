using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyAgenda.Seguranca
{
    class Criptografia
    {

        public string GeraSalt()
        {
            RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();
            byte[] cypher = new byte[32];
            r.GetNonZeroBytes(cypher);

            //return Encoding.UTF8.GetString(cypher);
            return Convert.ToBase64String(cypher);
        }

        public string GetHashSenha(string rawText, string salt)
        {
            Rfc2898DeriveBytes hasher = new Rfc2898DeriveBytes(rawText, Encoding.UTF8.GetBytes(salt));
            //return hash;
            return Convert.ToBase64String(hasher.GetBytes(32));
        }

        public bool VerificaSenha(string cypherText, string rawText, string salt)
        {
            string hash = GetHashSenha(rawText, salt);
            return cypherText.Equals(hash);
        }

    }
}
