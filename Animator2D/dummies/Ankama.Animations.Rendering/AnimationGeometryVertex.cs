using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ankama.Animations.Rendering;

[Serializable]
[Token(Token = "0x2000032")]
public struct AnimationGeometryVertex
{
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public Vector3 pos;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	public Vector2 uv;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public uint multiplicativeColor;

	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public uint additiveColor;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x0")]
	public static readonly VertexAttributeDescriptor[] s_layout;
}
