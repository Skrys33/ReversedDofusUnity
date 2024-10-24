using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations;

[Serializable]
[Token(Token = "0x2000011")]
internal sealed class Animation
{
	[Token(Token = "0x2000012")]
	[Flags]
	public enum guu : byte
	{
		[Token(Token = "0x400009E")]
		None = 0,
		[Token(Token = "0x400009F")]
		SpriteIndex = 1,
		[Token(Token = "0x40000A0")]
		SpriteOpacity = 2,
		[Token(Token = "0x40000A1")]
		SpriteColorMultiply = 4,
		[Token(Token = "0x40000A2")]
		SpriteColorAdditive = 8,
		[Token(Token = "0x40000A3")]
		Matrix = 0x10,
		[Token(Token = "0x40000A4")]
		CustomisationIndex = 0x20,
		[Token(Token = "0x40000A5")]
		Mask = 0x40,
		[Token(Token = "0x40000A6")]
		ExtendedFilterAndBlendModes = 0x80
	}

	[Token(Token = "0x2000013")]
	public enum guv : byte
	{
		[Token(Token = "0x40000A8")]
		None = 0,
		[Token(Token = "0x40000A9")]
		DropShadowFilter = 1,
		[Token(Token = "0x40000AA")]
		BlurFilter = 2,
		[Token(Token = "0x40000AB")]
		GlowFilter = 4,
		[Token(Token = "0x40000AC")]
		BevelFilter = 8,
		[Token(Token = "0x40000AD")]
		GradientGlowFilter = 0x10,
		[Token(Token = "0x40000AE")]
		ConvolutionFilter = 0x20,
		[Token(Token = "0x40000AF")]
		ColorMatrixFilter = 0x40,
		[Token(Token = "0x40000B0")]
		GradientBevelFilter = 0x80
	}

	[Token(Token = "0x2000014")]
	[Flags]
	public enum guw : byte
	{
		[Token(Token = "0x40000B2")]
		None = 0,
		[Token(Token = "0x40000B3")]
		SetMask = 1,
		[Token(Token = "0x40000B4")]
		ObeyMask = 2,
		[Token(Token = "0x40000B5")]
		ClearMask = 4
	}

	[Token(Token = "0x2000015")]
	public enum gux : byte
	{
		[Token(Token = "0x40000B7")]
		Normal,
		[Token(Token = "0x40000B8")]
		Normal_Alternative,
		[Token(Token = "0x40000B9")]
		Layer,
		[Token(Token = "0x40000BA")]
		Multiply,
		[Token(Token = "0x40000BB")]
		Screen,
		[Token(Token = "0x40000BC")]
		Lighten,
		[Token(Token = "0x40000BD")]
		Darken,
		[Token(Token = "0x40000BE")]
		Difference,
		[Token(Token = "0x40000BF")]
		Add,
		[Token(Token = "0x40000C0")]
		Subtract,
		[Token(Token = "0x40000C1")]
		Invert,
		[Token(Token = "0x40000C2")]
		Alpha,
		[Token(Token = "0x40000C3")]
		Erase,
		[Token(Token = "0x40000C4")]
		Overlay,
		[Token(Token = "0x40000C5")]
		Hardlight,
		[Token(Token = "0x40000C6")]
		PreMultiplied
	}

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string name;

	[NonSerialized]
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x18")]
	public readonly string boneId;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public TextAsset data;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x28")]
	public byte[] dataBytes;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Rect bounds;

	[NonSerialized]
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x40")]
	public guy instance;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x48")]
	private string dgiw;

	[Token(Token = "0x17000006")]
	public bool edvd
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x7E0A20", Offset = "0x7DF420", VA = "0x1807E0A20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x7E0A30", Offset = "0x7DF430", VA = "0x1807E0A30")]
	private void bjzq(string a)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7E0AB0", Offset = "0x7DF4B0", VA = "0x1807E0AB0")]
	public void bjzr(string a)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7E0D10", Offset = "0x7DF710", VA = "0x1807E0D10")]
	public void bjzs()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7E09D0", Offset = "0x7DF3D0", VA = "0x1807E09D0")]
	public Animation(string name, byte[] bytes)
	{
	}
}
