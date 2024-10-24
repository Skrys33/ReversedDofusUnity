using System.Collections.Generic;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000048")]
internal interface IAnimator2DRenderer
{
	[Token(Token = "0x6000213")]
	void Start([NotNull] guy animation);

	[Token(Token = "0x6000214")]
	void Release();

	[Token(Token = "0x6000215")]
	void Compute([NotNull] SkinAssetPartPair[] graphics, gve namedTransforms, [NotNull] guy animation, int targetFrameIndex, bool flipped, float zoomScale);

	[Token(Token = "0x6000216")]
	void Buffer([NotNull] SkinAssetPartPair[] graphics, gve namedTransforms, [NotNull] guy animation);

	[Token(Token = "0x6000217")]
	void SetMaterial([NotNull] Material value, Color color);

	[Token(Token = "0x6000218")]
	void SetColor(Color value);

	[Token(Token = "0x6000219")]
	void SetHighlight(bool highlight, Vector4 highlightCoef, Vector4 highlightAdd);

	[Token(Token = "0x600021A")]
	void SetOutline(bool shouldOutline);

	[Token(Token = "0x600021B")]
	void SetMaskToBounds();

	[Token(Token = "0x600021C")]
	void SetMaskToSymbol(string graphicSymbolId);

	[Token(Token = "0x600021D")]
	void ClearMask();

	[Token(Token = "0x600021E")]
	void SetBackgroundSprites(List<BackgroundObject> backgroundSpriteOrder);

	[Token(Token = "0x600021F")]
	void EnableKeyword(string keyword);

	[Token(Token = "0x6000220")]
	void DisableKeyword(string keyword);

	[Token(Token = "0x6000221")]
	bool IsKeywordEnabled(string keyword);

	[Token(Token = "0x6000222")]
	int ApplyMaterialSortOrder(int startIndex, gve namedTransforms);

	[Token(Token = "0x6000223")]
	void SetRendererVisible(bool visible);

	[Token(Token = "0x6000224")]
	void SetFilters(in FlashFilters filters);

	[Token(Token = "0x6000225")]
	bool HitTest(Vector2 queryPoint);

	[Token(Token = "0x6000226")]
	Bounds GetBounds();

	[Token(Token = "0x6000227")]
	bool TryGetNodeBounds(string className, out Bounds nodeBounds);

	[Token(Token = "0x6000228")]
	List<Bounds> GetAllNodeBounds();

	[Token(Token = "0x6000229")]
	List<NamedTransformPositional> GetNamedTransformPositionals();

	[Token(Token = "0x600022A")]
	void AppendEvaluatedAnimation(EvaluatedAnimationFrame evaluatedAnimationFrame, guy animation, int dataPosition, SkinAssetPartPair[] graphics, RenderState[] renderStates, gve namedTransforms, float zoomScale);

	[Token(Token = "0x600022B")]
	int AdvanceToFrame(RenderState[] renderStates, int storedFrameIndex, guy animation, int targetFrameIndex);

	[Token(Token = "0x600022C")]
	void UpdateMeshFromBuffers(EvaluatedAnimationFrame evaluatedAnimationFrame, gve namedTransformRepository, bool flipped, float zoomScale);

	[Token(Token = "0x600022D")]
	void ClearMaterialPool();
}
