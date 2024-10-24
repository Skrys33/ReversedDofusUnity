using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Sources.Rendering.CustomPasses;

[Serializable]
[Token(Token = "0x2000067")]
public class OutlineInTexturePassSettings
{
	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x10")]
	public LayerMask layerMask;

	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x14")]
	public int shaderOutlinedInWhitePassIndex;

	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x18")]
	[Range(0f, 1f)]
	public float alphaClip;

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x80FFF0", Offset = "0x80E9F0", VA = "0x18080FFF0")]
	public OutlineInTexturePassSettings()
	{
	}
}
