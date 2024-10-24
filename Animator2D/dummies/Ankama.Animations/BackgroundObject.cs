using Ankama.Animations.Rendering;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations;

[Token(Token = "0x200001D")]
internal struct BackgroundObject
{
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x0")]
	public int id;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x8")]
	public GameObject gameObject;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x10")]
	public IApplyMaterialSortOrder applyMaterialSortOrder;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x18")]
	public bool requiresAutoPosition;
}
