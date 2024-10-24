using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000053")]
public class SpriteRendererWithFilters : MonoBehaviour
{
	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x20")]
	private MaterialDescriptor m_materialDescriptor;

	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<MaterialDescriptor> m_materialList;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x70")]
	private readonly List<SubMeshDescriptor> m_submeshDescriptors;

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x8127B0", Offset = "0x8111B0", VA = "0x1808127B0")]
	protected void InitMaterialDescriptor(Sprite sprite, Vector4[] colorMatrix, int renderQueue, FlashMaskState maskState = FlashMaskState.None, uint textureRequestId = 0u, bool requireUseColorEffectsKeyword = false)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x812180", Offset = "0x810B80", VA = "0x180812180")]
	protected Texture ApplyFilter(FlashFilters filters, List<ushort> triangles, List<AnimationGeometryVertex> vertices, Bounds bounds, Material renderMaterial)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x8128B0", Offset = "0x8112B0", VA = "0x1808128B0")]
	public SpriteRendererWithFilters()
	{
	}
}
