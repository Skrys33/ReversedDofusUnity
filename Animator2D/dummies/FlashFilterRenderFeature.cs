using System;
using System.Collections.Generic;
using System.Threading;
using Ankama.Animations.Rendering;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Token(Token = "0x2000002")]
public class FlashFilterRenderFeature : ScriptableRendererFeature
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public class FilterSettings
	{
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x10")]
		public Material animator2DMaterial;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x18")]
		public Material compositeMaterial;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x20")]
		public Material blurMaterial;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x28")]
		public Material shadowGlowMaterial;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x30")]
		public Material stencilMaterial;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x38")]
		public float currentZoom;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x7EC0F0", Offset = "0x7EAAF0", VA = "0x1807EC0F0")]
		public FilterSettings()
		{
		}
	}

	[Token(Token = "0x2000004")]
	private struct SourceSymbolData
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x0")]
		public int subMeshIndex;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x4")]
		public Bounds bounds;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x20")]
		public Texture texture;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x28")]
		public uint textureId;
	}

	[Token(Token = "0x2000005")]
	private struct FilterRenderRequest<T>
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		public SourceSymbolData sourceSymbolData;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		public T filterSettings;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		public RenderTexture destinationTexture;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		public uint destinationTextureId;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		public float zoomScale;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x0")]
		public Color materialColor;
	}

	[Token(Token = "0x2000006")]
	private struct StencilRenderRequest
	{
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x0")]
		public int compositeSubMeshIndex;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x4")]
		public int compositeSubMeshCount;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x8")]
		public int stencilSubMeshIndex;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xC")]
		public int materialListIndex;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x10")]
		public Bounds stencilBounds;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x28")]
		public float zoomScale;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x2C")]
		public bool flipped;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		public uint destinationTextureId;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x38")]
		public Texture destinationTexture;
	}

	[Token(Token = "0x2000007")]
	internal struct EffectResultBuffered
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x0")]
		public AnimationGeometryVertex[] verts;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x8")]
		public ushort[] indices;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		public uint textureRequestId;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x14")]
		public Bounds bounds;
	}

	[Token(Token = "0x2000008")]
	internal struct ResultTextureRequest
	{
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		public uint id;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x4")]
		public int width;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x8")]
		public int height;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		public RenderTexture texture;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x18")]
		public bool textureTaken;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x7F76F0", Offset = "0x7F60F0", VA = "0x1807F76F0")]
		public ResultTextureRequest(uint id, int width, int height)
		{
		}
	}

	[Token(Token = "0x2000009")]
	internal enum gur
	{
		[Token(Token = "0x4000045")]
		Blur,
		[Token(Token = "0x4000046")]
		Glow,
		[Token(Token = "0x4000047")]
		DropShadow,
		[Token(Token = "0x4000048")]
		ColorMatrix,
		[Token(Token = "0x4000049")]
		Stencil
	}

	[Token(Token = "0x200000A")]
	private class FlashFilterPass : ScriptableRenderPass
	{
		[Token(Token = "0x200000B")]
		private struct FinalBlitVertex
		{
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 pos;

			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 uv;

			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x0")]
			public static readonly VertexAttributeDescriptor[] s_layout;
		}

		[Token(Token = "0x200000C")]
		private static class gus
		{
			[Token(Token = "0x4000076")]
			public const string dggu = "FlashFilterPass";

			[Token(Token = "0x4000077")]
			public const string dggv = "FilterActions.Composite";

			[Token(Token = "0x4000078")]
			public const string dggw = "FilterActions.Blur";

			[Token(Token = "0x4000079")]
			public const string dggx = "FilterActions.GlowDropShadow";

			[Token(Token = "0x400007A")]
			public const string dggy = "FilterActions.Stencil";

			[Token(Token = "0x400007B")]
			public const string dggz = "FilterActions.ColorMatrix";

			[Token(Token = "0x400007C")]
			public const string dgha = "CompositeMeshToTarget";

			[Token(Token = "0x400007D")]
			public const string dghb = "Copy Bounds";

			[Token(Token = "0x400007E")]
			public const string dghc = "Apply Mask";

			[Token(Token = "0x400007F")]
			public const string dghd = "Glow";

			[Token(Token = "0x4000080")]
			public const string dghe = "DropShadow";

			[Token(Token = "0x4000081")]
			public const string dghf = "Blur";

			[Token(Token = "0x4000082")]
			public const string dghg = "ColorMatrix";
		}

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xE0")]
		private List<(gur, int)> dghh;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xE8")]
		private List<FilterRenderRequest<BlurFilter>> dghi;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xF0")]
		private List<FilterRenderRequest<GlowFilter>> dghj;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xF8")]
		private List<FilterRenderRequest<DropShadowFilter>> dghk;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x100")]
		private List<FilterRenderRequest<ColorMatrixFilter>> dghl;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x108")]
		private List<StencilRenderRequest> dghm;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x110")]
		private Vector2 dghn;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x118")]
		private Vector2 dgho;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x120")]
		private Material dghp;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x128")]
		private Material dghq;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x130")]
		private Material dghr;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x138")]
		private Material dghs;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x140")]
		private Mesh dght;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x148")]
		private readonly List<Material> dghu;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<List<Material>> dghv;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x158")]
		private List<Material> dghw;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x160")]
		private List<uint> dghx;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x168")]
		private List<Mesh> dghy;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x170")]
		private int dghz;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x178")]
		private Action<List<uint>> dgia;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x180")]
		private FinalBlitVertex[] dgib;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x188")]
		private ushort[] dgic;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int dgid;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] dgie;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int dgif;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int dgig;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int dgih;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int dgii;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int dgij;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int dgik;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string dgil;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int dgim;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int dgin;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int dgio;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly int dgip;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x40")]
		private static readonly int dgiq;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x44")]
		private static readonly int dgir;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x48")]
		private static readonly string dgis;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x50")]
		private static readonly string dgit;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x190")]
		private readonly LocalKeyword dgiu;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x1A8")]
		private readonly LocalKeyword dgiv;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x7EE690", Offset = "0x7ED090", VA = "0x1807EE690")]
		public FlashFilterPass(Material blurMaterial, Material glowDropShadowMaterial, Material compositeMaterial, Material stencilMaterial, Action<List<uint>> onPassComplete)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x7EEAD0", Offset = "0x7ED4D0", VA = "0x1807EEAD0")]
		private RenderTexture bjxe(uint a, List<ResultTextureRequest> b)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		private void bjxf<a>(List<FilterRenderRequest<a>> a, List<ResultTextureRequest> b)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x7EC6C0", Offset = "0x7EB0C0", VA = "0x1807EC6C0", Slot = "6")]
		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x7EEC10", Offset = "0x7ED610", VA = "0x1807EEC10")]
		private void bjxg(SourceSymbolData a)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x7EECD0", Offset = "0x7ED6D0", VA = "0x1807EECD0")]
		private Mesh bjxh(Vector2 a, Vector2 b, Vector2 c)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x7EF2E0", Offset = "0x7EDCE0", VA = "0x1807EF2E0")]
		private RenderTargetIdentifier bjxi(CommandBuffer a, Vector2 b, Vector2 c, Mesh d, Material e, SourceSymbolData f, out Vector2 g, Color h)
		{
			return default(RenderTargetIdentifier);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x7EF4E0", Offset = "0x7EDEE0", VA = "0x1807EF4E0")]
		private static void bjxj(CommandBuffer a, Vector2 b, Vector2 c, Mesh d, Material e, SourceSymbolData f, Color g)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x7EC200", Offset = "0x7EAC00", VA = "0x1807EC200")]
		private void CompositeMeshToTarget(CommandBuffer cmd, Vector2 renderTargetSize, Mesh renderMesh, int subMeshIndex, int subMeshCount, List<Material> materials, int materialIndex, Bounds bounds, float zoomScale)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x7EF900", Offset = "0x7EE300", VA = "0x1807EF900")]
		private void bjxk(CommandBuffer a, RenderTargetIdentifier b, Vector2 c, RenderTargetIdentifier d, Vector2 e, float f, float g, int h, bool i)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x7F03F0", Offset = "0x7EEDF0", VA = "0x1807F03F0")]
		private void bjxl(CommandBuffer a, RenderTargetIdentifier b, int c, RenderTargetIdentifier d, Vector2 e, Color f, float g, float h, float i, bool j, bool k, bool l, float m)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x7F0910", Offset = "0x7EF310", VA = "0x1807F0910")]
		private void bjxm(CommandBuffer a, RenderTargetIdentifier b, RenderTargetIdentifier c, Vector4[] d, Color e)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x7F0B00", Offset = "0x7EF500", VA = "0x1807F0B00")]
		private Material bjxn()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x7F0BE0", Offset = "0x7EF5E0", VA = "0x1807F0BE0")]
		private void bjxo(Material a)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x7F0C90", Offset = "0x7EF690", VA = "0x1807F0C90")]
		private List<Material> bjxp()
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x7F0DB0", Offset = "0x7EF7B0", VA = "0x1807F0DB0")]
		private void bjxq(List<Material> a)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x7EC990", Offset = "0x7EB390", VA = "0x1807EC990", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x7F0EA0", Offset = "0x7EF8A0", VA = "0x1807F0EA0")]
		private void bjxr(CommandBuffer a, StencilRenderRequest b, Vector2 c)
		{
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static readonly uint s_VertexColorWhite;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x4")]
	private static readonly float s_resultTexturePadding;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public FilterSettings settings;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	private bool m_created;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	private FlashFilterPass m_flashFilterPass;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	private Material m_compositeMaterial;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	private List<(gur, int)> m_filterOrder;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x48")]
	private List<FilterRenderRequest<BlurFilter>> m_blurRequests;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	private List<FilterRenderRequest<GlowFilter>> m_glowRequests;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x58")]
	private List<FilterRenderRequest<DropShadowFilter>> m_dropShadowRequests;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x60")]
	private List<FilterRenderRequest<ColorMatrixFilter>> m_colorMatrixRequests;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x68")]
	private List<StencilRenderRequest> m_stencilRequests;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x70")]
	private List<AnimationGeometryVertex> m_meshVertices;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x78")]
	private List<ushort> m_meshIndices;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x80")]
	private List<SubMeshDescriptor> m_subMeshDescriptors;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x88")]
	private Mesh m_renderMesh;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x90")]
	private RenderState m_blankRenderState;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0xF0")]
	private ushort[] m_quadIndicies;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0xF8")]
	private Vector2 m_maxEffectSize;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x100")]
	private MaterialConfigurationService m_materialConfigurationService;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x108")]
	private List<MaterialDescriptor> m_materialRequests;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x110")]
	private List<Material> m_materialsInUse;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x118")]
	private SpinLock m_spinLock;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x120")]
	private Stack<AnimationGeometryVertex[]> m_resultVertexPool;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x128")]
	private List<ResultTextureRequest> m_resultTextureRequests;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x130")]
	private uint m_resultTextureCount;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x138")]
	private List<(Texture, uint)> m_textureDeletionRequests;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x140")]
	private uint m_currentRenderFrame;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x148")]
	private List<Texture> m_resultTexturesUsedInternally;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x8")]
	private static FlashFilterRenderFeature s_flashFilterRenderFeature;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x10")]
	private static readonly List<(int, int)> s_materialSortingList;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x18")]
	private static readonly List<SubMeshDescriptor> s_subMeshDescriptorSortingList;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x20")]
	private static readonly Comparison<(int, int)> s_materialSortComparison;

	[Token(Token = "0x17000001")]
	public static FlashFilterRenderFeature eduy
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x7F2450", Offset = "0x7F0E50", VA = "0x1807F2450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7F24A0", Offset = "0x7F0EA0", VA = "0x1807F24A0")]
	private static AnimationGeometryVertex bjxv(float a, float b, float c, float d)
	{
		return default(AnimationGeometryVertex);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7F2570", Offset = "0x7F0F70", VA = "0x1807F2570")]
	private AnimationGeometryVertex[] bjxw()
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x7F25F0", Offset = "0x7F0FF0", VA = "0x1807F25F0")]
	private EffectResultBuffered bjxx(uint a, Bounds b, float c, Vector2 d)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x7F2980", Offset = "0x7F1380", VA = "0x1807F2980")]
	private static Vector2 bjxy(float a, float b, float c)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x7F29F0", Offset = "0x7F13F0", VA = "0x1807F29F0")]
	private static Bounds bjxz(Bounds a, float b, float c, int d, float e = 0f, float f = 0f, float g = 1f)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7F2CD0", Offset = "0x7F16D0", VA = "0x1807F2CD0")]
	private static Vector2 bjya(Bounds a, float b, float c, int d, float e = 0f, float f = 0f, float g = 1f)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x7F1EB0", Offset = "0x7F08B0", VA = "0x1807F1EB0")]
	public FlashFilterRenderFeature()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7F1870", Offset = "0x7F0270", VA = "0x1807F1870", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7DFC10", Offset = "0x7DE610", VA = "0x1807DFC10", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7DFC10", Offset = "0x7DE610", VA = "0x1807DFC10")]
	private void bjyb(List<uint> a)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7F2DF0", Offset = "0x7F17F0", VA = "0x1807F2DF0")]
	private ResultTextureRequest bjyc(int a, int b)
	{
		return default(ResultTextureRequest);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x7F2F10", Offset = "0x7F1910", VA = "0x1807F2F10")]
	private void bjyd()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7F3070", Offset = "0x7F1A70", VA = "0x1807F3070")]
	private void bjye()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7F3240", Offset = "0x7F1C40", VA = "0x1807F3240")]
	private void bjyf()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7F3390", Offset = "0x7F1D90", VA = "0x1807F3390")]
	private Bounds bjyg(ReadOnlySpan<AnimationGeometryVertex> a, ReadOnlySpan<ushort> b, RenderState c)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7F3570", Offset = "0x7F1F70", VA = "0x1807F3570")]
	private int bjyh(List<AnimationGeometryVertex> a, List<ushort> b, List<SubMeshDescriptor> c, List<SubMeshDescriptor> d)
	{
		return default(int);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7F3BC0", Offset = "0x7F25C0", VA = "0x1807F3BC0")]
	private void bjyi(Texture a)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7F3CC0", Offset = "0x7F26C0", VA = "0x1807F3CC0")]
	private void bjyj()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7F3DB0", Offset = "0x7F27B0", VA = "0x1807F3DB0")]
	public static void bjyk(Texture a)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7F3F30", Offset = "0x7F2930", VA = "0x1807F3F30")]
	private void bjyl(EffectResultBuffered a)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7F3FB0", Offset = "0x7F29B0", VA = "0x1807F3FB0")]
	internal static void bjym(EffectResultBuffered a)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x7F41C0", Offset = "0x7F2BC0", VA = "0x1807F41C0")]
	internal static Texture bjyn(uint a)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x7F4510", Offset = "0x7F2F10", VA = "0x1807F4510")]
	private Texture bjyo(uint a)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x7F46E0", Offset = "0x7F30E0", VA = "0x1807F46E0")]
	private EffectResultBuffered bjyp(BlurFilter a, RenderState b, ReadOnlySpan<AnimationGeometryVertex> c, ReadOnlySpan<ushort> d, Texture e, uint f, float g, Color h)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x7F4C90", Offset = "0x7F3690", VA = "0x1807F4C90")]
	private EffectResultBuffered bjyq(GlowFilter a, RenderState b, ReadOnlySpan<AnimationGeometryVertex> c, ReadOnlySpan<ushort> d, Texture e, uint f, float g, Color h)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x7F5250", Offset = "0x7F3C50", VA = "0x1807F5250")]
	private EffectResultBuffered bjyr(DropShadowFilter a, RenderState b, ReadOnlySpan<AnimationGeometryVertex> c, ReadOnlySpan<ushort> d, Texture e, uint f, float g, Color h)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7F5820", Offset = "0x7F4220", VA = "0x1807F5820")]
	private EffectResultBuffered bjys(ColorMatrixFilter a, RenderState b, ReadOnlySpan<AnimationGeometryVertex> c, ReadOnlySpan<ushort> d, Texture e, uint f, float g, Color h)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7F5D70", Offset = "0x7F4770", VA = "0x1807F5D70")]
	private EffectResultBuffered bjyt(List<AnimationGeometryVertex> a, List<ushort> b, int c, List<SubMeshDescriptor> d, List<SubMeshDescriptor> e, int f, Bounds g, bool h, float i)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7F61B0", Offset = "0x7F4BB0", VA = "0x1807F61B0")]
	private EffectResultBuffered bjyu(List<AnimationGeometryVertex> a, List<ushort> b, List<MaterialDescriptor> c, List<SubMeshDescriptor> d, List<SubMeshDescriptor> e, int f, Bounds g, bool h, float i)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7F67A0", Offset = "0x7F51A0", VA = "0x1807F67A0")]
	private EffectResultBuffered bjyv(List<AnimationGeometryVertex> a, List<ushort> b, Bounds c, List<MaterialDescriptor> d, List<SubMeshDescriptor> e, bool f, float g)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x7F6850", Offset = "0x7F5250", VA = "0x1807F6850")]
	internal static EffectResultBuffered bjyw(List<AnimationGeometryVertex> a, List<ushort> b, Bounds c, List<MaterialDescriptor> d, List<SubMeshDescriptor> e, bool f, float g)
	{
		return default(EffectResultBuffered);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x7F6AB0", Offset = "0x7F54B0", VA = "0x1807F6AB0")]
	internal static bool bjyx(in FlashFilters flashFilters, List<AnimationGeometryVertex> a, List<ushort> b, Bounds c, List<MaterialDescriptor> d, List<SubMeshDescriptor> e, bool f, float g, Color h, out EffectResultBuffered i)
	{
		return default(bool);
	}
}
