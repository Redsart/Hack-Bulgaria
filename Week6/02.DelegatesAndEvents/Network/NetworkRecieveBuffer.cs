using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    class NetworkRecieveBuffer
    {
        static void Main(string[] args)
        {
            string message = "# Hack Bulgaria #";
            ReceiveBuffer buffer = new ReceiveBuffer();

            // Attach method as a listener
            buffer.MessageReceived += OnMessageRecived;
            
            // Add byte data to buffer
            buffer.BytesReceived(PacketGenerator.ConvertToByteArray(message));
            
            string anotherMessage = "Programming is awesome!";
            // Add new byte data to buffer
            buffer.BytesReceived(PacketGenerator.ConvertToByteArray(anotherMessage));
        }

        private static void OnMessageRecived(object sender, MessageArgs ev) 
        {
            Console.WriteLine(ev.GetMessage);
        }
    }
}
