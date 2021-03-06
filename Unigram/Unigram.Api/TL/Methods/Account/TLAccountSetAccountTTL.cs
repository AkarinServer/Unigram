// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.setAccountTTL.
	/// Returns <see cref="Telegram.Api.TL.TLBoolBase"/>
	/// </summary>
	public partial class TLAccountSetAccountTTL : TLObject
	{
		public TLAccountDaysTTL TTL { get; set; }

		public TLAccountSetAccountTTL() { }
		public TLAccountSetAccountTTL(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountSetAccountTTL; } }

		public override void Read(TLBinaryReader from)
		{
			TTL = TLFactory.Read<TLAccountDaysTTL>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2442485E);
			to.WriteObject(TTL);
		}
	}
}