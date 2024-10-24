using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations;

[Serializable]
[Token(Token = "0x200001E")]
public sealed class CustomisationSlot
{
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string nodeName;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public SkinAsset asset;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public SkinAssetPart part;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x7EC090", Offset = "0x7EAA90", VA = "0x1807EC090")]
	public CustomisationSlot()
	{
	}
}
