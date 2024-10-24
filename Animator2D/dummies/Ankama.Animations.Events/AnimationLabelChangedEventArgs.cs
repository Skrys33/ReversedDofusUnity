using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x200005E")]
[PublicAPI]
public sealed class AnimationLabelChangedEventArgs : EventArgs
{
	[Token(Token = "0x1700002F")]
	[PublicAPI]
	public string dgmc
	{
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x7DB6E0", Offset = "0x7DA0E0", VA = "0x1807DB6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x7FC660", Offset = "0x7FB060", VA = "0x1807FC660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000030")]
	[PublicAPI]
	public string dgmd
	{
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x7DB6F0", Offset = "0x7DA0F0", VA = "0x1807DB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x7FD680", Offset = "0x7FC080", VA = "0x1807FD680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x7FD690", Offset = "0x7FC090", VA = "0x1807FD690")]
	[PublicAPI]
	public void bkfw(string a, string b)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x7FD630", Offset = "0x7FC030", VA = "0x1807FD630")]
	public AnimationLabelChangedEventArgs()
	{
	}
}
