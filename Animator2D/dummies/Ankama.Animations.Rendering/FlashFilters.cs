using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Pool;

namespace Ankama.Animations.Rendering;

[Serializable]
[Token(Token = "0x2000043")]
public struct FlashFilters : IEquatable<FlashFilters>
{
	[Token(Token = "0x2000044")]
	public enum FilterType
	{
		[Token(Token = "0x40001E6")]
		Blur,
		[Token(Token = "0x40001E7")]
		Glow,
		[Token(Token = "0x40001E8")]
		DropShadow,
		[Token(Token = "0x40001E9")]
		ColorMatrix
	}

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public List<FilterType> filterOrder;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public List<BlurFilter> blurFilters;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<GlowFilter> glowFilters;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<DropShadowFilter> dropShadowFilters;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ColorMatrixFilter> colorMatrices;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ThreadLocal<ObjectPool<BlurFilter>> blurPool;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ThreadLocal<ObjectPool<GlowFilter>> glowPool;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ThreadLocal<ObjectPool<DropShadowFilter>> dropShadowPool;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static ThreadLocal<ObjectPool<ColorMatrixFilter>> colorMatrixPool;

	[Token(Token = "0x40001E3")]
	private const int defaultPoolSize = 50;

	[Token(Token = "0x40001E4")]
	private const int maxPoolSize = 100;

	[Token(Token = "0x17000029")]
	public int Count
	{
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x80CE40", Offset = "0x80B840", VA = "0x18080CE40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x80CB20", Offset = "0x80B520", VA = "0x18080CB20")]
	static FlashFilters()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x80C430", Offset = "0x80AE30", VA = "0x18080C430")]
	public static BlurFilter GetPooledBlurFilter()
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x80C600", Offset = "0x80B000", VA = "0x18080C600")]
	public static GlowFilter GetPooledGlowFilter()
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x80C560", Offset = "0x80AF60", VA = "0x18080C560")]
	public static DropShadowFilter GetPooledDropShadowFilter()
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x80C4C0", Offset = "0x80AEC0", VA = "0x18080C4C0")]
	public static ColorMatrixFilter GetPooledColorMatrixFilter()
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x80B870", Offset = "0x80A270", VA = "0x18080B870")]
	private void AddFilterToOrder(FilterType filterType)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x80C960", Offset = "0x80B360", VA = "0x18080C960")]
	private void RemoveFilterFromOrder(FilterType filterType, int index)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x80BEA0", Offset = "0x80A8A0", VA = "0x18080BEA0")]
	public void CopyFrom(in FlashFilters other)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x80BD90", Offset = "0x80A790", VA = "0x18080BD90")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001EE")]
	private void ReturnItemsToPool<T>(List<T> items, ObjectPool<T> pool) where T : class
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x80BBC0", Offset = "0x80A5C0", VA = "0x18080BBC0")]
	public void ClearToPool()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x80B370", Offset = "0x809D70", VA = "0x18080B370")]
	public void AddBlurFilter(in BlurFilter blurFilter)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x80B2A0", Offset = "0x809CA0", VA = "0x18080B2A0")]
	public BlurFilter AddBlurFilter(float blurX = 4f, float blurY = 4f, int quality = 1)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x80C6A0", Offset = "0x80B0A0", VA = "0x18080C6A0")]
	public void RemoveBlurFilter(in BlurFilter blurFilter)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x80BA90", Offset = "0x80A490", VA = "0x18080BA90")]
	public void AddGlowFilter(in GlowFilter glowFilter)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x80B960", Offset = "0x80A360", VA = "0x18080B960")]
	public GlowFilter AddGlowFilter(Color color, float alpha = 1f, float blurX = 6f, float blurY = 6f, float strength = 2f, int quality = 1, bool inner = false, bool knockout = false)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x80CA30", Offset = "0x80B430", VA = "0x18080CA30")]
	public void RemoveGlowFilter(in GlowFilter glowFilter)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x80B5D0", Offset = "0x809FD0", VA = "0x18080B5D0")]
	public void AddDropShadowFilter(in DropShadowFilter dropShadowFilter)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x80B700", Offset = "0x80A100", VA = "0x18080B700")]
	public DropShadowFilter AddDropShadowFilter(float distance = 4f, float angle = (float)Math.PI / 4f, [Optional] Color color, float alpha = 1f, float blurX = 4f, float blurY = 4f, float strength = 1f, int quality = 1, bool inner = false, bool knockout = false, bool hideObject = false)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x80C870", Offset = "0x80B270", VA = "0x18080C870")]
	public void RemoveDropShadowFilter(in DropShadowFilter dropShadowFilter)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x80B4A0", Offset = "0x809EA0", VA = "0x18080B4A0")]
	public void AddColorMatrix(in ColorMatrixFilter colorMatrix)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x80C780", Offset = "0x80B180", VA = "0x18080C780")]
	public void RemoveColorMatrix(in ColorMatrixFilter colorMatrix)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x80C330", Offset = "0x80AD30", VA = "0x18080C330", Slot = "4")]
	public bool Equals(FlashFilters other)
	{
		return default(bool);
	}
}
