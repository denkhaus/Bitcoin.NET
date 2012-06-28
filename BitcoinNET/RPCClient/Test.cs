using System;
using System.Net;


namespace BitcoinNET.RPCClient
{
	class Test
	{
		static void Main(string[] args)
		{
			BitcoinRPC b = new BitcoinRPC(new Uri("http://10.1.1.224:8332"), new NetworkCredential("rpcuser1", "rpcpass1"));

			var r = b.ListTransactions();

			Console.WriteLine(r);


			Console.ReadLine();
		}
	}
}
