using System.Collections.Generic;
using Il2CppDummyDll;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200003F")]
public class ArrayPool<T>
{
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, List<T[]>> m_sizesToArrays;

	[Token(Token = "0x60001D4")]
	public static T[] Get(int size)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	public static T[] GetFromList(List<T> list)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	public static void Release(T[] returnedArray)
	{
	}

	[Token(Token = "0x60001D7")]
	public ArrayPool()
	{
	}
}
