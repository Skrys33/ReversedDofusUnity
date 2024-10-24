using System;
using System.Collections.Generic;
using Ankama.Animations.Rendering;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations;

[Token(Token = "0x2000029")]
[PreferBinarySerialization]
public sealed class SkinAsset : ScriptableObject, ISerializationCallbackReceiver
{
	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<SkinAssetPart> m_values;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<string> m_keys;

	[NonSerialized]
	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<string, SkinAssetPart> skinParts;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x30")]
	public ushort[] triangles;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x38")]
	public AnimationGeometryVertex[] vertices;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x40")]
	public string[] referencedSymbols;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x48")]
	public string[] emptyCustomisations;

	[NonSerialized]
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x50")]
	public HashSet<string> customEmptyCustomisations;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x58")]
	public List<Texture2D> textures;

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x7F7D30", Offset = "0x7F6730", VA = "0x1807F7D30", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x7F7B10", Offset = "0x7F6510", VA = "0x1807F7B10", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x7F8140", Offset = "0x7F6B40", VA = "0x1807F8140")]
	public SkinAsset()
	{
	}
}
