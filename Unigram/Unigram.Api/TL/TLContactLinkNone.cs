// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLContactLinkNone : TLContactLinkBase 
	{
		public TLContactLinkNone() { }
		public TLContactLinkNone(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactLinkNone; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xFEEDD3AD);
		}
	}
}