//=================================
// CoopyRight (c) Tarteeb LLC
// Powering True Leadership
//=================================

namespace Tarteeb.Importer.Brokers.Loggings
{
    internal class LoggingBroker
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
    }
}
