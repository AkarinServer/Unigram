// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLConfig : TLObject 
	{
		public Int32 Date { get; set; }
		public Int32 Expires { get; set; }
		public Boolean TestMode { get; set; }
		public Int32 ThisDC { get; set; }
		public TLVector<TLDCOption> DCOptions { get; set; }
		public Int32 ChatSizeMax { get; set; }
		public Int32 MegagroupSizeMax { get; set; }
		public Int32 ForwardedCountMax { get; set; }
		public Int32 OnlineUpdatePeriodMs { get; set; }
		public Int32 OfflineBlurTimeoutMs { get; set; }
		public Int32 OfflineIdleTimeoutMs { get; set; }
		public Int32 OnlineCloudTimeoutMs { get; set; }
		public Int32 NotifyCloudDelayMs { get; set; }
		public Int32 NotifyDefaultDelayMs { get; set; }
		public Int32 ChatBigSize { get; set; }
		public Int32 PushChatPeriodMs { get; set; }
		public Int32 PushChatLimit { get; set; }
		public Int32 SavedGifsLimit { get; set; }
		public Int32 EditTimeLimit { get; set; }
		public Int32 RatingEDecay { get; set; }
		public TLVector<TLDisabledFeature> DisabledFeatures { get; set; }

		public TLConfig() { }
		public TLConfig(TLBinaryReader from, TLType type = TLType.Config)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.Config; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.Config)
		{
			Date = from.ReadInt32();
			Expires = from.ReadInt32();
			TestMode = from.ReadBoolean();
			ThisDC = from.ReadInt32();
			DCOptions = TLFactory.Read<TLVector<TLDCOption>>(from);
			ChatSizeMax = from.ReadInt32();
			MegagroupSizeMax = from.ReadInt32();
			ForwardedCountMax = from.ReadInt32();
			OnlineUpdatePeriodMs = from.ReadInt32();
			OfflineBlurTimeoutMs = from.ReadInt32();
			OfflineIdleTimeoutMs = from.ReadInt32();
			OnlineCloudTimeoutMs = from.ReadInt32();
			NotifyCloudDelayMs = from.ReadInt32();
			NotifyDefaultDelayMs = from.ReadInt32();
			ChatBigSize = from.ReadInt32();
			PushChatPeriodMs = from.ReadInt32();
			PushChatLimit = from.ReadInt32();
			SavedGifsLimit = from.ReadInt32();
			EditTimeLimit = from.ReadInt32();
			RatingEDecay = from.ReadInt32();
			DisabledFeatures = TLFactory.Read<TLVector<TLDisabledFeature>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC9411388);
			to.Write(Date);
			to.Write(Expires);
			to.Write(TestMode);
			to.Write(ThisDC);
			to.WriteObject(DCOptions);
			to.Write(ChatSizeMax);
			to.Write(MegagroupSizeMax);
			to.Write(ForwardedCountMax);
			to.Write(OnlineUpdatePeriodMs);
			to.Write(OfflineBlurTimeoutMs);
			to.Write(OfflineIdleTimeoutMs);
			to.Write(OnlineCloudTimeoutMs);
			to.Write(NotifyCloudDelayMs);
			to.Write(NotifyDefaultDelayMs);
			to.Write(ChatBigSize);
			to.Write(PushChatPeriodMs);
			to.Write(PushChatLimit);
			to.Write(SavedGifsLimit);
			to.Write(EditTimeLimit);
			to.Write(RatingEDecay);
			to.WriteObject(DisabledFeatures);
		}
	}
}