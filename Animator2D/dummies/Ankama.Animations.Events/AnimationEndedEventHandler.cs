using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x2000065")]
[PublicAPI]
public delegate void AnimationEndedEventHandler(object sender, AnimationEndedEventArgs e);
