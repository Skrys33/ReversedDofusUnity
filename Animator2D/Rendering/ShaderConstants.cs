using UnityEngine.Rendering;

namespace Ankama.Animator2D.Rendering
{
    public static class ShaderConstants
    {
        public const string UseColorEffectsKeyword = "USE_COLOR_EFFECTS";

        public const string UseCustomisationColorsKeyword = "USE_CUSTOMISATION_COLORS";

        public const string ApplyAlphaStencilKeyword = "APPLY_ALPHA_STENCIL";

        public const string IsAnimator2DKeyword = "_ISANIMATOR2D";

        public static readonly int blendSourceAlpha;

        public static readonly int blendDestinationAlpha;

        public const BlendMode DefaultAnimator2DBlendSourceFactorAlpha = BlendMode.OneMinusDstAlpha;

        public const BlendMode DefaultAnimator2DBlendDestinationFactorAlpha = BlendMode.One;

        public const string Color = "_Color";

        public static LocalKeyword EnableHighlightKeyword;

        public static LocalKeyword useCustomisationColorsKeyword;

        public static LocalKeyword useColorEffectsKeywordKeyword;

        public static LocalKeyword isAnimator2DKeyword;

        public const string HighlightCoef = "_HighlightCoef";

        public const string HighlightAdd = "_HighlightAdd";

        public static LocalKeyword EnableOutlineKeyword;

        public static LocalKeyword EnableOutlineSoloKeyword;

        public static readonly int OutlineLayer;
    }
}