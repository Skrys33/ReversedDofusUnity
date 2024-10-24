using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ankama.Animations.Rendering;

[Token(Token = "0x200002D")]
internal static class AnimationEvaluationHelper
{
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x7FCF40", Offset = "0x7FB940", VA = "0x1807FCF40")]
	public static void InvertTransformYAxisInPlace(float[] transform)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x7FCFA0", Offset = "0x7FB9A0", VA = "0x1807FCFA0")]
	public static AnimTransform InvertTransformYAxis(AnimTransform transform)
	{
		return default(AnimTransform);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x7FCAD0", Offset = "0x7FB4D0", VA = "0x1807FCAD0")]
	public static void ConcatenateTransform(AnimTransform parent, AnimTransform child, out AnimTransform destination)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x7FC960", Offset = "0x7FB360", VA = "0x1807FC960")]
	public static void ConcatenateTransform(RenderState parentRenderstate, AnimTransform childTransform, out AnimTransform destination)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x7FC800", Offset = "0x7FB200", VA = "0x1807FC800")]
	public static RenderState ApplyTransformToRenderState(RenderState renderState, AnimTransform transform)
	{
		return default(RenderState);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x7FD100", Offset = "0x7FBB00", VA = "0x1807FD100")]
	private static AnimationGeometryVertex TransformVertex(in RenderState renderState, AnimationGeometryVertex vertex)
	{
		return default(AnimationGeometryVertex);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x7FD180", Offset = "0x7FBB80", VA = "0x1807FD180")]
	public static Bounds TransformVerticesIntoList(List<AnimationGeometryVertex> destination, ReadOnlySpan<AnimationGeometryVertex> source, in RenderState renderState)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x7FD010", Offset = "0x7FBA10", VA = "0x1807FD010")]
	public static void OffsetIndicesIntoList(List<ushort> destination, ReadOnlySpan<ushort> source, ushort offset)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x7FCC00", Offset = "0x7FB600", VA = "0x1807FCC00")]
	public static void ConsumeBuffersIntoMesh(Mesh destinationMesh, List<AnimationGeometryVertex> vertexBuffer, List<ushort> triangleBuffer, Bounds bounds, List<SubMeshDescriptor> subMeshes, List<MaterialDescriptor> materialDescriptors)
	{
	}
}
