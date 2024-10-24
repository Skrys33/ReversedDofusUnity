using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200003D")]
internal struct Animator2DStateCache
{
	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x0")]
	private int m_animator2DInstanceId;

	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x4")]
	private int m_definitionInstanceId;

	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x8")]
	private string m_animationName;

	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x10")]
	private int m_currentFrame;

	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x14")]
	private int m_sortingOrder;

	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x18")]
	private Color m_color;

	[Token(Token = "0x17000028")]
	public int Animator2DInstanceId
	{
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x808F60", Offset = "0x807960", VA = "0x180808F60")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x808EE0", Offset = "0x8078E0", VA = "0x180808EE0")]
	public Animator2DStateCache(Animator2D sourceAnimator)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x808DE0", Offset = "0x8077E0", VA = "0x180808DE0")]
	public bool CacheIsValid(Animator2D sourceAnimator)
	{
		return default(bool);
	}
}
