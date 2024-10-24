using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Ankama.Animations;

[Serializable]
[Token(Token = "0x200002A")]
public sealed class SkinAssetPartPair
{
	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	internal SkinAsset asset;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal SkinAssetPart part;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x7F7720", Offset = "0x7F6120", VA = "0x1807F7720")]
	internal SkinAssetPartPair([NotNull] SkinAsset asset, [NotNull] SkinAssetPart part)
	{
	}
}
