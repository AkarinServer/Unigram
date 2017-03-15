// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.unblock.
	/// Returns <see cref="Telegram.Api.TL.TLBoolBase"/>
	/// </summary>
	public partial class TLContactsUnblock : TLObject
	{
		public TLInputUserBase Id { get; set; }

		public TLContactsUnblock() { }
		public TLContactsUnblock(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsUnblock; } }

		public override void Read(TLBinaryReader from)
		{
			Id = TLFactory.Read<TLInputUserBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE54100BD);
			to.WriteObject(Id);
		}
	}
}