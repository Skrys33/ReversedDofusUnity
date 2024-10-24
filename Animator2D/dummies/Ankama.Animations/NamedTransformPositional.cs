using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations;

[Token(Token = "0x2000023")]
public struct NamedTransformPositional
{
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x0")]
	public int id;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x4")]
	public Vector3 position;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x10")]
	public Quaternion rotation;
}
