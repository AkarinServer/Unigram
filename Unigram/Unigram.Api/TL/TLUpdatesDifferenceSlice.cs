// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdatesDifferenceSlice : TLUpdatesDifferenceBase 
	{
		public TLUpdatesState IntermediateState { get; set; }

		public TLUpdatesDifferenceSlice() { }
		public TLUpdatesDifferenceSlice(TLBinaryReader from, TLType type = TLType.UpdatesDifferenceSlice)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdatesDifferenceSlice; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdatesDifferenceSlice)
		{
			NewMessages = TLFactory.Read<TLVector<TLMessageBase>>(from);
			NewEncryptedMessages = TLFactory.Read<TLVector<TLEncryptedMessageBase>>(from);
			OtherUpdates = TLFactory.Read<TLVector<TLUpdateBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
			IntermediateState = TLFactory.Read<TLUpdatesState>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA8FB1981);
			to.WriteObject(NewMessages);
			to.WriteObject(NewEncryptedMessages);
			to.WriteObject(OtherUpdates);
			to.WriteObject(Chats);
			to.WriteObject(Users);
			to.WriteObject(IntermediateState);
		}
	}
}