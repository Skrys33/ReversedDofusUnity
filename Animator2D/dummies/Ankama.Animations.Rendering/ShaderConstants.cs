using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000052")]
public static class ShaderConstants
{
	[Token(Token = "0x4000227")]
	public const string UseColorEffectsKeyword = "USE_COLOR_EFFECTS";

	[Token(Token = "0x4000228")]
	public const string UseCustomisationColorsKeyword = "USE_CUSTOMISATION_COLORS";

	[Token(Token = "0x4000229")]
	public const string ApplyAlphaStencilKeyword = "APPLY_ALPHA_STENCIL";

	[Token(Token = "0x400022A")]
	public const string IsAnimator2DKeyword = "_ISANIMATOR2D";

	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int blendSourceAlpha;

	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int blendDestinationAlpha;

	[Token(Token = "0x400022D")]
	public const BlendMode DefaultAnimator2DBlendSourceFactorAlpha = BlendMode.OneMinusDstAlpha;

	[Token(Token = "0x400022E")]
	public const BlendMode DefaultAnimator2DBlendDestinationFactorAlpha = BlendMode.One;

	[Token(Token = "0x400022F")]
	public const string Color = "_Color";

	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x8")]
	public static LocalKeyword EnableHighlightKeyword;

	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x20")]
	public static LocalKeyword useCustomisationColorsKeyword;

	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x38")]
	public static LocalKeyword useColorEffectsKeywordKeyword;

	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x50")]
	public static LocalKeyword isAnimator2DKeyword;

	[Token(Token = "0x4000234")]
	public const string HighlightCoef = "_HighlightCoef";

	[Token(Token = "0x4000235")]
	public const string HighlightAdd = "_HighlightAdd";

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x68")]
	public static LocalKeyword EnableOutlineKeyword;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x80")]
	public static LocalKeyword EnableOutlineSoloKeyword;

	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x98")]
	public static readonly int OutlineLayer;
}
