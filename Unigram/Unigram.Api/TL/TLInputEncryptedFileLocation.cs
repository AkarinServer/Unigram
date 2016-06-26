// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputEncryptedFileLocation : TLInputFileLocationBase 
	{

		public TLInputEncryptedFileLocation() { }
		public TLInputEncryptedFileLocation(TLBinaryReader from, TLType type = TLType.InputEncryptedFileLocation)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InputEncryptedFileLocation; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InputEncryptedFileLocation)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF5235D55);
			to.Write(Id);
			to.Write(AccessHash);
		}
	}
}