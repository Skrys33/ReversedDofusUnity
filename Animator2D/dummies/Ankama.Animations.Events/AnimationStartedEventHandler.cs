using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x2000061")]
[PublicAPI]
public delegate void AnimationStartedEventHandler(object sender, AnimationStartedEventArgs e);
