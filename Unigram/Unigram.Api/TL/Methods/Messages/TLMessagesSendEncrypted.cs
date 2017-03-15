// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.sendEncrypted.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesSentEncryptedMessage"/>
	/// </summary>
	public partial class TLMessagesSendEncrypted : TLObject
	{
		public TLInputEncryptedChat Peer { get; set; }
		public Int64 RandomId { get; set; }
		public Byte[] Data { get; set; }

		public TLMessagesSendEncrypted() { }
		public TLMessagesSendEncrypted(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSendEncrypted; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputEncryptedChat>(from);
			RandomId = from.ReadInt64();
			Data = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA9776773);
			to.WriteObject(Peer);
			to.Write(RandomId);
			to.WriteByteArray(Data);
		}
	}
}