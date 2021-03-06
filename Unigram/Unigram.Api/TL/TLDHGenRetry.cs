// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDHGenRetry : TLSetClientDHParamsAnswerBase 
	{
		public TLInt128 NewNonceHash2 { get; set; }

		public TLDHGenRetry() { }
		public TLDHGenRetry(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.DHGenRetry; } }

		public override void Read(TLBinaryReader from)
		{
			Nonce = new TLInt128(from);
			ServerNonce = new TLInt128(from);
			NewNonceHash2 = new TLInt128(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x46DC1FB9);
			to.WriteObject(Nonce);
			to.WriteObject(ServerNonce);
			to.WriteObject(NewNonceHash2);
		}
	}
}