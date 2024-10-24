using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ankama.Animations.Events;
using Ankama.Animations.Rendering;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

namespace Ankama.Animations;

[Token(Token = "0x2000018")]
[PublicAPI]
[ExecuteAlways]
public sealed class Animator2D : MonoBehaviour, gvd, IApplyMaterialSortOrder
{
	[Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class guz
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dgjg;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x7F8970", Offset = "0x7F7370", VA = "0x1807F8970")]
		internal bool czm(string a)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x7B90C0", Offset = "0x7B7AC0", VA = "0x1807B90C0")]
		public guz()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x7F8970", Offset = "0x7F7370", VA = "0x1807F8970")]
		internal bool bjzt(string a)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x7F8970", Offset = "0x7F7370", VA = "0x1807F8970")]
		internal bool mnt(string a)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x7F8970", Offset = "0x7F7370", VA = "0x1807F8970")]
		internal bool llx(string a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40000D2")]
	public const string DefaultShader = "Custom/DofusMainShader";

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal AnimatedObjectDefinition definition;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal Dictionary<string, CustomisationSlot> customisationSlots;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal gvb renderingMethod;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	internal Color colorModifier;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	internal int sortingLayerIdInternal;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	internal int sortingOrderInternal;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	internal int overriddenFrameRate;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	internal SkinAsset skin;

	[NonSerialized]
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	internal bool dgjh;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private IAnimator2DRenderer dgji;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private BufferRequest dgjj;

	[NonSerialized]
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string dgjk;

	[NonSerialized]
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool dgjl;

	[NonSerialized]
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool dgjm;

	[NonSerialized]
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
	private bool dgjn;

	[NonSerialized]
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
	private bool dgjo;

	[NonSerialized]
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool dgjp;

	[NonSerialized]
	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string dgjq;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int dgjr;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string dgjs;

	[NonSerialized]
	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Animation dgjt;

	[NonSerialized]
	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float dgju;

	[NonSerialized]
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Animation dgjv;

	[NonSerialized]
	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int dgjw;

	[NonSerialized]
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool dgjx;

	[NonSerialized]
	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float dgjy;

	[NonSerialized]
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Coroutine dgjz;

	[NonSerialized]
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool dgka;

	[NonSerialized]
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private int dgkb;

	[NonSerialized]
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Queue<DelayedEvent> dgkc;

	[NonSerialized]
	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private MeshRenderer dgkd;

	[NonSerialized]
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private MeshFilter dgke;

	[NonSerialized]
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool dgkf;

	[NonSerialized]
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<string> dgkg;

	[NonSerialized]
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Dictionary<string, SkinTransformData> dgkh;

	[NonSerialized]
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private AnimationMaskType dgki;

	[NonSerialized]
	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string dgkj;

	[NonSerialized]
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private FlashFilters dgkk;

	[NonSerialized]
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private List<BackgroundObject> dgkl;

	[NonSerialized]
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private HashSet<string> dgkm;

	[NonSerialized]
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private HashSet<string> dgkn;

	[NonSerialized]
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private bool dgko;

	[NonSerialized]
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private readonly List<string> dgkp;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private MaterialPropertyBlock dgkq;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Dictionary<string, bool> dgkr;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<SkinAsset> dgks;

	[NonSerialized]
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private readonly Color[] dgkt;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly object dgku;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private int dgkv;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public Action<Animator2D> onInitialized;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Action<Animator2D> onCallOnAnimStart;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public Action<Animator2D> onCallOnAnimLoop;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Action<SkinAsset> UnloadSkin;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Action<AnimatedObjectDefinition> UnloadAnimatedObjectDefinition;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private HashSet<gvm> dgkw;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private gve dgkx;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private gve dgky;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static RenderState[] dglb;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly EvaluatedAnimationFrame dglc;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private float dgld;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public float filtersQuality;

	[Token(Token = "0x17000007")]
	[PublicAPI]
	public bool edve
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x7E1F20", Offset = "0x7E0920", VA = "0x1807E1F20", Slot = "14")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x7E1F30", Offset = "0x7E0930", VA = "0x1807E1F30", Slot = "15")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	[PublicAPI]
	public gve edvf
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x7E1F70", Offset = "0x7E0970", VA = "0x1807E1F70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	[PublicAPI]
	public int edvg
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x7E2300", Offset = "0x7E0D00", VA = "0x1807E2300", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000A")]
	[PublicAPI]
	public string edvh
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x7E2310", Offset = "0x7E0D10", VA = "0x1807E2310", Slot = "17")]
		[NotNull]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	[PublicAPI]
	public bool dgkz
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x7E2330", Offset = "0x7E0D30", VA = "0x1807E2330", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x7E2340", Offset = "0x7E0D40", VA = "0x1807E2340", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	[PublicAPI]
	public int edvi
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x7E2350", Offset = "0x7E0D50", VA = "0x1807E2350", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000D")]
	[PublicAPI]
	public int edvj
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x7E23D0", Offset = "0x7E0DD0", VA = "0x1807E23D0", Slot = "21")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x7E23E0", Offset = "0x7E0DE0", VA = "0x1807E23E0", Slot = "22")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	[PublicAPI]
	public string edvk
	{
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x7E2550", Offset = "0x7E0F50", VA = "0x1807E2550", Slot = "23")]
		[NotNull]
		get
		{
			return null;
		}
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x7E2560", Offset = "0x7E0F60", VA = "0x1807E2560")]
		[NotNull]
		private set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	[PublicAPI]
	public bool edvl
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x7E2830", Offset = "0x7E1230", VA = "0x1807E2830", Slot = "24")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x7E2840", Offset = "0x7E1240", VA = "0x1807E2840")]
		private set
		{
		}
	}

	[Token(Token = "0x17000010")]
	[PublicAPI]
	public bool edvm
	{
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x7E2AE0", Offset = "0x7E14E0", VA = "0x1807E2AE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	[PublicAPI]
	public string edvn
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x7E2AF0", Offset = "0x7E14F0", VA = "0x1807E2AF0")]
		[NotNull]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	[PublicAPI]
	public Color edvo
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x7E2B50", Offset = "0x7E1550", VA = "0x1807E2B50", Slot = "25")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x7E2B60", Offset = "0x7E1560", VA = "0x1807E2B60", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	[PublicAPI]
	public int edvp
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x7E2C40", Offset = "0x7E1640", VA = "0x1807E2C40", Slot = "27")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x7E2C50", Offset = "0x7E1650", VA = "0x1807E2C50", Slot = "28")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	[PublicAPI]
	public int edvq
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x7E2CE0", Offset = "0x7E16E0", VA = "0x1807E2CE0", Slot = "29")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x7E2CF0", Offset = "0x7E16F0", VA = "0x1807E2CF0", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	[PublicAPI]
	public bool edvr
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x7E2D80", Offset = "0x7E1780", VA = "0x1807E2D80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x7E2D90", Offset = "0x7E1790", VA = "0x1807E2D90")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public bool dgla
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x7E2E10", Offset = "0x7E1810", VA = "0x1807E2E10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x7E2E20", Offset = "0x7E1820", VA = "0x1807E2E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	[PublicAPI]
	public event Animator2DInitialisedEventHandler Initialised
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x7E1E10", Offset = "0x7E0810", VA = "0x1807E1E10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x7EBFF0", Offset = "0x7EA9F0", VA = "0x1807EBFF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	[PublicAPI]
	public event AnimationLabelChangedEventHandler AnimationLabelChanged
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x7E1C30", Offset = "0x7E0630", VA = "0x1807E1C30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x7EBE10", Offset = "0x7EA810", VA = "0x1807EBE10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	[PublicAPI]
	public event AnimationStartedEventHandler AnimationStarted
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x7E1D70", Offset = "0x7E0770", VA = "0x1807E1D70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x7EBF50", Offset = "0x7EA950", VA = "0x1807EBF50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	[PublicAPI]
	public event AnimationLoopedEventHandler AnimationLooped
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x7E1CD0", Offset = "0x7E06D0", VA = "0x1807E1CD0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x7EBEB0", Offset = "0x7EA8B0", VA = "0x1807EBEB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	[PublicAPI]
	public event AnimationEndedEventHandler AnimationEnded
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x7E1B90", Offset = "0x7E0590", VA = "0x1807E1B90", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x7EBD70", Offset = "0x7EA770", VA = "0x1807EBD70", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x7E1EB0", Offset = "0x7E08B0", VA = "0x1807E1EB0", Slot = "48")]
	public void bjzu()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x7E1EC0", Offset = "0x7E08C0", VA = "0x1807E1EC0")]
	internal void bjzv(bool a)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x7E2E30", Offset = "0x7E1830", VA = "0x1807E2E30")]
	internal void bkaw(EvaluatedAnimationFrame a, Vector3 b, Quaternion c, Vector3 d, float e)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x7E3540", Offset = "0x7E1F40", VA = "0x1807E3540", Slot = "41")]
	public (float, Vector3) bkax()
	{
		return default((float, Vector3));
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x7E43A0", Offset = "0x7E2DA0", VA = "0x1807E43A0")]
	private static Bounds bkay(SubMeshDescriptor a, EvaluatedAnimationFrame b)
	{
		return default(Bounds);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x7E4610", Offset = "0x7E3010", VA = "0x1807E4610")]
	private static Vector3 bkaz(Vector3 a, Quaternion b, Vector3 c, Vector3 d)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x7E4720", Offset = "0x7E3120", VA = "0x1807E4720", Slot = "31")]
	public gva bkba()
	{
		return default(gva);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x7DB700", Offset = "0x7DA100", VA = "0x1807DB700")]
	public AnimatedObjectDefinition bkbb()
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x7E47C0", Offset = "0x7E31C0", VA = "0x1807E47C0")]
	public bool bkbc(string a)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x7E4890", Offset = "0x7E3290", VA = "0x1807E4890", Slot = "33")]
	[PublicAPI]
	public bool bkbd(string a, out int b)
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x7E4960", Offset = "0x7E3360", VA = "0x1807E4960", Slot = "34")]
	[PublicAPI]
	public bool bkbe(string a, StringComparison b, out int c)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x7E4A30", Offset = "0x7E3430", VA = "0x1807E4A30")]
	[PublicAPI]
	public void bkbf(gvb a)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x7E4BF0", Offset = "0x7E35F0", VA = "0x1807E4BF0")]
	[PublicAPI]
	public void bkbg([CanBeNull] AnimatedObjectDefinition value, [Optional] string a, int b = -1)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x7E4D80", Offset = "0x7E3780", VA = "0x1807E4D80")]
	public void bkbh()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x7E4DA0", Offset = "0x7E37A0", VA = "0x1807E4DA0")]
	private void bkbi()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x7E4E10", Offset = "0x7E3810", VA = "0x1807E4E10")]
	private void bkbj(gvb a, AnimatedObjectDefinition b)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x7E0D90", Offset = "0x7DF790", VA = "0x1807E0D90", Slot = "49")]
	public int ApplyMaterialSortOrder(int startIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x7E5000", Offset = "0x7E3A00", VA = "0x1807E5000")]
	public void bkbk(bool a, Vector4 b, Vector4 c)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x7E5100", Offset = "0x7E3B00", VA = "0x1807E5100")]
	public void bkbl(bool a)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x7E5240", Offset = "0x7E3C40", VA = "0x1807E5240")]
	[PublicAPI]
	public int bkbm([NotNull] string customisationSlotName)
	{
		return default(int);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x7E54C0", Offset = "0x7E3EC0", VA = "0x1807E54C0")]
	[PublicAPI]
	[CanBeNull]
	public CustomisationSlot bkbn(int a)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x7E55E0", Offset = "0x7E3FE0", VA = "0x1807E55E0")]
	[PublicAPI]
	public bool bkbo(string a, [CanBeNull] out CustomisationSlot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x7E5690", Offset = "0x7E4090", VA = "0x1807E5690", Slot = "45")]
	public void bkbp()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x7E5710", Offset = "0x7E4110", VA = "0x1807E5710", Slot = "44")]
	public void bkbq(HashSet<string> a)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x7E5960", Offset = "0x7E4360", VA = "0x1807E5960")]
	[PublicAPI]
	public void bkbr(SkinAsset a)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x7E5ED0", Offset = "0x7E48D0", VA = "0x1807E5ED0")]
	private void bkbs(SkinAsset a)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x7E5FA0", Offset = "0x7E49A0", VA = "0x1807E5FA0", Slot = "43")]
	public void bkbt(HashSet<string> a)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x7E60C0", Offset = "0x7E4AC0", VA = "0x1807E60C0")]
	[PublicAPI]
	public void bkbu(Dictionary<string, SkinTransformData> a)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x7E6140", Offset = "0x7E4B40", VA = "0x1807E6140")]
	[PublicAPI]
	public void bkbv(int a, SkinAsset b, SkinAssetPart c)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x7E6480", Offset = "0x7E4E80", VA = "0x1807E6480")]
	[PublicAPI]
	public bool bkbw([NotNull] string customisationSlotName, SkinAsset a, SkinAssetPart b)
	{
		return default(bool);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x7E67C0", Offset = "0x7E51C0", VA = "0x1807E67C0")]
	[PublicAPI]
	public Color bkbx(int a)
	{
		return default(Color);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x7E69A0", Offset = "0x7E53A0", VA = "0x1807E69A0")]
	[PublicAPI]
	public void bkby(int a, Color b)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x7E6AE0", Offset = "0x7E54E0", VA = "0x1807E6AE0")]
	[PublicAPI]
	public void bkbz(string a)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x7E6C80", Offset = "0x7E5680", VA = "0x1807E6C80")]
	[PublicAPI]
	public void bkca()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x7E6CE0", Offset = "0x7E56E0", VA = "0x1807E6CE0")]
	[PublicAPI]
	public void bkcb(in FlashFilters flashFilters)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x7E6D80", Offset = "0x7E5780", VA = "0x1807E6D80")]
	[PublicAPI]
	public unsafe ref FlashFilters bkcc()
	{
		return ref *(FlashFilters*)null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x7E6D90", Offset = "0x7E5790", VA = "0x1807E6D90")]
	[PublicAPI]
	public void bkcd(int a, GameObject b, IApplyMaterialSortOrder c, bool d = false)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x7E6FB0", Offset = "0x7E59B0", VA = "0x1807E6FB0")]
	[PublicAPI]
	public void bkce(int a)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x7E70D0", Offset = "0x7E5AD0", VA = "0x1807E70D0")]
	[PublicAPI]
	public bool bkcf(int a)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x7E7190", Offset = "0x7E5B90", VA = "0x1807E7190")]
	[PublicAPI]
	public void bkcg(Vector3 a)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x7E72C0", Offset = "0x7E5CC0", VA = "0x1807E72C0")]
	[PublicAPI]
	public void bkch(int a, bool b)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x7E73B0", Offset = "0x7E5DB0", VA = "0x1807E73B0")]
	[PublicAPI]
	public void bkci(bool a)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x7E74F0", Offset = "0x7E5EF0", VA = "0x1807E74F0", Slot = "32")]
	[PublicAPI]
	public Rect? bkcj(string a)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x7E7590", Offset = "0x7E5F90", VA = "0x1807E7590", Slot = "35")]
	[PublicAPI]
	public void bkck(string a, bool b, bool c = true, int d = -1)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x7E7B30", Offset = "0x7E6530", VA = "0x1807E7B30")]
	[NotNull]
	[PublicAPI]
	public MaterialPropertyBlock bkcl()
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x7E7C10", Offset = "0x7E6610", VA = "0x1807E7C10")]
	[PublicAPI]
	public void bkcm([NotNull] MaterialPropertyBlock materialPropertyBlock)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x7E7D10", Offset = "0x7E6710", VA = "0x1807E7D10")]
	[PublicAPI]
	public void bkcn(string a)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x7E7E70", Offset = "0x7E6870", VA = "0x1807E7E70")]
	[PublicAPI]
	public void bkco(string a)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x7E7FD0", Offset = "0x7E69D0", VA = "0x1807E7FD0")]
	public bool bkcp(string a)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x7E80E0", Offset = "0x7E6AE0", VA = "0x1807E80E0")]
	public bool bkcq(Vector2 a)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x7E8220", Offset = "0x7E6C20", VA = "0x1807E8220")]
	public bool bkcr(string a, out Bounds b)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x7E85E0", Offset = "0x7E6FE0", VA = "0x1807E85E0")]
	public Bounds bkcs()
	{
		return default(Bounds);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x7E86E0", Offset = "0x7E70E0", VA = "0x1807E86E0")]
	public Bounds bkct()
	{
		return default(Bounds);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x7E0E80", Offset = "0x7DF880", VA = "0x1807E0E80")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x7E10F0", Offset = "0x7DFAF0", VA = "0x1807E10F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x7E10F0", Offset = "0x7DFAF0", VA = "0x1807E10F0", Slot = "42")]
	public void bkcu()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x7E15D0", Offset = "0x7DFFD0", VA = "0x1807E15D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x7E1060", Offset = "0x7DFA60", VA = "0x1807E1060")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x7E0F40", Offset = "0x7DF940", VA = "0x1807E0F40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x7E8940", Offset = "0x7E7340", VA = "0x1807E8940")]
	private void bkcv(int a = -1)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x7DFC10", Offset = "0x7DE610", VA = "0x1807DFC10")]
	public static void bkcw()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x7E1220", Offset = "0x7DFC20", VA = "0x1807E1220")]
	private void Release(bool unloadResources, bool allowReleaseSkins = false)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x7E8D60", Offset = "0x7E7760", VA = "0x1807E8D60")]
	private IAnimator2DRenderer bkcx(AnimatedObjectDefinition a)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x7E8EE0", Offset = "0x7E78E0", VA = "0x1807E8EE0")]
	private Animator2DCustomisableRenderer bkcy(AnimatedObjectDefinition a)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x7E9130", Offset = "0x7E7B30", VA = "0x1807E9130")]
	private void bkcz(AnimatedObjectDefinition a)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x7E94D0", Offset = "0x7E7ED0", VA = "0x1807E94D0")]
	private void bkda(AnimatedObjectDefinition a)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x7E9620", Offset = "0x7E8020", VA = "0x1807E9620")]
	public void bkdb()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x7E9690", Offset = "0x7E8090", VA = "0x1807E9690")]
	private void bkdc()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x7E9820", Offset = "0x7E8220", VA = "0x1807E9820")]
	private void bkdd()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x7E98E0", Offset = "0x7E82E0", VA = "0x1807E98E0")]
	private void bkde()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x7E99A0", Offset = "0x7E83A0", VA = "0x1807E99A0")]
	private void bkdf([NotNull] Animation anim, int a, float b, bool c)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x7E9E70", Offset = "0x7E8870", VA = "0x1807E9E70")]
	private void bkdg()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x7EA230", Offset = "0x7E8C30", VA = "0x1807EA230")]
	internal void bkdh(float a)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x7EA9F0", Offset = "0x7E93F0", VA = "0x1807EA9F0")]
	private void bkdi(guy a, int b)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x7EAAC0", Offset = "0x7E94C0", VA = "0x1807EAAC0")]
	private void bkdj(int a)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x7EAC10", Offset = "0x7E9610", VA = "0x1807EAC10")]
	private void bkdk(bool a)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x7EAF10", Offset = "0x7E9910", VA = "0x1807EAF10")]
	internal void bkdl(int a, [NotNull] guy animationInstance)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x7EB0E0", Offset = "0x7E9AE0", VA = "0x1807EB0E0")]
	private void bkdm()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x7EB190", Offset = "0x7E9B90", VA = "0x1807EB190")]
	private void bkdn(DelayedEvent.gvi a, EventArgs b)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x7EB2A0", Offset = "0x7E9CA0", VA = "0x1807EB2A0")]
	private void bkdo()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x7EB9D0", Offset = "0x7EA3D0", VA = "0x1807EB9D0", Slot = "46")]
	public void bkdp(List<gvm> a)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x7EBB20", Offset = "0x7EA520", VA = "0x1807EBB20", Slot = "47")]
	public void bkdq(int a)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x7E1730", Offset = "0x7E0130", VA = "0x1807E1730")]
	public Animator2D()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x7EBCA0", Offset = "0x7EA6A0", VA = "0x1807EBCA0", Slot = "36")]
	private GameObject bkdr()
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x7EBCB0", Offset = "0x7EA6B0", VA = "0x1807EBCB0", Slot = "37")]
	private Transform bkds()
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x7EBCC0", Offset = "0x7EA6C0", VA = "0x1807EBCC0", Slot = "38")]
	private bool bkdt()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x7EBCD0", Offset = "0x7EA6D0", VA = "0x1807EBCD0", Slot = "39")]
	private void bkdu(bool a)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x7EBCE0", Offset = "0x7EA6E0", VA = "0x1807EBCE0", Slot = "40")]
	private bool bkdv()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x7EBCF0", Offset = "0x7EA6F0", VA = "0x1807EBCF0")]
	[CompilerGenerated]
	private void bkdw(string a)
	{
	}
}
