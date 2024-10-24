using System;
using System.Collections.Generic;
using Ankama.Animations.Events;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

[Token(Token = "0x2000020")]
[PublicAPI]
public interface gvd
{
	[Token(Token = "0x17000017")]
	[PublicAPI]
	bool edve
	{
		[Token(Token = "0x60000ED")]
		get;
		[Token(Token = "0x60000EE")]
		set;
	}

	[Token(Token = "0x17000018")]
	[PublicAPI]
	int edvg
	{
		[Token(Token = "0x60000EF")]
		get;
	}

	[Token(Token = "0x17000019")]
	[PublicAPI]
	string edvh
	{
		[Token(Token = "0x60000F0")]
		get;
	}

	[Token(Token = "0x1700001A")]
	[PublicAPI]
	bool dgkz
	{
		[Token(Token = "0x60000F1")]
		get;
		[Token(Token = "0x60000F2")]
		set;
	}

	[Token(Token = "0x1700001B")]
	[PublicAPI]
	int edvi
	{
		[Token(Token = "0x60000F3")]
		get;
	}

	[Token(Token = "0x1700001C")]
	[PublicAPI]
	int edvj
	{
		[Token(Token = "0x60000F4")]
		get;
		[Token(Token = "0x60000F5")]
		set;
	}

	[Token(Token = "0x1700001D")]
	[PublicAPI]
	string edvk
	{
		[Token(Token = "0x60000F6")]
		get;
	}

	[Token(Token = "0x1700001E")]
	[PublicAPI]
	bool edvl
	{
		[Token(Token = "0x60000F7")]
		get;
	}

	[Token(Token = "0x1700001F")]
	[PublicAPI]
	Color edvo
	{
		[Token(Token = "0x60000F8")]
		get;
		[Token(Token = "0x60000F9")]
		set;
	}

	[Token(Token = "0x17000020")]
	int edvp
	{
		[Token(Token = "0x60000FA")]
		get;
		[Token(Token = "0x60000FB")]
		set;
	}

	[Token(Token = "0x17000021")]
	int edvq
	{
		[Token(Token = "0x60000FC")]
		get;
		[Token(Token = "0x60000FD")]
		set;
	}

	[Token(Token = "0x17000022")]
	GameObject edvs
	{
		[Token(Token = "0x6000103")]
		get;
	}

	[Token(Token = "0x17000023")]
	Transform edvt
	{
		[Token(Token = "0x6000104")]
		get;
	}

	[Token(Token = "0x17000024")]
	bool edvu
	{
		[Token(Token = "0x6000105")]
		get;
		[Token(Token = "0x6000106")]
		set;
	}

	[Token(Token = "0x17000025")]
	bool edvv
	{
		[Token(Token = "0x6000107")]
		get;
	}

	[Token(Token = "0x14000006")]
	[PublicAPI]
	event Animator2DInitialisedEventHandler Initialised;

	[Token(Token = "0x14000007")]
	[PublicAPI]
	event AnimationLabelChangedEventHandler AnimationLabelChanged;

	[Token(Token = "0x14000008")]
	[PublicAPI]
	event AnimationStartedEventHandler AnimationStarted;

	[Token(Token = "0x14000009")]
	[PublicAPI]
	event AnimationLoopedEventHandler AnimationLooped;

	[Token(Token = "0x1400000A")]
	[PublicAPI]
	event AnimationEndedEventHandler AnimationEnded;

	[Token(Token = "0x60000FE")]
	gva bkba();

	[Token(Token = "0x60000FF")]
	Rect? bkcj(string a);

	[Token(Token = "0x6000100")]
	bool bkbd(string a, out int b);

	[Token(Token = "0x6000101")]
	[PublicAPI]
	bool bkbe(string a, StringComparison b, out int c);

	[Token(Token = "0x6000102")]
	[PublicAPI]
	void bkck([NotNull] string animName, bool a, bool b = true, int c = -1);

	[Token(Token = "0x6000108")]
	(float, Vector3) bkax();

	[Token(Token = "0x6000109")]
	void bkcu();

	[Token(Token = "0x600010A")]
	void bkbt(HashSet<string> a);

	[Token(Token = "0x600010B")]
	void bkbq(HashSet<string> a);

	[Token(Token = "0x600010C")]
	void bkbp();

	[Token(Token = "0x600010D")]
	void bkdp(List<gvm> a);

	[Token(Token = "0x600010E")]
	void bkdq(int a);

	[Token(Token = "0x600010F")]
	void bjzu();
}
