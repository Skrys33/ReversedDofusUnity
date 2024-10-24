using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200003B")]
internal class Animator2DRenderer : IAnimator2DRenderer
{
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x10")]
	protected RenderState[] m_bufferedRenderStates;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x18")]
	protected readonly MaterialConfigurationService m_materialConfigurationService;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x20")]
	private readonly Mesh m_mesh;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x28")]
	private readonly MeshFilter m_meshFilter;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x30")]
	private readonly MeshRenderer m_meshRenderer;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x38")]
	protected RenderState[] m_renderStates;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x40")]
	private List<BackgroundObject> m_backgroundSpriteOrder;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x48")]
	protected BufferState m_bufferState;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x50")]
	protected Material[] m_currentMaterials;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x58")]
	private FlashFilters m_flashFilters;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x80")]
	private string m_maskGraphicSymbolId;

	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x88")]
	private Color m_colorModifier;

	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x98")]
	private bool m_isMaterialColorOverwrittenByFlashFilter;

	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0xA0")]
	private List<NamedTransformPositional> m_displayedTransforms;

	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0xA8")]
	private List<Bounds> m_displayedNodeBounds;

	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0xB0")]
	protected AnimationMaskType m_maskType;

	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0xB8")]
	protected Material m_material;

	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0xC0")]
	protected SpinLock m_spinLock;

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0xC4")]
	protected int m_storedFrameIndex;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0xC8")]
	protected int m_triangleBufferCapacityHint;

	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0xCC")]
	protected int m_vertexBufferCapacityHint;

	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0xD0")]
	protected bool m_requiresUseColorEffectsKeyword;

	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0xD1")]
	protected bool m_isHighlighted;

	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0xD4")]
	protected Vector4 m_highlightCoef;

	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0xE4")]
	protected Vector4 m_highlightAdd;

	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0xF4")]
	protected bool m_isOutlined;

	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0xF8")]
	protected int m_currentRenderQueue;

	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<AnimationGeometryVertex> s_vertexBuffer;

	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x8")]
	private static readonly List<ushort> s_triangleBuffer;

	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x10")]
	private static readonly List<Material> s_materials;

	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x18")]
	private static readonly List<MaterialDescriptor> s_materialDescriptors;

	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x20")]
	private static readonly List<SubMeshDescriptor> s_subMeshes;

	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x28")]
	private static readonly List<SubMeshDescriptor> s_stencilSubMeshes;

	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x100")]
	protected EvaluatedAnimationFrame m_evaluatedAnimationFrame;

	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x108")]
	protected EvaluatedAnimationFrame m_asyncEvaluatedAnimationFrame;

	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x110")]
	private EvaluatedAnimationFrame m_lastMeshUpdateFrame;

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x8085E0", Offset = "0x806FE0", VA = "0x1808085E0")]
	public Animator2DRenderer(MeshRenderer meshRenderer, MeshFilter meshFilter, Material material, int maxNodeCount)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x807D80", Offset = "0x806780", VA = "0x180807D80")]
	public void UpdateMaxNodeCount(int maxNodeCount)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x806D70", Offset = "0x805770", VA = "0x180806D70", Slot = "12")]
	public void SetMaskToBounds()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x806DB0", Offset = "0x8057B0", VA = "0x180806DB0", Slot = "13")]
	public void SetMaskToSymbol(string graphicSymbolId)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x805B30", Offset = "0x804530", VA = "0x180805B30", Slot = "14")]
	public void ClearMask()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x804950", Offset = "0x803350", VA = "0x180804950")]
	public void SetFilters(in FlashFilters filters)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x8062A0", Offset = "0x804CA0", VA = "0x1808062A0", Slot = "23")]
	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x7DFCB0", Offset = "0x7DE6B0", VA = "0x1807DFCB0", Slot = "15")]
	public void SetBackgroundSprites(List<BackgroundObject> backgroundSpriteOrder)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x8070F0", Offset = "0x805AF0", VA = "0x1808070F0", Slot = "20")]
	public void SetRendererVisible(bool visible)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x807370", Offset = "0x805D70", VA = "0x180807370", Slot = "31")]
	public virtual void Start([NotNull] guy animation)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x8067E0", Offset = "0x8051E0", VA = "0x1808067E0", Slot = "5")]
	public void Release()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x805B50", Offset = "0x804550", VA = "0x180805B50", Slot = "30")]
	public void ClearMaterialPool()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x806AF0", Offset = "0x8054F0", VA = "0x180806AF0", Slot = "10")]
	public void SetHighlight(bool highlight, Vector4 highlightCoef, Vector4 highlightAdd)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x807010", Offset = "0x805A10", VA = "0x180807010", Slot = "11")]
	public void SetOutline(bool shouldOutline)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x8069A0", Offset = "0x8053A0", VA = "0x1808069A0", Slot = "9")]
	public void SetColor(Color value)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x806DE0", Offset = "0x8057E0", VA = "0x180806DE0", Slot = "8")]
	public void SetMaterial(Material material, Color color)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x805FA0", Offset = "0x8049A0", VA = "0x180805FA0", Slot = "16")]
	public void EnableKeyword(string keyword)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x805F70", Offset = "0x804970", VA = "0x180805F70", Slot = "17")]
	public void DisableKeyword(string keyword)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x8067B0", Offset = "0x8051B0", VA = "0x1808067B0", Slot = "18")]
	public bool IsKeywordEnabled(string keyword)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x806540", Offset = "0x804F40", VA = "0x180806540", Slot = "22")]
	public bool HitTest(Vector2 queryPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x806300", Offset = "0x804D00", VA = "0x180806300", Slot = "26")]
	public List<NamedTransformPositional> GetNamedTransformPositionals()
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x807710", Offset = "0x806110", VA = "0x180807710", Slot = "24")]
	public bool TryGetNodeBounds(string className, out Bounds nodeBounds)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x806290", Offset = "0x804C90", VA = "0x180806290", Slot = "25")]
	public List<Bounds> GetAllNodeBounds()
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x805B70", Offset = "0x804570", VA = "0x180805B70", Slot = "32")]
	public virtual void Compute(SkinAssetPartPair[] graphics, gve namedTransforms, guy animation, int targetFrameIndex, bool flipped, float zoomScale)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x8054D0", Offset = "0x803ED0", VA = "0x1808054D0", Slot = "33")]
	public virtual void Buffer(SkinAssetPartPair[] graphics, gve namedTransforms, guy animation)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x8052D0", Offset = "0x803CD0", VA = "0x1808052D0", Slot = "34")]
	public virtual int ApplyMaterialSortOrder(int startIndex, gve namedTransforms)
	{
		return default(int);
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x807880", Offset = "0x806280", VA = "0x180807880")]
	private void UpdateMaterialsFromDescriptors(List<MaterialDescriptor> descriptors)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x805FD0", Offset = "0x8049D0", VA = "0x180805FD0")]
	protected void FlushPendingRenderMeshWrites(EvaluatedAnimationFrame evaluatedAnimationFrame, ref int lastRenderedIndex, ref MaterialDescriptor? currentMaterialIdentifier, ref MaterialDescriptor materialIdentifier, bool isStencil)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x803F40", Offset = "0x802940", VA = "0x180803F40")]
	protected Bounds AddGraphicToRenderLists(EvaluatedAnimationFrame evaluatedAnimationFrame, ref MaterialDescriptor? currentMaterialIdentifier, SkinAssetPartPair graphic, ReadOnlySpan<SkinChunk> skinChunks, ref int lastRenderedIndex, RenderState renderState, int sortOffset, bool isMaskNode, Color[] customisationColors, ref int maskDepth, float zoomScale)
	{
		return default(Bounds);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x805160", Offset = "0x803B60", VA = "0x180805160", Slot = "35")]
	protected virtual void ApplyCustomisationColors()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x804E60", Offset = "0x803860", VA = "0x180804E60")]
	protected void ApplyBufferedFrame(gve namedTransforms, bool flipped, float zoomScale)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x807DE0", Offset = "0x8067E0", VA = "0x180807DE0", Slot = "29")]
	public void UpdateMeshFromBuffers(EvaluatedAnimationFrame evaluatedAnimationFrame, gve namedTransformRepository, bool flipped, float zoomScale)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x807B40", Offset = "0x806540", VA = "0x180807B40")]
	private void UpdateMaterials()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x805370", Offset = "0x803D70", VA = "0x180805370")]
	protected int ApplySortingToBackgroundSprites(int startIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x804810", Offset = "0x803210", VA = "0x180804810", Slot = "28")]
	public int AdvanceToFrame(RenderState[] renderStates, int storedFrameIndex, guy animation, int targetFrameIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x807690", Offset = "0x806090", VA = "0x180807690")]
	private static bool TryGetGraphic(SkinAssetPartPair[] graphics, RenderState renderState, out SkinAssetPartPair graphic)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x804980", Offset = "0x803380", VA = "0x180804980", Slot = "36")]
	public virtual void AppendEvaluatedAnimation(EvaluatedAnimationFrame evaluatedAnimationFrame, guy animation, int dataPosition, SkinAssetPartPair[] graphics, RenderState[] renderStates, gve namedTransforms, float zoomScale)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x806310", Offset = "0x804D10", VA = "0x180806310")]
	protected static RenderState GetNextRenderState(guy animation, ref int dataPosition, RenderState[] renderStates)
	{
		return default(RenderState);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x807180", Offset = "0x805B80", VA = "0x180807180")]
	protected static void SkipRenderStateDataPosition(guy animation, ref int dataPosition, RenderState[] renderStates, int numNodesToSkip)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x804950", Offset = "0x803350", VA = "0x180804950", Slot = "21")]
	private void Ankama_002EAnimations_002ERendering_002EIAnimator2DRenderer_002ESetFilters(in FlashFilters filters)
	{
	}
}
