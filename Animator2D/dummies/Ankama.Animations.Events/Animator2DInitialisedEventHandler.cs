using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x200005D")]
[PublicAPI]
public delegate void Animator2DInitialisedEventHandler(object sender, Animator2DInitialisedEventArgs e);
