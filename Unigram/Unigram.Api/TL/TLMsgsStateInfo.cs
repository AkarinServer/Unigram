// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMsgsStateInfo : TLObject 
	{
		public Int64 ReqMsgId { get; set; }
		public String Info { get; set; }

		public TLMsgsStateInfo() { }
		public TLMsgsStateInfo(TLBinaryReader from, TLType type = TLType.MsgsStateInfo)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.MsgsStateInfo; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.MsgsStateInfo)
		{
			ReqMsgId = from.ReadInt64();
			Info = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x04DEB57D);
			to.Write(ReqMsgId);
			to.Write(Info);
		}
	}
}