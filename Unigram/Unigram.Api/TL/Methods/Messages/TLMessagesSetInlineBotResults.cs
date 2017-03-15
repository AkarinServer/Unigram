// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.setInlineBotResults.
	/// Returns <see cref="Telegram.Api.TL.TLBoolBase"/>
	/// </summary>
	public partial class TLMessagesSetInlineBotResults : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Gallery = (1 << 0),
			Private = (1 << 1),
			NextOffset = (1 << 2),
			SwitchPm = (1 << 3),
		}

		public bool IsGallery { get { return Flags.HasFlag(Flag.Gallery); } set { Flags = value ? (Flags | Flag.Gallery) : (Flags & ~Flag.Gallery); } }
		public bool IsPrivate { get { return Flags.HasFlag(Flag.Private); } set { Flags = value ? (Flags | Flag.Private) : (Flags & ~Flag.Private); } }
		public bool HasNextOffset { get { return Flags.HasFlag(Flag.NextOffset); } set { Flags = value ? (Flags | Flag.NextOffset) : (Flags & ~Flag.NextOffset); } }
		public bool HasSwitchPm { get { return Flags.HasFlag(Flag.SwitchPm); } set { Flags = value ? (Flags | Flag.SwitchPm) : (Flags & ~Flag.SwitchPm); } }

		public Flag Flags { get; set; }
		public Int64 QueryId { get; set; }
		public TLVector<TLInputBotInlineResultBase> Results { get; set; }
		public Int32 CacheTime { get; set; }
		public String NextOffset { get; set; }
		public TLInlineBotSwitchPM SwitchPm { get; set; }

		public TLMessagesSetInlineBotResults() { }
		public TLMessagesSetInlineBotResults(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSetInlineBotResults; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			QueryId = from.ReadInt64();
			Results = TLFactory.Read<TLVector<TLInputBotInlineResultBase>>(from);
			CacheTime = from.ReadInt32();
			if (HasNextOffset) NextOffset = from.ReadString();
			if (HasSwitchPm) SwitchPm = TLFactory.Read<TLInlineBotSwitchPM>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xEB5EA206);
			to.Write((Int32)Flags);
			to.Write(QueryId);
			to.WriteObject(Results);
			to.Write(CacheTime);
			if (HasNextOffset) to.Write(NextOffset);
			if (HasSwitchPm) to.WriteObject(SwitchPm);
		}

		private void UpdateFlags()
		{
			HasNextOffset = NextOffset != null;
			HasSwitchPm = SwitchPm != null;
		}
	}
}