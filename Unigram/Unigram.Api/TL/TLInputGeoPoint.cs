// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputGeoPoint : TLInputGeoPointBase 
	{
		public Double Lat { get; set; }
		public Double Long { get; set; }

		public TLInputGeoPoint() { }
		public TLInputGeoPoint(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputGeoPoint; } }

		public override void Read(TLBinaryReader from)
		{
			Lat = from.ReadDouble();
			Long = from.ReadDouble();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF3B7ACC9);
			to.Write(Lat);
			to.Write(Long);
		}
	}
}