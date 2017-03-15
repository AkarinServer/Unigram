// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPrivacyValueDisallowUsers : TLPrivacyRuleBase 
	{
		public TLVector<Int32> Users { get; set; }

		public TLPrivacyValueDisallowUsers() { }
		public TLPrivacyValueDisallowUsers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PrivacyValueDisallowUsers; } }

		public override void Read(TLBinaryReader from)
		{
			Users = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC7F49B7);
			to.WriteObject(Users);
		}
	}
}