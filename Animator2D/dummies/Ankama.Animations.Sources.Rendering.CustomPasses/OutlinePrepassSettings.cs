using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Sources.Rendering.CustomPasses;

[Serializable]
[Token(Token = "0x200006C")]
public class OutlinePrepassSettings
{
	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x10")]
	public LayerMask layerMask;

	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x14")]
	public int shaderOutlinedInWhitePassIndex;

	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x18")]
	public Color outlineColor;

	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x28")]
	public float outlineWidth;

	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	public float alphaClip;

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x8103F0", Offset = "0x80EDF0", VA = "0x1808103F0")]
	public OutlinePrepassSettings()
	{
	}
}
