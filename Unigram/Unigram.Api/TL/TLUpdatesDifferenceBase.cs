// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public abstract partial class TLUpdatesDifferenceBase : TLObject
	{
		public TLVector<TLMessageBase> NewMessages { get; set; }
		public TLVector<TLEncryptedMessageBase> NewEncryptedMessages { get; set; }
		public TLVector<TLUpdateBase> OtherUpdates { get; set; }
		public TLVector<TLChatBase> Chats { get; set; }
		public TLVector<TLUserBase> Users { get; set; }
	}
}