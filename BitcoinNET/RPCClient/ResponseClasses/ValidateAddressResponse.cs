﻿using System;

namespace BitcoinNET.RPCClient
{
	public class ValidateAddressResponse
	{
		public bool isvalid;
		public string address;
		public bool ismine;
		public string pubkey;
		public bool iscompressed;
		public string account;
	}
}
