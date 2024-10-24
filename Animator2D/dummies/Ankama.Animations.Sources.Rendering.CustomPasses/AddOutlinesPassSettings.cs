using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Sources.Rendering.CustomPasses;

[Serializable]
[Token(Token = "0x2000069")]
public class AddOutlinesPassSettings
{
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x10")]
	public int shaderAddOutlinesPassIndex;

	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x14")]
	public Color outlineColor;

	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x24")]
	public float outlineWidth;

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x7FC310", Offset = "0x7FAD10", VA = "0x1807FC310")]
	public AddOutlinesPassSettings()
	{
	}
}
