using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Ankama.Animations.Events;

[Token(Token = "0x200005F")]
[PublicAPI]
public delegate void AnimationLabelChangedEventHandler(object sender, AnimationLabelChangedEventArgs e);
