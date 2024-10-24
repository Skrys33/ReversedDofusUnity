using Ankama.Animations.Sources.Rendering.CustomPasses;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Token(Token = "0x200006A")]
public class gvk : ScriptableRenderPass
{
	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0xE0")]
	private readonly AddOutlinesPassSettings dgmq;

	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0xE8")]
	private readonly Material dgmr;

	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int dgms;

	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int dgmt;

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x81FB70", Offset = "0x81E570", VA = "0x18081FB70")]
	public gvk(AddOutlinesPassSettings a, RenderPassEvent b, Shader c)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x81F7E0", Offset = "0x81E1E0", VA = "0x18081F7E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
