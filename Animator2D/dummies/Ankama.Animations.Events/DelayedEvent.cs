using System;
using Il2CppDummyDll;

namespace Ankama.Animations.Events;

[Token(Token = "0x200005A")]
internal readonly struct DelayedEvent
{
	[Token(Token = "0x200005B")]
	public enum gvi
	{
		[Token(Token = "0x4000253")]
		Initialised,
		[Token(Token = "0x4000254")]
		AnimationStarted,
		[Token(Token = "0x4000255")]
		AnimationLooped,
		[Token(Token = "0x4000256")]
		LabelChanged,
		[Token(Token = "0x4000257")]
		AnimationEnded
	}

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x0")]
	public readonly gvi type;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x8")]
	public readonly EventArgs args;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x7E09B0", Offset = "0x7DF3B0", VA = "0x1807E09B0")]
	public DelayedEvent(gvi eventType, EventArgs eventArgs)
	{
	}
}
