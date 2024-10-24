using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x2000046")]
public static class FlashFiltersHelper
{
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<FlashFilters> s_flashFiltersPool;

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x80B030", Offset = "0x809A30", VA = "0x18080B030")]
	private static FlashFilters GetFlashFilters()
	{
		return default(FlashFilters);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x80B120", Offset = "0x809B20", VA = "0x18080B120")]
	public static void ReturnFlashFilters(in FlashFilters flashFilters)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x80A8A0", Offset = "0x8092A0", VA = "0x18080A8A0")]
	public static FlashFilters CreateBlur(in BlurFilter settings)
	{
		return default(FlashFilters);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x80A7C0", Offset = "0x8091C0", VA = "0x18080A7C0")]
	public static FlashFilters CreateBlur(float blurX = 4f, float blurY = 4f, int quality = 1)
	{
		return default(FlashFilters);
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x80AE40", Offset = "0x809840", VA = "0x18080AE40")]
	public static FlashFilters CreateGlow(in GlowFilter settings)
	{
		return default(FlashFilters);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x80AF00", Offset = "0x809900", VA = "0x18080AF00")]
	public static FlashFilters CreateGlow(Color color, float alpha = 1f, float blurX = 6f, float blurY = 6f, float strength = 2f, int quality = 1, bool inner = false, bool knockout = false)
	{
		return default(FlashFilters);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x80AD80", Offset = "0x809780", VA = "0x18080AD80")]
	public static FlashFilters CreateDropShadow(in DropShadowFilter settings)
	{
		return default(FlashFilters);
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x80AC20", Offset = "0x809620", VA = "0x18080AC20")]
	public static FlashFilters CreateDropShadow(float distance = 4f, float angle = (float)Math.PI / 4f, [Optional] Color color, float alpha = 1f, float blurX = 4f, float blurY = 4f, float strength = 1f, int quality = 1, bool inner = false, bool knockout = false, bool hideObject = false)
	{
		return default(FlashFilters);
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x80AB60", Offset = "0x809560", VA = "0x18080AB60")]
	public static FlashFilters CreateColorMatrix(in ColorMatrixFilter settings)
	{
		return default(FlashFilters);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x80A960", Offset = "0x809360", VA = "0x18080A960")]
	public static FlashFilters CreateColorMatrix(Vector4 r, Vector4 g, Vector4 b, Vector4 a, Vector4 additive)
	{
		return default(FlashFilters);
	}
}
