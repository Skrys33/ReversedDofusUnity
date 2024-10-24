using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace Ankama.Animations;

[Token(Token = "0x2000010")]
[PublicAPI]
[PreferBinarySerialization]
public sealed class AnimatedObjectDefinition : ScriptableObject, ISerializationCallbackReceiver
{
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x18")]
	[PublicAPI]
	public string defaultAnimationName;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x20")]
	[PublicAPI]
	public bool defaultAnimationLoops;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	internal int defaultFrameRate;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal short maxNodeCount;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal string[] exposedNodeNames;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	internal MaskableNode[] maskableNodes;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x48")]
	public SkinAsset boneAsset;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x50")]
	public SkinAssetPartPair[] graphics;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	internal Animation[] animations;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	internal string[] blankAnimations;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x68")]
	private gve m_namedTransformRepository;

	[Token(Token = "0x17000002")]
	public Dictionary<string, string> eduz
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x7DFCA0", Offset = "0x7DE6A0", VA = "0x1807DFCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x7DFCB0", Offset = "0x7DE6B0", VA = "0x1807DFCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public gve edva
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x7DFCC0", Offset = "0x7DE6C0", VA = "0x1807DFCC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	[PublicAPI]
	public int edvb
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x7E0180", Offset = "0x7DEB80", VA = "0x1807E0180")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	[PublicAPI]
	public int edvc
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7E01F0", Offset = "0x7DEBF0", VA = "0x1807E01F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x7DFCF0", Offset = "0x7DE6F0", VA = "0x1807DFCF0")]
	internal void bjzc()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x7DFFD0", Offset = "0x7DE9D0", VA = "0x1807DFFD0")]
	private void bjzd()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x7E01A0", Offset = "0x7DEBA0", VA = "0x1807E01A0")]
	[PublicAPI]
	[NotNull]
	public string bjzf(int a)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x7E01E0", Offset = "0x7DEBE0", VA = "0x1807E01E0")]
	[PublicAPI]
	public string[] bjzg()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x7E0210", Offset = "0x7DEC10", VA = "0x1807E0210")]
	[PublicAPI]
	[NotNull]
	public string bjzi(int a)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x7E0240", Offset = "0x7DEC40", VA = "0x1807E0240")]
	private bool bjzj(out Texture a)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7E0410", Offset = "0x7DEE10", VA = "0x1807E0410")]
	internal bool bjzk(out Material a)
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x7E0500", Offset = "0x7DEF00", VA = "0x1807E0500")]
	internal Animation bjzl()
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x7E0720", Offset = "0x7DF120", VA = "0x1807E0720")]
	public bool bjzm(string a, out int b, out int c)
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x7E07B0", Offset = "0x7DF1B0", VA = "0x1807E07B0")]
	internal Animation bjzn(string a)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7E0850", Offset = "0x7DF250", VA = "0x1807E0850")]
	public int bjzo(string a)
	{
		return default(int);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x7DFC10", Offset = "0x7DE610", VA = "0x1807DFC10", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x7DFC00", Offset = "0x7DE600", VA = "0x1807DFC00", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x7DFC20", Offset = "0x7DE620", VA = "0x1807DFC20")]
	public AnimatedObjectDefinition()
	{
	}
}
