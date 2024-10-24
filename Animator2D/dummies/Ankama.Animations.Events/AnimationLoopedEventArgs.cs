using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x2000062")]
[PublicAPI]
public sealed class AnimationLoopedEventArgs : EventArgs
{
	[Token(Token = "0x17000034")]
	[PublicAPI]
	public string dgmh
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x7DB6E0", Offset = "0x7DA0E0", VA = "0x1807DB6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x7FC660", Offset = "0x7FB060", VA = "0x1807FC660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000035")]
	[PublicAPI]
	public float dgmi
	{
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x7FD720", Offset = "0x7FC120", VA = "0x1807FD720")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x7FD730", Offset = "0x7FC130", VA = "0x1807FD730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x7FD740", Offset = "0x7FC140", VA = "0x1807FD740")]
	[PublicAPI]
	public void bkgi(string a, float b = 0f)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x7FD6D0", Offset = "0x7FC0D0", VA = "0x1807FD6D0")]
	public AnimationLoopedEventArgs()
	{
	}
}
