using System;

namespace PruebaMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite el numero asociado al usuario:");     
            int a = int.Parse(Console.ReadLine());
            ClientCredential client = new ClientCredential();
            Console.WriteLine("Usuario asignado {0} con Password {1}", client.Validate(a).User, client.Validate(a).Password);
           
        }

      
    }
    

}
