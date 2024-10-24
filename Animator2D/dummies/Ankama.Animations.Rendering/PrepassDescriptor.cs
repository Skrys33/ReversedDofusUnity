using System.Collections.Generic;
using Il2CppDummyDll;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200004E")]
public class PrepassDescriptor
{
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x10")]
	private PrepassTextureType m_prepassTextureType;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x18")]
	private List<Animator2D> m_targetAnimators;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x20")]
	private int m_lastFrameRendered;

	[Token(Token = "0x1700002A")]
	internal PrepassTextureType prepassTextureType
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x7DF980", Offset = "0x7DE380", VA = "0x1807DF980")]
		get
		{
			return default(PrepassTextureType);
		}
	}

	[Token(Token = "0x1700002B")]
	internal List<Animator2D> targetAnimators
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x7DB6F0", Offset = "0x7DA0F0", VA = "0x1807DB6F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x7FD680", Offset = "0x7FC080", VA = "0x1807FD680")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	internal int lastFrameRendered
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x7FD7C0", Offset = "0x7FC1C0", VA = "0x1807FD7C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x810430", Offset = "0x80EE30", VA = "0x180810430")]
	private PrepassDescriptor(PrepassTextureType prepassTextureType)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x810410", Offset = "0x80EE10", VA = "0x180810410")]
	private void MarkPrepassRendered()
	{
	}
}
