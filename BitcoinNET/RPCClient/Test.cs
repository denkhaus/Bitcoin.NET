using System;
using System.Net;

namespace BitcoinNET.RPCClient
{
	class Test
	{
		static void Main(string[] args)
		{
			BatchRPC r = new BatchRPC(new Uri("http://10.1.1.224:8332"), new NetworkCredential("rpcuser1", "rpcpass1"));

			uint _tx = r.ListTransactions();
			uint _bal = r.GetBalance();
			uint _blk = r.GetBlockCount();

			r.DoRequest();

			var tx = r.GetResult<IEnumerable<ListTransactionsResponse>>(_tx);

			Console.WriteLine(tx);


			Console.ReadLine();
		}
	}
}
