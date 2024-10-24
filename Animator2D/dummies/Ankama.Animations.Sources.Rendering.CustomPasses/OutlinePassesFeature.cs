using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Ankama.Animations.Sources.Rendering.CustomPasses;

[Token(Token = "0x2000066")]
public class OutlinePassesFeature : ScriptableRendererFeature
{
	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x20")]
	public RenderPassEvent renderPassEvent;

	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x28")]
	public Shader shaderOverride;

	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x30")]
	private gvj m_outlineInTexPass;

	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x38")]
	public OutlineInTexturePassSettings outlineInTexSettings;

	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x40")]
	private gvk m_addOutlinesPass;

	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x48")]
	public AddOutlinesPassSettings addOutlinesSettings;

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x810050", Offset = "0x80EA50", VA = "0x180810050", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x810000", Offset = "0x80EA00", VA = "0x180810000", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x7BEF60", Offset = "0x7BD960", VA = "0x1807BEF60")]
	public OutlinePassesFeature()
	{
	}
}
