using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200003A")]
internal class EvaluatedAnimationFrame
{
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x10")]
	public List<AnimationGeometryVertex> vertexBuffer;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x18")]
	public List<ushort> triangleBuffer;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x20")]
	public List<MaterialDescriptor> materialDescriptors;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x28")]
	public List<int> materialOffsets;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x30")]
	public List<SubMeshDescriptor> subMeshes;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x38")]
	public List<SubMeshDescriptor> stencilSubMeshes;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<int, int> namedTransformIndicesToBaseMaterialOffsets;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<string, Bounds> nodeBounds;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x50")]
	public List<Bounds> collisionBounds;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x58")]
	public List<NamedTransformPositional> namedTransformPositions;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x60")]
	public Bounds bounds;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x78")]
	public int stencilSubMeshIndex;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x7C")]
	public Bounds stencilBounds;

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x80A410", Offset = "0x808E10", VA = "0x18080A410")]
	public EvaluatedAnimationFrame()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x80A6C0", Offset = "0x8090C0", VA = "0x18080A6C0")]
	public EvaluatedAnimationFrame(List<AnimationGeometryVertex> vertexBuffer, List<ushort> triangleBuffer, List<MaterialDescriptor> materialDescriptors, List<int> materialOffsets, List<SubMeshDescriptor> subMeshes, List<SubMeshDescriptor> stencilSubMeshes, Dictionary<int, int> namedTransformIndicesToBaseMaterialOffsets, Dictionary<string, Bounds> nodeBounds, Bounds bounds, int stencilSubMeshIndex, Bounds stencilBounds)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x809E90", Offset = "0x808890", VA = "0x180809E90")]
	public void Reset(bool allowResetMaterialOffsets = true)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x80A210", Offset = "0x808C10", VA = "0x18080A210")]
	public void SetNamedTransform(int namedTransformIndex, Vector3 position, Quaternion rotation)
	{
	}
}
