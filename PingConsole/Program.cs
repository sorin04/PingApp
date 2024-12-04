using System.Net.NetworkInformation;

namespace PingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //
            do
            {
                Console.Write("Entrez une adresse IP : ");
                string saisie = Console.ReadLine();
                if (String.IsNullOrEmpty(saisie))
                { 
                    break; 
                }
                if ( TestIPAddress( saisie ) )
                {
                    PingMe(saisie);
                }
;
            } while (true);
        }

        private static bool TestIPAddress(string saisie)
        {
            // Test adresse avec RegEx

            return true;
        }

        static void PingMe(string toTest)
        {
            Ping pingSender = new Ping();
            try
            {
                PingReply reply = pingSender.Send(toTest);
                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine($"Temps de réponse : {reply.RoundtripTime} ms");
                }
                else
                {
                    Console.WriteLine($"Ping échoué : {reply.Status}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}
