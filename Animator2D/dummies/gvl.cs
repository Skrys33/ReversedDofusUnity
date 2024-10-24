using Ankama.Animations.Sources.Rendering.CustomPasses;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Token(Token = "0x200006D")]
public class gvl : ScriptableRenderPass
{
	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0xE0")]
	private readonly OutlinePrepassSettings dgmu;

	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0xE8")]
	private readonly Shader dgmv;

	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0xF0")]
	private readonly ShaderTagId dgmw;

	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0xF4")]
	private readonly FilteringSettings dgmx;

	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x10C")]
	private readonly int dgmy;

	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int dgmz;

	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int dgna;

	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int dgnb;

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x820260", Offset = "0x81EC60", VA = "0x180820260")]
	public gvl(OutlinePrepassSettings a, RenderPassEvent b, Shader c)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x81F530", Offset = "0x81DF30", VA = "0x18081F530", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x81FC30", Offset = "0x81E630", VA = "0x18081FC30", Slot = "9")]
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x81F500", Offset = "0x81DF00", VA = "0x18081F500", Slot = "7")]
	public override void OnCameraCleanup(CommandBuffer cmd)
	{
	}
}
