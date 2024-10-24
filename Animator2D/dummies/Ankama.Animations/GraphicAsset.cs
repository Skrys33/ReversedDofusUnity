using Ankama.Animations.Rendering;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations;

[Token(Token = "0x200001F")]
public sealed class GraphicAsset : ScriptableObject
{
	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D atlas;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x20")]
	public AnimationGeometryVertex[] vertices;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x28")]
	public ushort[] triangles;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x7F76A0", Offset = "0x7F60A0", VA = "0x1807F76A0")]
	public GraphicAsset()
	{
	}
}
