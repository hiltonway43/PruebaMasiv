using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMasiv
{
    public class ClientCredential
    {
        public string User { get; set; }
        public string Password { get; set; }

       public ClientCredential Validate(int Entity)
        {

            ClientCredential clientCredential = new ClientCredential();

            switch (Entity)
            {

                case 1:
                    clientCredential.User = "A1";
                    clientCredential.Password = "B1";
                    break;

                case 2:
                    clientCredential.User = "A2";
                    clientCredential.Password = "B2";
                    break;

                default:
                    clientCredential.User = string.Empty;
                    clientCredential.Password = string.Empty;
                    break;

            }
            return clientCredential;

        }
    }

    
}
