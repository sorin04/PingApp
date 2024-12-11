using System;
using System.Net;

namespace PingApp
{
    internal class Calculipv4 : IPV4
    {
        public string Address { get; private set; }

        public Calculipv4(string address)
        {
            if (!ValidIP(address))
                throw new ArgumentException("L'adresse IP n'est pas valide.");
            Address = address;
        }

        private bool ValidIP(string address)
        {
            return IPAddress.TryParse(address, out _);
        }

        public IPV4 Increment(int value)
        {
            var octets = Address.Split('.').Select(int.Parse).ToArray();
            int numericAddress = (octets[0] << 24) + (octets[1] << 16) + (octets[2] << 8) + octets[3];
            numericAddress += value;

            if (numericAddress > 0xFFFFFFFF)
                throw new ArgumentOutOfRangeException("L'adresse IP générée dépasse la plage autorisée.");

            byte[] bytes = BitConverter.GetBytes(numericAddress);
            Array.Reverse(bytes); 
            return new Calculipv4(string.Join('.', bytes));
        }
    }
}
