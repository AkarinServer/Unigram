// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.checkUsername.
	/// Returns <see cref="Telegram.Api.TL.TLBoolBase"/>
	/// </summary>
	public partial class TLAccountCheckUsername : TLObject
	{
		public String Username { get; set; }

		public TLAccountCheckUsername() { }
		public TLAccountCheckUsername(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountCheckUsername; } }

		public override void Read(TLBinaryReader from)
		{
			Username = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2714D86C);
			to.Write(Username);
		}
	}
}