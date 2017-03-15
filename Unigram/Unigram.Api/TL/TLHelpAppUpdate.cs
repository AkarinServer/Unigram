// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLHelpAppUpdate : TLHelpAppUpdateBase 
	{
		public Int32 Id { get; set; }
		public Boolean Critical { get; set; }
		public String Url { get; set; }
		public String Text { get; set; }

		public TLHelpAppUpdate() { }
		public TLHelpAppUpdate(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.HelpAppUpdate; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
			Critical = from.ReadBoolean();
			Url = from.ReadString();
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8987F311);
			to.Write(Id);
			to.Write(Critical);
			to.Write(Url);
			to.Write(Text);
		}
	}
}