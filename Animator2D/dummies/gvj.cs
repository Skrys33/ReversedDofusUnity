using Ankama.Animations.Sources.Rendering.CustomPasses;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Token(Token = "0x2000068")]
public class gvj : ScriptableRenderPass
{
	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0xE0")]
	private readonly OutlineInTexturePassSettings dgmk;

	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0xE8")]
	private readonly Shader dgml;

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0xF0")]
	private readonly ShaderTagId dgmm;

	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0xF4")]
	private readonly FilteringSettings dgmn;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x10C")]
	private readonly int dgmo;

	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int dgmp;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x81F610", Offset = "0x81E010", VA = "0x18081F610")]
	public gvj(OutlineInTexturePassSettings a, RenderPassEvent b, Shader c)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x81F530", Offset = "0x81DF30", VA = "0x18081F530", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x81F090", Offset = "0x81DA90", VA = "0x18081F090", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x81F500", Offset = "0x81DF00", VA = "0x18081F500", Slot = "7")]
	public override void OnCameraCleanup(CommandBuffer cmd)
	{
	}
}
