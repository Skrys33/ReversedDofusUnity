using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200004C")]
internal class MaterialConfigurationService
{
	[Token(Token = "0x200004D")]
	private static class ShaderID
	{
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MainTex;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int BlendOp;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int BlendSourceRGB;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int BlendDestinationRGB;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int ColorMatrix;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int StencilRef;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int StencilComp;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int StencilOp;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int ColorMask;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int Color;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string FilterColorMatrix;
	}

	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x10")]
	private Material m_rootMaterial;

	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x18")]
	private readonly Queue<Material> m_poolMaterials;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<Material> m_allMaterials;

	[Token(Token = "0x4000203")]
	private const string FlashBlendModeMultiply = "FLASH_BLEND_MODE_MULTIPLY";

	[Token(Token = "0x4000204")]
	private const string FlashBlendModeScreen = "FLASH_BLEND_MODE_SCREEN";

	[Token(Token = "0x4000205")]
	private const string FlashBlendModeInvert = "FLASH_BLEND_MODE_INVERT";

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x80ECA0", Offset = "0x80D6A0", VA = "0x18080ECA0")]
	private Material GetPoolOrNewMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x80F5C0", Offset = "0x80DFC0", VA = "0x18080F5C0")]
	public MaterialConfigurationService(Material rootMaterial)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x80EA80", Offset = "0x80D480", VA = "0x18080EA80")]
	public Material GetMaterial(Texture texture, Animation.gux blendMode, FlashMaskState maskState, int maskRef, Vector4[] colorMatrix, Color rootColor, int renderQueue, bool isHighlighted, Vector4 highlightCoef, Vector4 highlightAdd, bool isOutlined)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x80F0F0", Offset = "0x80DAF0", VA = "0x18080F0F0")]
	public void ReturnMaterialToPool(Material material)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x80E110", Offset = "0x80CB10", VA = "0x18080E110")]
	public void Clear()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x80F310", Offset = "0x80DD10", VA = "0x18080F310")]
	public void SetColor(Color color)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x80F480", Offset = "0x80DE80", VA = "0x18080F480")]
	public void SetKeyword(LocalKeyword keyword, bool value)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x80E250", Offset = "0x80CC50", VA = "0x18080E250")]
	public static void ConfigureMaterial(Material material, Texture texture, Animation.gux blendMode, FlashMaskState maskState, int maskRef, Vector4[] colorMatrix, Color rootColor, int renderQueue, bool isHighlighted, Vector4 highlightCoef, Vector4 highlightAdd, bool isOutlined)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x80E540", Offset = "0x80CF40", VA = "0x18080E540")]
	public static void ConfigureState(CommandBuffer cmd, RenderTargetIdentifier texture, Animation.gux blendMode, FlashMaskState maskState, int maskRef, Vector4[] colorMatrix, Color rootColor)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x80E710", Offset = "0x80D110", VA = "0x18080E710")]
	public static void ConfigureState(CommandBuffer cmd, int texture, Animation.gux blendMode, FlashMaskState maskState, int maskRef, Vector4[] colorMatrix, Color rootColor)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x80F0D0", Offset = "0x80DAD0", VA = "0x18080F0D0")]
	public static FlashMaskState MaskFlagsToMaskState(Animation.guw maskFlags)
	{
		return default(FlashMaskState);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x80D9F0", Offset = "0x80C3F0", VA = "0x18080D9F0")]
	private static void ApplyColorMatrixState(Vector4[] colorMatrix, Color rootColor, Material target)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x80DB10", Offset = "0x80C510", VA = "0x18080DB10")]
	private static void ApplyColorMatrixState(Vector4[] colorMatrix, Color rootColor, CommandBuffer cmd)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x80DE60", Offset = "0x80C860", VA = "0x18080DE60")]
	private static void ApplyMaskState(FlashMaskState maskState, int maskRef, Material target)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x80DC30", Offset = "0x80C630", VA = "0x18080DC30")]
	private static void ApplyMaskState(FlashMaskState maskState, int maskRef, CommandBuffer cmd)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x80F230", Offset = "0x80DC30", VA = "0x18080F230")]
	private static void SetBlendState(BlendOp operation, BlendMode source, BlendMode destination, Material target)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x80F150", Offset = "0x80DB50", VA = "0x18080F150")]
	private static void SetBlendState(BlendOp operation, BlendMode source, BlendMode destination, CommandBuffer cmd)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x80EDF0", Offset = "0x80D7F0", VA = "0x18080EDF0")]
	private static void ManageKeyWords(Animation.gux blendMode, Material target)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x80EF60", Offset = "0x80D960", VA = "0x18080EF60")]
	private static void ManageKeyWords(Animation.gux blendMode, CommandBuffer cmd)
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x80E8F0", Offset = "0x80D2F0", VA = "0x18080E8F0")]
	public static Animation.gux GetCompatibleBlendMode(Animation.gux requested)
	{
		return default(Animation.gux);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x80D630", Offset = "0x80C030", VA = "0x18080D630")]
	private static void ApplyBlendMode(Animation.gux blendMode, Material target)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x80D270", Offset = "0x80BC70", VA = "0x18080D270")]
	private static void ApplyBlendMode(Animation.gux blendMode, CommandBuffer cmd)
	{
	}
}
