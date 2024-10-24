using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000034")]
internal sealed class Animator2DCustomisableRenderer : Animator2DRenderer
{
	[Token(Token = "0x2000035")]
	private static class ShaderID
	{
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int CustomisationColors;
	}

	[Token(Token = "0x2000036")]
	private struct MaterialOffsetForSymbol
	{
		[Token(Token = "0x17000026")]
		public readonly int symbolId
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x808F60", Offset = "0x807960", VA = "0x180808F60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		public readonly int materialOffset
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x80FFE0", Offset = "0x80E9E0", VA = "0x18080FFE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x7D2300", Offset = "0x7D0D00", VA = "0x1807D2300")]
		public MaterialOffsetForSymbol(int symbolId, int materialOffset)
		{
		}
	}

	[Token(Token = "0x2000037")]
	private struct DrawContext
	{
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x0")]
		public RenderState renderState;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x60")]
		public EvaluatedAnimationFrame evaluatedAnimationFrame;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x68")]
		public int lastRenderedIndex;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x6C")]
		public int maskDepth;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x70")]
		public MaterialDescriptor? currentMaterialIdentifier;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0xC0")]
		public gve namedTransforms;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0xC8")]
		public bool isMaskNode;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0xD0")]
		public Animator2DCustomisableRenderer renderer;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xD8")]
		public float zoomScale;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x8099C0", Offset = "0x8083C0", VA = "0x1808099C0")]
		public void Draw(SkinAssetPartPair assetPartPair, AnimTransform transform, int index, int count, int specificMaterialOffset)
		{
		}
	}

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x118")]
	private string[] m_exposedNodeNames;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x120")]
	private Dictionary<string, SkinAssetPartPair> m_customisations;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x128")]
	private HashSet<string> m_intendedEmptyCustomisations;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x130")]
	private HashSet<string> m_skinRuleEmptyCustomisations;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x138")]
	private Dictionary<string, SkinTransformData> m_skinTransforms;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x140")]
	private List<string> m_modifiedSkinIds;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly object s_poolLockObject;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x148")]
	private readonly Color[] m_customisationColors;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x150")]
	private bool m_customisationDirty;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x158")]
	private readonly Dictionary<string, Dictionary<string, string>> m_skinSpecificSlots;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x802E10", Offset = "0x801810", VA = "0x180802E10")]
	public Animator2DCustomisableRenderer(MeshRenderer meshRenderer, MeshFilter meshFilter, Material material, int maxNodeCount, string[] exposedNodeNames)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x802740", Offset = "0x801140", VA = "0x180802740")]
	public void UpdateExposedNodeNames(string[] exposedNodeNames)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x801050", Offset = "0x7FFA50", VA = "0x180801050")]
	public void SetModifiedSkinIds(List<string> modifiedSkinIds)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x800A80", Offset = "0x7FF480", VA = "0x180800A80")]
	public void SetCustomisation(Dictionary<string, CustomisationSlot> customisations, HashSet<string> intendedEmptyCustomisations, HashSet<string> skinSlotRulesEmptied, List<string> modifiedSkinIds)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x7FD830", Offset = "0x7FC230", VA = "0x1807FD830")]
	private void AddSkinSpecificSlot(string slotName)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x800760", Offset = "0x7FF160", VA = "0x180800760")]
	public void SetCustomisation(string slotName, SkinAsset asset, SkinAssetPart part)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x800750", Offset = "0x7FF150", VA = "0x180800750")]
	public void SetCustomisationTransforms(Dictionary<string, SkinTransformData> skinTransformData)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x8003B0", Offset = "0x7FEDB0", VA = "0x1808003B0")]
	public void SetCustomisationColor(int index, Color color)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x7FFF20", Offset = "0x7FE920", VA = "0x1807FFF20")]
	public Color GetCustomisationColor(int index)
	{
		return default(Color);
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x7FEDB0", Offset = "0x7FD7B0", VA = "0x1807FEDB0")]
	internal static void ApplyCustomisationColors(Material destinationMaterial, Color[] customisationColors)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x7FEEA0", Offset = "0x7FD8A0", VA = "0x1807FEEA0", Slot = "35")]
	protected override void ApplyCustomisationColors()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x800360", Offset = "0x7FED60", VA = "0x180800360")]
	public void ResetSkinRules()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x800240", Offset = "0x7FEC40", VA = "0x180800240")]
	private void ReapplyCustomisation(SkinAssetPartPair[] graphics, gve namedTransforms, guy animation, bool flipped, float zoomScale)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x801DE0", Offset = "0x8007E0", VA = "0x180801DE0")]
	private void TryUpdateNamedTransform(int symbolId, EvaluatedAnimationFrame currentFrame, Dictionary<int, int> namedTransformIndicesToBaseMaterialOffsets, gve namedTransforms, int namedTransformIndex, RenderState renderState, List<MaterialOffsetForSymbol> materialOffsetList, int materialCount, AnimTransform? skinGraphicTransform)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x802140", Offset = "0x800B40", VA = "0x180802140")]
	private void TryUpdateNamedTransformsForSkinParts(SkinAssetPartPair graphic, Dictionary<int, int> namedTransformIndicesToBaseMaterialOffsets, EvaluatedAnimationFrame currentFrame, gve namedTransforms, RenderState renderState, List<MaterialOffsetForSymbol> materialOffsetList, int materialCount)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x801440", Offset = "0x7FFE40", VA = "0x180801440")]
	private bool TryGetRenderStateGraphic(EvaluatedAnimationFrame evaluatedAnimationFrame, Dictionary<int, int> namedTransformIndicesToBaseMaterialOffsets, SkinAssetPartPair[] graphics, gve namedTransforms, List<MaterialOffsetForSymbol> materialOffsetList, int materialCount, RenderState renderState, out SkinAssetPartPair graphic, out bool isCustomised)
	{
		return default(bool);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x7FF9A0", Offset = "0x7FE3A0", VA = "0x1807FF9A0")]
	private Bounds ComputeUnbufferedFrame(SkinAssetPartPair[] graphics, gve namedTransforms, guy animation, int targetFrameIndex, int storedFrameIndex, float zoomScale)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x7FFBC0", Offset = "0x7FE5C0", VA = "0x1807FFBC0", Slot = "32")]
	public override void Compute(SkinAssetPartPair[] graphics, gve namedTransforms, guy animation, int targetFrameIndex, bool flipped, float zoomScale)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x7FF3E0", Offset = "0x7FDDE0", VA = "0x1807FF3E0", Slot = "33")]
	public override void Buffer(SkinAssetPartPair[] graphics, gve namedTransforms, guy animation)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x8012A0", Offset = "0x7FFCA0", VA = "0x1808012A0")]
	private bool TryGetCustomisedGraphic(SkinAssetPartPair[] graphics, short spriteIndex, short customisationIndex, out SkinAssetPartPair graphic, out bool isCustomised)
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x801100", Offset = "0x7FFB00", VA = "0x180801100")]
	private bool TryGetCustomisedGraphic(string symbolName, out SkinAssetPartPair graphic, out bool isCustomised)
	{
		return default(bool);
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x801CD0", Offset = "0x8006D0", VA = "0x180801CD0")]
	private bool TryGetSpecificNamedCustomisedGraphic(string symbolName, out SkinAssetPartPair graphic, out bool isCustomised)
	{
		return default(bool);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x800080", Offset = "0x7FEA80", VA = "0x180800080")]
	private AnimTransform GetSkinTransform(string className)
	{
		return default(AnimTransform);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x802750", Offset = "0x801150", VA = "0x180802750")]
	private void WalkDisplayList(SkinAssetPartPair root, AnimTransform transform, List<MaterialOffsetForSymbol> materialOffsetList, ref int materialOffsetIndex, ref DrawContext drawContext)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x7FD890", Offset = "0x7FC290", VA = "0x1807FD890", Slot = "36")]
	public override void AppendEvaluatedAnimation(EvaluatedAnimationFrame evaluatedAnimationFrame, guy animation, int dataPosition, SkinAssetPartPair[] graphics, RenderState[] renderStates, gve namedTransforms, float zoomScale)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x800240", Offset = "0x7FEC40", VA = "0x180800240")]
	private void ReApplyRenderStates(SkinAssetPartPair[] graphics, gve namedTransforms, guy animation, bool flipped, float zoomScale)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x7FF130", Offset = "0x7FDB30", VA = "0x1807FF130", Slot = "34")]
	public override int ApplyMaterialSortOrder(int startIndex, gve namedTransforms)
	{
		return default(int);
	}
}
