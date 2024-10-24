using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x2000063")]
[PublicAPI]
public delegate void AnimationLoopedEventHandler(object sender, AnimationLoopedEventArgs e);
