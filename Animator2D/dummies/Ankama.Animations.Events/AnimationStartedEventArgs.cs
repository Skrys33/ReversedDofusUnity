using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x2000060")]
[PublicAPI]
public sealed class AnimationStartedEventArgs : EventArgs
{
	[Token(Token = "0x17000031")]
	[PublicAPI]
	public string dgme
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x7DB6E0", Offset = "0x7DA0E0", VA = "0x1807DB6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x7FC660", Offset = "0x7FB060", VA = "0x1807FC660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000032")]
	[PublicAPI]
	public string dgmf
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x7DB6F0", Offset = "0x7DA0F0", VA = "0x1807DB6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x7FD680", Offset = "0x7FC080", VA = "0x1807FD680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000033")]
	[PublicAPI]
	public int dgmg
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x7FD7C0", Offset = "0x7FC1C0", VA = "0x1807FD7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x7FD7D0", Offset = "0x7FC1D0", VA = "0x1807FD7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x7FD7E0", Offset = "0x7FC1E0", VA = "0x1807FD7E0")]
	[PublicAPI]
	public void bkgd(string a, string b, int c)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x7FD770", Offset = "0x7FC170", VA = "0x1807FD770")]
	public AnimationStartedEventArgs()
	{
	}
}
