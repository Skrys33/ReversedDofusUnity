using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Ankama.Animations.Sources.Rendering.CustomPasses;

[Token(Token = "0x200006B")]
public class OutlinePrepassFeature : ScriptableRendererFeature
{
	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x20")]
	public RenderPassEvent renderPassEvent;

	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x28")]
	public Shader shaderOverride;

	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x30")]
	private gvl m_outlineInTexPass;

	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x38")]
	public OutlinePrepassSettings outlineInTexSettings;

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x810350", Offset = "0x80ED50", VA = "0x180810350", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x810320", Offset = "0x80ED20", VA = "0x180810320", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x7BEF60", Offset = "0x7BD960", VA = "0x1807BEF60")]
	public OutlinePrepassFeature()
	{
	}
}
