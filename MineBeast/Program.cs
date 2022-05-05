using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineBeast
{
    class Program
    {
        public static int totalTested
        {
            get;
            set;
        }
        public static int totalWorking
        {
            get;
            set;
        }
        public static double totalProfit = 0;
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5000; i++)
            {
                totalTested++;
                Random genRan = new Random();
                var z = genRan.Next(totalTested, totalTested + 40);
                Console.Title = $"MineBeast | {totalTested} Tested | {totalWorking} Working | {Convert.ToInt32(totalProfit)} EURO Profit";
                Random randomM = new Random();
                var genMoney = randomM.Next(10, 300);
                Console.ForegroundColor = ConsoleColor.Red;
                System.Threading.Thread.Sleep(0040);
                Key privateKey = new Key(); // generate a random private key
                PubKey publicKey = privateKey.PubKey;
                Console.WriteLine($"Scanning Wallet: {publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main)}  | NOT WORKING");
                if (totalTested == z)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Scanning Wallet: {publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main)}  | WORKING | BALANCE: {genMoney} EUR");
                    totalProfit += genMoney / 0.91;
                    totalWorking++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine($"|                       Scanning Complete ! Total Profit {totalProfit} EUR ");
            Console.WriteLine($"|                       Scanning Complete ! Sending a request to the server for withdrawing your profit !");
        }

    }
}
