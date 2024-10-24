using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200003C")]
internal static class Animator2DRendererUtility
{
	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x0")]
	private static List<Material> m_cachedMaterials;

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x8037B0", Offset = "0x8021B0", VA = "0x1808037B0")]
	public static void CreateMeshComponents(GameObject gameObject, out MeshRenderer meshRenderer, out MeshFilter meshFilter)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x803D10", Offset = "0x802710", VA = "0x180803D10")]
	public static void DestroyMeshComponents(MeshRenderer meshRenderer, MeshFilter meshFilter)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x803BC0", Offset = "0x8025C0", VA = "0x180803BC0")]
	public static void DestroyMaterialsFromMeshRenderer(MeshRenderer meshRenderer)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x803960", Offset = "0x802360", VA = "0x180803960")]
	public static void CreateMesh(MeshFilter meshFilter, out Mesh mesh)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x803DE0", Offset = "0x8027E0", VA = "0x180803DE0")]
	public static void DestroyMesh(MeshFilter meshFilter, Mesh mesh)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x803610", Offset = "0x802010", VA = "0x180803610")]
	internal static void AutoPositionBackgrounds(List<BackgroundObject> backgroundSprites, Bounds bounds)
	{
	}
}
