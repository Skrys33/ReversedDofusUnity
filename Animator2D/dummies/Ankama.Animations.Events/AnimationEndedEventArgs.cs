using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x2000064")]
[PublicAPI]
public sealed class AnimationEndedEventArgs : EventArgs
{
	[Token(Token = "0x17000036")]
	[PublicAPI]
	public string dgmj
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x7DB6E0", Offset = "0x7DA0E0", VA = "0x1807DB6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x7FC660", Offset = "0x7FB060", VA = "0x1807FC660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x7FC660", Offset = "0x7FB060", VA = "0x1807FC660")]
	[PublicAPI]
	public void bkgl(string a)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x7FC610", Offset = "0x7FB010", VA = "0x1807FC610")]
	public AnimationEndedEventArgs()
	{
	}
}
