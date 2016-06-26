// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateContactLink : TLUpdateBase 
	{
		public TLContactLinkBase MyLink { get; set; }
		public TLContactLinkBase ForeignLink { get; set; }

		public TLUpdateContactLink() { }
		public TLUpdateContactLink(TLBinaryReader from, TLType type = TLType.UpdateContactLink)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateContactLink; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateContactLink)
		{
			UserId = from.ReadInt32();
			MyLink = TLFactory.Read<TLContactLinkBase>(from);
			ForeignLink = TLFactory.Read<TLContactLinkBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9D2E67C5);
			to.Write(UserId);
			to.WriteObject(MyLink);
			to.WriteObject(ForeignLink);
		}
	}
}