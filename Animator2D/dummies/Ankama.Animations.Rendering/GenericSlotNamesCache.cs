using System.Collections.Generic;
using Il2CppDummyDll;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000047")]
public static class GenericSlotNamesCache
{
	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, (string skinName, string genericName)> s_genericNamesCache;

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x80CE80", Offset = "0x80B880", VA = "0x18080CE80")]
	public static void TryGetGenericSlotNameFromCache(string slotName, Dictionary<string, Dictionary<string, string>> skinSpecificSlots)
	{
	}
}
