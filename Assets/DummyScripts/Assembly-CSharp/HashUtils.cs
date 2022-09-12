﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class HashUtils // TypeDefIndex: 14781
{
	// Fields
	private static float[] _mainThreadfloatArr = new float[1]; // 0x00
	private static float[] _workThreadFloatArr = new float[1]; // 0x08
	private static StringHashOntoHelper _mainThreadStringHashHelper; // 0x10
	private static StringHashOntoHelper _workThreadStringHashHelper; // 0x18

	// Nested types
	private class StringHashOntoHelper // TypeDefIndex: 14782
	{
		// Fields
		public char[] singleChar; // 0x10
		public byte[] encodeRet; // 0x18

		// Constructors
		public StringHashOntoHelper() {} // 0x00000001842D7130-0x00000001842D71E0
	}

	// Constructors
	static HashUtils() {} // 0x0000000181007570-0x0000000181007680

	// Methods
	// [XID] // 0x00000001897153D0-0x00000001897153F0
	public static void TryHashObject(object obj, ref int lastHash) 
	{
		IHashable hashable = obj as IHashable;
		if (hashable != null)
		{
			hashable.ObjectContentHashOnto(ref lastHash);
		}
	} // 0x00000001810074A0-0x0000000181007570
	// [IDTag] // 0x000000018971CE90-0x000000018971CED0
	// [XID] // 0x000000018971CE90-0x000000018971CED0
	public static void ContentHashOnto(int value, ref int lastHash) 
	{
		lastHash ^= value;
	} // 0x0000000180FE21D0-0x0000000180FE2280
	// [IDTag] // 0x0000000189727460-0x00000001897274A0
	// [XID] // 0x0000000189727460-0x00000001897274A0
	public static void ContentHashOnto(uint value, ref int lastHash) {} // 0x0000000180FF46F0-0x0000000180FF47A0
	// [IDTag] // 0x00000001897318A0-0x00000001897318E0
	// [XID] // 0x00000001897318A0-0x00000001897318E0
	public static void ContentHashOnto(ulong value, ref int lastHash) {} // 0x0000000180FF5300-0x0000000180FF53B0
	// [IDTag] // 0x000000018973C390-0x000000018973C3D0
	// [XID] // 0x000000018973C390-0x000000018973C3D0
	public static void ContentHashOnto(double value, ref int lastHash) {} // 0x0000000180FED220-0x0000000180FED300
	// [IDTag] // 0x0000000189746BF0-0x0000000189746C30
	// [XID] // 0x0000000189746BF0-0x0000000189746C30
	public static void ContentHashOnto(byte[] value, ref int lastHash) {} // 0x0000000180FF5B20-0x0000000180FF5C20
	// [IDTag] // 0x0000000189751070-0x00000001897510B0
	// [XID] // 0x0000000189751070-0x00000001897510B0
	public static void ContentHashOnto(byte[] value, int index, int count, ref int lastHash) {} // 0x0000000181007370-0x00000001810074A0
	// [IDTag] // 0x000000018975B5F0-0x000000018975B630
	// [XID] // 0x000000018975B5F0-0x000000018975B630
	private static void ContentHashOnto(float value, float[] floatArr, ref int lastHash) {} // 0x0000000180FE6C60-0x0000000180FE6DB0
	// [IDTag] // 0x0000000189A0C450-0x0000000189A0C490
	// [XID] // 0x0000000189A0C450-0x0000000189A0C490
	public static void ContentHashOnto(float value, ref int lastHash) 
	{
		_mainThreadfloatArr[0] = value;
		lastHash ^= Buffer.GetByte(_mainThreadfloatArr, 0);
		lastHash ^= Buffer.GetByte(_mainThreadfloatArr, 1) << 8;
		lastHash ^= Buffer.GetByte(_mainThreadfloatArr, 2) << 16;
		lastHash ^= Buffer.GetByte(_mainThreadfloatArr, 3) << 24;
	} // 0x0000000180FF70E0-0x0000000180FF72D0
	// [IDTag] // 0x00000001897704F0-0x0000000189770530
	// [XID] // 0x00000001897704F0-0x0000000189770530
	public static void ContentHashOnto(string value, ref int lastHash) 
	{
		if (value == null)
		{
			return;
		}
		for (int i = 0; i < value.Length; i++)
		{
			char c = value[i];
			lastHash ^= c << (i % 2 & 31 & 31);
		}
	} // 0x0000000180FFBFB0-0x0000000180FFC530
	// [IDTag] // 0x000000018977AC10-0x000000018977AC50
	// [XID] // 0x000000018977AC10-0x000000018977AC50
	public static void ContentHashOnto(bool value, ref int lastHash) 
	{
		lastHash ^= ((!value) ? 0 : 1);
	} // 0x0000000180FEC8D0-0x0000000180FEC980
	// [IDTag] // 0x00000001897854C0-0x0000000189785500
	// [XID] // 0x00000001897854C0-0x0000000189785500
	public static void ContentHashOnto(IHashable value, ref int lastHash) 
	{
		value.ObjectContentHashOnto(ref lastHash);
	} // 0x0000000181006090-0x0000000181006150
	// [XID] // 0x000000018978FA10-0x000000018978FA30
	public static void ContentHashOntoFallback(object obj, ref int lastHash) 
	{
		if (obj is int)
		{
			ContentHashOnto((int)obj, ref lastHash);
		}
		else if (obj is bool)
		{
			ContentHashOnto((bool)obj, ref lastHash);
		}
		else if (obj is float)
		{
			ContentHashOnto((float)obj, ref lastHash);
		}
		else if (obj is string)
		{
			ContentHashOnto((string)obj, ref lastHash);
		}
		else if (obj is IHashable)
		{
			ContentHashOnto((IHashable)obj, ref lastHash);
		}
	} // 0x0000000180FD89D0-0x0000000180FD8C90
	// [IDTag] // 0x00000001897971B0-0x00000001897971F0
	// [XID] // 0x00000001897971B0-0x00000001897971F0
	public static void ContentHashOnto(SimpleSafeInt8[] array, ref int lastHash) {} // 0x00000001810040E0-0x0000000181004240
	// [IDTag] // 0x00000001897A1F50-0x00000001897A1F90
	// [XID] // 0x00000001897A1F50-0x00000001897A1F90
	public static void ContentHashOnto(SimpleSafeUInt8[] array, ref int lastHash) {} // 0x0000000180FFAB60-0x0000000180FFACC0
	// [IDTag] // 0x00000001897AC730-0x00000001897AC770
	// [XID] // 0x00000001897AC730-0x00000001897AC770
	public static void ContentHashOnto(SimpleSafeInt16[] array, ref int lastHash) {} // 0x0000000180FE86A0-0x0000000180FE8800
	// [IDTag] // 0x00000001897B7770-0x00000001897B77B0
	// [XID] // 0x00000001897B7770-0x00000001897B77B0
	public static void ContentHashOnto(SimpleSafeUInt16[] array, ref int lastHash) {} // 0x0000000180FF7FB0-0x0000000180FF8110
	[BlackList] // 0x00000001897C21E0-0x00000001897C2230
	// [IDTag] // 0x00000001897C21E0-0x00000001897C2230
	// [XID] // 0x00000001897C21E0-0x00000001897C2230
	public static void ContentHashOnto(AudioStateOp[] arr, ref int hash_code) {} // 0x0000000180FF6FD0-0x0000000180FF70E0
	[BlackList] // 0x00000001897CFA00-0x00000001897CFA50
	// [IDTag] // 0x00000001897CFA00-0x00000001897CFA50
	// [XID] // 0x00000001897CFA00-0x00000001897CFA50
	public static void ContentHashOnto(ConfigAbility[] arr, ref int hash_code) {} // 0x0000000180FEEF90-0x0000000180FEF0A0
	[BlackList] // 0x00000001897DD180-0x00000001897DD1D0
	// [IDTag] // 0x00000001897DD180-0x00000001897DD1D0
	// [XID] // 0x00000001897DD180-0x00000001897DD1D0
	public static void ContentHashOnto(Dictionary<string, ConfigAbility> dict, ref int hash_code) {} // 0x0000000180FF2F80-0x0000000180FF3190
	[BlackList] // 0x00000001897EAB60-0x00000001897EABB0
	// [IDTag] // 0x00000001897EAB60-0x00000001897EABB0
	// [XID] // 0x00000001897EAB60-0x00000001897EABB0
	public static void ContentHashOnto(Dictionary<string, ConfigAbility>[] arr, ref int hash_code) {} // 0x0000000180FEB820-0x0000000180FEB940
	[BlackList] // 0x00000001897F8700-0x00000001897F8750
	// [IDTag] // 0x00000001897F8700-0x00000001897F8750
	// [XID] // 0x00000001897F8700-0x00000001897F8750
	public static void ContentHashOnto(ConfigAbilityTask[] arr, ref int hash_code) {} // 0x0000000180FFB010-0x0000000180FFB120
	[BlackList] // 0x0000000189805970-0x00000001898059C0
	// [IDTag] // 0x0000000189805970-0x00000001898059C0
	// [XID] // 0x0000000189805970-0x00000001898059C0
	public static void ContentHashOnto(ConfigAbilitySystem[] arr, ref int hash_code) {} // 0x0000000180FEEC70-0x0000000180FEED80
	[BlackList] // 0x00000001898130F0-0x0000000189813140
	// [IDTag] // 0x00000001898130F0-0x0000000189813140
	// [XID] // 0x00000001898130F0-0x0000000189813140
	public static void ContentHashOnto(ConfigAbilityAction[] arr, ref int hash_code) {} // 0x0000000180FE2BB0-0x0000000180FE2CC0
	[BlackList] // 0x0000000189820E20-0x0000000189820E70
	// [IDTag] // 0x0000000189820E20-0x0000000189820E70
	// [XID] // 0x0000000189820E20-0x0000000189820E70
	public static void ContentHashOnto(ConfigAbilityAction[][] arr, ref int hash_code) {} // 0x0000000180FFB760-0x0000000180FFB880
	[BlackList] // 0x000000018982E060-0x000000018982E0B0
	// [IDTag] // 0x000000018982E060-0x000000018982E0B0
	// [XID] // 0x000000018982E060-0x000000018982E0B0
	public static void ContentHashOnto(Dictionary<int, ConfigActionTokenChannel> dict, ref int hash_code) {} // 0x0000000181002DF0-0x0000000181003000
	[BlackList] // 0x000000018983B3E0-0x000000018983B430
	// [IDTag] // 0x000000018983B3E0-0x000000018983B430
	// [XID] // 0x000000018983B3E0-0x000000018983B430
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigActionTokenChannel> dict, ref int hash_code) {} // 0x0000000180FE7310-0x0000000180FE7550
	[BlackList] // 0x0000000189848640-0x0000000189848690
	// [IDTag] // 0x0000000189848640-0x0000000189848690
	// [XID] // 0x0000000189848640-0x0000000189848690
	public static void ContentHashOnto(Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> dict, ref int hash_code) {} // 0x0000000180FE2DD0-0x0000000180FE2FE0
	[BlackList] // 0x0000000189855A80-0x0000000189855AD0
	// [IDTag] // 0x0000000189855A80-0x0000000189855AD0
	// [XID] // 0x0000000189855A80-0x0000000189855AD0
	public static void ContentHashOnto(Dictionary<ActionTokenSourceType, Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup>> dict, ref int hash_code) {} // 0x0000000180FDC200-0x0000000180FDC400
	[BlackList] // 0x0000000189863200-0x0000000189863250
	// [IDTag] // 0x0000000189863200-0x0000000189863250
	// [XID] // 0x0000000189863200-0x0000000189863250
	public static void ContentHashOnto(Dictionary<string, ConfigActionTokenChannelGroupInfo> dict, ref int hash_code) {} // 0x0000000180FEB0B0-0x0000000180FEB2C0
	[BlackList] // 0x0000000189870280-0x00000001898702D0
	// [IDTag] // 0x0000000189870280-0x00000001898702D0
	// [XID] // 0x0000000189870280-0x00000001898702D0
	public static void ContentHashOnto(GlobalValuePair[] arr, ref int hash_code) {} // 0x0000000181004240-0x0000000181004350
	[BlackList] // 0x000000018987DDC0-0x000000018987DE10
	// [IDTag] // 0x000000018987DDC0-0x000000018987DE10
	// [XID] // 0x000000018987DDC0-0x000000018987DE10
	public static void ContentHashOnto(AbilityState[] arr, ref int hash_code) {} // 0x0000000180FF44C0-0x0000000180FF45E0
	[BlackList] // 0x000000018988ABC0-0x000000018988AC10
	// [IDTag] // 0x000000018988ABC0-0x000000018988AC10
	// [XID] // 0x000000018988ABC0-0x000000018988AC10
	public static void ContentHashOnto(Dictionary<string, DynamicArgument> dict, ref int hash_code) {} // 0x0000000181004E00-0x0000000181005010
	[BlackList] // 0x0000000189897F00-0x0000000189897F50
	// [IDTag] // 0x0000000189897F00-0x0000000189897F50
	// [XID] // 0x0000000189897F00-0x0000000189897F50
	public static void ContentHashOnto(Dictionary<string, ConfigAbilityPropertyEntry> dict, ref int hash_code) {} // 0x0000000180FF4AB0-0x0000000180FF4CC0
	[BlackList] // 0x00000001898A5680-0x00000001898A56D0
	// [IDTag] // 0x00000001898A5680-0x00000001898A56D0
	// [XID] // 0x00000001898A5680-0x00000001898A56D0
	public static void ContentHashOnto(Dictionary<string, ConfigAbilityGroup> dict, ref int hash_code) {} // 0x0000000180FE49E0-0x0000000180FE4BF0
	[BlackList] // 0x00000001898B29E0-0x00000001898B2A30
	// [IDTag] // 0x00000001898B29E0-0x00000001898B2A30
	// [XID] // 0x00000001898B29E0-0x00000001898B2A30
	public static void ContentHashOnto(ConfigEntityAbilityEntry[] arr, ref int hash_code) {} // 0x0000000180FE07A0-0x0000000180FE08B0
	[BlackList] // 0x00000001898C03D0-0x00000001898C0420
	// [IDTag] // 0x00000001898C03D0-0x00000001898C0420
	// [XID] // 0x00000001898C03D0-0x00000001898C0420
	public static void ContentHashOnto(ConfigAbilityStateToActions[] arr, ref int hash_code) {} // 0x00000001810064B0-0x00000001810065C0
	[BlackList] // 0x00000001898CD980-0x00000001898CD9D0
	// [IDTag] // 0x00000001898CD980-0x00000001898CD9D0
	// [XID] // 0x00000001898CD980-0x00000001898CD9D0
	public static void ContentHashOnto(ConfigAbilityMixin[] arr, ref int hash_code) {} // 0x0000000180FE2CC0-0x0000000180FE2DD0
	[BlackList] // 0x00000001898DB160-0x00000001898DB1B0
	// [IDTag] // 0x00000001898DB160-0x00000001898DB1B0
	// [XID] // 0x00000001898DB160-0x00000001898DB1B0
	public static void ContentHashOnto(ConfigTornadoZone[] arr, ref int hash_code) {} // 0x0000000180FDF380-0x0000000180FDF490
	[BlackList] // 0x00000001898E93B0-0x00000001898E9400
	// [IDTag] // 0x00000001898E93B0-0x00000001898E9400
	// [XID] // 0x00000001898E93B0-0x00000001898E9400
	public static void ContentHashOnto(DvalinS01PathEffsInfo[] arr, ref int hash_code) {} // 0x0000000180FFDDC0-0x0000000180FFDED0
	[BlackList] // 0x00000001898F6BA0-0x00000001898F6BF0
	// [IDTag] // 0x00000001898F6BA0-0x00000001898F6BF0
	// [XID] // 0x00000001898F6BA0-0x00000001898F6BF0
	public static void ContentHashOnto(Dictionary<ElementType, string> dict, ref int hash_code) {} // 0x0000000180FE05A0-0x0000000180FE07A0
	[BlackList] // 0x0000000189904430-0x0000000189904480
	// [IDTag] // 0x0000000189904430-0x0000000189904480
	// [XID] // 0x0000000189904430-0x0000000189904480
	public static void ContentHashOnto(ElementBatchPredicated[] arr, ref int hash_code) {} // 0x0000000180FF6230-0x0000000180FF6340
	[BlackList] // 0x0000000189911CE0-0x0000000189911D30
	// [IDTag] // 0x0000000189911CE0-0x0000000189911D30
	// [XID] // 0x0000000189911CE0-0x0000000189911D30
	public static void ContentHashOnto(Dictionary<string, ConfigAbilityModifier> dict, ref int hash_code) {} // 0x0000000180FF1FA0-0x0000000180FF21B0
	[BlackList] // 0x000000018991F3A0-0x000000018991F3F0
	// [IDTag] // 0x000000018991F3A0-0x000000018991F3F0
	// [XID] // 0x000000018991F3A0-0x000000018991F3F0
	public static void ContentHashOnto(ConfigAbilityPredicate[] arr, ref int hash_code) {} // 0x0000000180FFF6E0-0x0000000180FFF7F0
	[BlackList] // 0x000000018992CB00-0x000000018992CB50
	// [IDTag] // 0x000000018992CB00-0x000000018992CB50
	// [XID] // 0x000000018992CB00-0x000000018992CB50
	public static void ContentHashOnto(SceneSurfaceType[] arr, ref int hash_code) {} // 0x0000000180FE3DB0-0x0000000180FE3ED0
	[BlackList] // 0x000000018993A600-0x000000018993A650
	// [IDTag] // 0x000000018993A600-0x000000018993A650
	// [XID] // 0x000000018993A600-0x000000018993A650
	public static void ContentHashOnto(SceneType[] arr, ref int hash_code) {} // 0x0000000180FF0DE0-0x0000000180FF0F00
	[BlackList] // 0x0000000189947810-0x0000000189947860
	// [IDTag] // 0x0000000189947810-0x0000000189947860
	// [XID] // 0x0000000189947810-0x0000000189947860
	public static void ContentHashOnto(ConfigMassiveEntityElement[] arr, ref int hash_code) {} // 0x0000000180FE1A60-0x0000000180FE1B70
	[BlackList] // 0x0000000189954E60-0x0000000189954EB0
	// [IDTag] // 0x0000000189954E60-0x0000000189954EB0
	// [XID] // 0x0000000189954E60-0x0000000189954EB0
	public static void ContentHashOnto(ConfigMassiveElementTriggerAction[] arr, ref int hash_code) {} // 0x0000000181006E20-0x0000000181006F30
	[BlackList] // 0x0000000189962B80-0x0000000189962BD0
	// [IDTag] // 0x0000000189962B80-0x0000000189962BD0
	// [XID] // 0x0000000189962B80-0x0000000189962BD0
	public static void ContentHashOnto(AIPoint[] arr, ref int hash_code) {} // 0x0000000180FE3ED0-0x0000000180FE3FE0
	[BlackList] // 0x000000018996FCB0-0x000000018996FD00
	// [IDTag] // 0x000000018996FCB0-0x000000018996FD00
	// [XID] // 0x000000018996FCB0-0x000000018996FD00
	public static void ContentHashOnto(Dictionary<string, ConfigAISensingSetting> dict, ref int hash_code) {} // 0x0000000180FEDDA0-0x0000000180FEDFB0
	[BlackList] // 0x000000018997D120-0x000000018997D170
	// [IDTag] // 0x000000018997D120-0x000000018997D170
	// [XID] // 0x000000018997D120-0x000000018997D170
	public static void ContentHashOnto(NeuronName[] arr, ref int hash_code) {} // 0x0000000180FEEA40-0x0000000180FEEB60
	[BlackList] // 0x000000018998B230-0x000000018998B280
	// [IDTag] // 0x000000018998B230-0x000000018998B280
	// [XID] // 0x000000018998B230-0x000000018998B280
	public static void ContentHashOnto(Dictionary<string, NeuronName[]> dict, ref int hash_code) {} // 0x0000000180FE0DD0-0x0000000180FE0FD0
	[BlackList] // 0x0000000189998F00-0x0000000189998F50
	// [IDTag] // 0x0000000189998F00-0x0000000189998F50
	// [XID] // 0x0000000189998F00-0x0000000189998F50
	public static void ContentHashOnto(Dictionary<ConfigWeatherType, NeuronName[]> dict, ref int hash_code) {} // 0x0000000181003DD0-0x0000000181003FD0
	[BlackList] // 0x00000001899A6860-0x00000001899A68B0
	// [IDTag] // 0x00000001899A6860-0x00000001899A68B0
	// [XID] // 0x00000001899A6860-0x00000001899A68B0
	public static void ContentHashOnto(ConfigAIPoseControlItem[] arr, ref int hash_code) {} // 0x0000000180FF6680-0x0000000180FF6790
	[BlackList] // 0x00000001899B42D0-0x00000001899B4320
	// [IDTag] // 0x00000001899B42D0-0x00000001899B4320
	// [XID] // 0x00000001899B42D0-0x00000001899B4320
	public static void ContentHashOnto(Dictionary<int, ConfigAIReturnToBornPosData> dict, ref int hash_code) {} // 0x0000000180FFC850-0x0000000180FFCA60
	[BlackList] // 0x00000001899C1970-0x00000001899C19C0
	// [IDTag] // 0x00000001899C1970-0x00000001899C19C0
	// [XID] // 0x00000001899C1970-0x00000001899C19C0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIReturnToBornPosData> dict, ref int hash_code) {} // 0x0000000180FDFAC0-0x0000000180FDFD00
	[BlackList] // 0x00000001899CF0E0-0x00000001899CF130
	// [IDTag] // 0x00000001899CF0E0-0x00000001899CF130
	// [XID] // 0x00000001899CF0E0-0x00000001899CF130
	public static void ContentHashOnto(Dictionary<int, ConfigAIWanderData> dict, ref int hash_code) {} // 0x0000000180FDDB60-0x0000000180FDDD70
	[BlackList] // 0x00000001899DC4B0-0x00000001899DC500
	// [IDTag] // 0x00000001899DC4B0-0x00000001899DC500
	// [XID] // 0x00000001899DC4B0-0x00000001899DC500
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIWanderData> dict, ref int hash_code) {} // 0x0000000180FF7920-0x0000000180FF7B60
	[BlackList] // 0x00000001899E9B00-0x00000001899E9B50
	// [IDTag] // 0x00000001899E9B00-0x00000001899E9B50
	// [XID] // 0x00000001899E9B00-0x00000001899E9B50
	public static void ContentHashOnto(Dictionary<int, ConfigAIFollowScriptedPathData> dict, ref int hash_code) {} // 0x0000000180FD8C90-0x0000000180FD8EA0
	[BlackList] // 0x00000001899F7470-0x00000001899F74C0
	// [IDTag] // 0x00000001899F7470-0x00000001899F74C0
	// [XID] // 0x00000001899F7470-0x00000001899F74C0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIFollowScriptedPathData> dict, ref int hash_code) {} // 0x0000000180FDAC30-0x0000000180FDAE70
	[BlackList] // 0x0000000189A048F0-0x0000000189A04940
	// [IDTag] // 0x0000000189A048F0-0x0000000189A04940
	// [XID] // 0x0000000189A048F0-0x0000000189A04940
	public static void ContentHashOnto(Dictionary<int, ConfigAIFollowServerRouteData> dict, ref int hash_code) {} // 0x0000000180FEA0E0-0x0000000180FEA2F0
	[BlackList] // 0x0000000189A11FE0-0x0000000189A12030
	// [IDTag] // 0x0000000189A11FE0-0x0000000189A12030
	// [XID] // 0x0000000189A11FE0-0x0000000189A12030
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIFollowServerRouteData> dict, ref int hash_code) {} // 0x0000000181004AB0-0x0000000181004CF0
	[BlackList] // 0x0000000189A1F250-0x0000000189A1F2A0
	// [IDTag] // 0x0000000189A1F250-0x0000000189A1F2A0
	// [XID] // 0x0000000189A1F250-0x0000000189A1F2A0
	public static void ContentHashOnto(Dictionary<int, ConfigAIInvestigateData> dict, ref int hash_code) {} // 0x0000000181001F70-0x0000000181002180
	[BlackList] // 0x0000000189A2C5B0-0x0000000189A2C600
	// [IDTag] // 0x0000000189A2C5B0-0x0000000189A2C600
	// [XID] // 0x0000000189A2C5B0-0x0000000189A2C600
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIInvestigateData> dict, ref int hash_code) {} // 0x0000000180FF0BA0-0x0000000180FF0DE0
	[BlackList] // 0x0000000189A39DF0-0x0000000189A39E40
	// [IDTag] // 0x0000000189A39DF0-0x0000000189A39E40
	// [XID] // 0x0000000189A39DF0-0x0000000189A39E40
	public static void ContentHashOnto(ConfigAIPickActionPointCriteria[] arr, ref int hash_code) {} // 0x0000000180FFE800-0x0000000180FFE910
	[BlackList] // 0x0000000189A47520-0x0000000189A47570
	// [IDTag] // 0x0000000189A47520-0x0000000189A47570
	// [XID] // 0x0000000189A47520-0x0000000189A47570
	public static void ContentHashOnto(Dictionary<int, ConfigAIReactActionPointData> dict, ref int hash_code) {} // 0x0000000180FF50F0-0x0000000180FF5300
	[BlackList] // 0x0000000189A54C50-0x0000000189A54CA0
	// [IDTag] // 0x0000000189A54C50-0x0000000189A54CA0
	// [XID] // 0x0000000189A54C50-0x0000000189A54CA0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIReactActionPointData> dict, ref int hash_code) {} // 0x0000000180FDB410-0x0000000180FDB650
	[BlackList] // 0x0000000189A622A0-0x0000000189A622F0
	// [IDTag] // 0x0000000189A622A0-0x0000000189A622F0
	// [XID] // 0x0000000189A622A0-0x0000000189A622F0
	public static void ContentHashOnto(Dictionary<int, ConfigAIPatrolFollowData> dict, ref int hash_code) {} // 0x0000000180FF9740-0x0000000180FF9950
	[BlackList] // 0x0000000189A6FEF0-0x0000000189A6FF40
	// [IDTag] // 0x0000000189A6FEF0-0x0000000189A6FF40
	// [XID] // 0x0000000189A6FEF0-0x0000000189A6FF40
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIPatrolFollowData> dict, ref int hash_code) {} // 0x00000001810010C0-0x0000000181001300
	[BlackList] // 0x0000000189A7D940-0x0000000189A7D990
	// [IDTag] // 0x0000000189A7D940-0x0000000189A7D990
	// [XID] // 0x0000000189A7D940-0x0000000189A7D990
	public static void ContentHashOnto(Dictionary<int, ConfigAICombatFollowMoveData> dict, ref int hash_code) {} // 0x0000000181001880-0x0000000181001A90
	[BlackList] // 0x0000000189A8B2E0-0x0000000189A8B330
	// [IDTag] // 0x0000000189A8B2E0-0x0000000189A8B330
	// [XID] // 0x0000000189A8B2E0-0x0000000189A8B330
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAICombatFollowMoveData> dict, ref int hash_code) {} // 0x0000000180FE0030-0x0000000180FE0270
	[BlackList] // 0x0000000189A98CC0-0x0000000189A98D10
	// [IDTag] // 0x0000000189A98CC0-0x0000000189A98D10
	// [XID] // 0x0000000189A98CC0-0x0000000189A98D10
	public static void ContentHashOnto(Dictionary<int, ConfigAIMeleeChargeData> dict, ref int hash_code) {} // 0x0000000180FDA4A0-0x0000000180FDA6B0
	[BlackList] // 0x0000000189AA5F90-0x0000000189AA5FE0
	// [IDTag] // 0x0000000189AA5F90-0x0000000189AA5FE0
	// [XID] // 0x0000000189AA5F90-0x0000000189AA5FE0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIMeleeChargeData> dict, ref int hash_code) {} // 0x0000000180FF8CD0-0x0000000180FF8F10
	[BlackList] // 0x0000000189AB3780-0x0000000189AB37D0
	// [IDTag] // 0x0000000189AB3780-0x0000000189AB37D0
	// [XID] // 0x0000000189AB3780-0x0000000189AB37D0
	public static void ContentHashOnto(Dictionary<int, ConfigAIFacingMoveData> dict, ref int hash_code) {} // 0x0000000180FE8B20-0x0000000180FE8D30
	[BlackList] // 0x0000000189AC10C0-0x0000000189AC1110
	// [IDTag] // 0x0000000189AC10C0-0x0000000189AC1110
	// [XID] // 0x0000000189AC10C0-0x0000000189AC1110
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIFacingMoveData> dict, ref int hash_code) {} // 0x0000000180FEB3D0-0x0000000180FEB610
	[BlackList] // 0x0000000189ACE9E0-0x0000000189ACEA30
	// [IDTag] // 0x0000000189ACE9E0-0x0000000189ACEA30
	// [XID] // 0x0000000189ACE9E0-0x0000000189ACEA30
	public static void ContentHashOnto(Dictionary<int, ConfigAISurroundData> dict, ref int hash_code) {} // 0x0000000180FFB880-0x0000000180FFBA90
	[BlackList] // 0x0000000189ADC8F0-0x0000000189ADC940
	// [IDTag] // 0x0000000189ADC8F0-0x0000000189ADC940
	// [XID] // 0x0000000189ADC8F0-0x0000000189ADC940
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAISurroundData> dict, ref int hash_code) {} // 0x0000000181000E80-0x00000001810010C0
	[BlackList] // 0x0000000189AEA0A0-0x0000000189AEA0F0
	// [IDTag] // 0x0000000189AEA0A0-0x0000000189AEA0F0
	// [XID] // 0x0000000189AEA0A0-0x0000000189AEA0F0
	public static void ContentHashOnto(Dictionary<int, ConfigAIFindBackData> dict, ref int hash_code) {} // 0x0000000180FDF490-0x0000000180FDF6A0
	[BlackList] // 0x0000000189AF7BE0-0x0000000189AF7C30
	// [IDTag] // 0x0000000189AF7BE0-0x0000000189AF7C30
	// [XID] // 0x0000000189AF7BE0-0x0000000189AF7C30
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIFindBackData> dict, ref int hash_code) {} // 0x0000000180FE7EF0-0x0000000180FE8130
	[BlackList] // 0x0000000189B051C0-0x0000000189B05210
	// [IDTag] // 0x0000000189B051C0-0x0000000189B05210
	// [XID] // 0x0000000189B051C0-0x0000000189B05210
	public static void ContentHashOnto(Dictionary<int, ConfigAICombatFixedMoveData> dict, ref int hash_code) {} // 0x0000000180FE7760-0x0000000180FE7970
	[BlackList] // 0x0000000189B12870-0x0000000189B128C0
	// [IDTag] // 0x0000000189B12870-0x0000000189B128C0
	// [XID] // 0x0000000189B12870-0x0000000189B128C0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAICombatFixedMoveData> dict, ref int hash_code) {} // 0x0000000180FFD710-0x0000000180FFD950
	[BlackList] // 0x0000000189B1FB60-0x0000000189B1FBB0
	// [IDTag] // 0x0000000189B1FB60-0x0000000189B1FBB0
	// [XID] // 0x0000000189B1FB60-0x0000000189B1FBB0
	public static void ContentHashOnto(Dictionary<int, ConfigAICrabMoveData> dict, ref int hash_code) {} // 0x0000000180FF0480-0x0000000180FF0690
	[BlackList] // 0x0000000189B2CE80-0x0000000189B2CED0
	// [IDTag] // 0x0000000189B2CE80-0x0000000189B2CED0
	// [XID] // 0x0000000189B2CE80-0x0000000189B2CED0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAICrabMoveData> dict, ref int hash_code) {} // 0x0000000180FEAE70-0x0000000180FEB0B0
	[BlackList] // 0x0000000189B3A5B0-0x0000000189B3A600
	// [IDTag] // 0x0000000189B3A5B0-0x0000000189B3A600
	// [XID] // 0x0000000189B3A5B0-0x0000000189B3A600
	public static void ContentHashOnto(Dictionary<int, ConfigAIFleeData> dict, ref int hash_code) {} // 0x0000000180FE61F0-0x0000000180FE6400
	[BlackList] // 0x0000000189B47F60-0x0000000189B47FB0
	// [IDTag] // 0x0000000189B47F60-0x0000000189B47FB0
	// [XID] // 0x0000000189B47F60-0x0000000189B47FB0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIFleeData> dict, ref int hash_code) {} // 0x0000000180FE8350-0x0000000180FE8590
	[BlackList] // 0x0000000189B556D0-0x0000000189B55720
	// [IDTag] // 0x0000000189B556D0-0x0000000189B55720
	// [XID] // 0x0000000189B556D0-0x0000000189B55720
	public static void ContentHashOnto(Dictionary<int, ConfigAISpacialChaseData> dict, ref int hash_code) {} // 0x0000000180FE10F0-0x0000000180FE1300
	[BlackList] // 0x0000000189B62CC0-0x0000000189B62D10
	// [IDTag] // 0x0000000189B62CC0-0x0000000189B62D10
	// [XID] // 0x0000000189B62CC0-0x0000000189B62D10
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAISpacialChaseData> dict, ref int hash_code) {} // 0x0000000181001530-0x0000000181001770
	[BlackList] // 0x0000000189B70590-0x0000000189B705E0
	// [IDTag] // 0x0000000189B70590-0x0000000189B705E0
	// [XID] // 0x0000000189B70590-0x0000000189B705E0
	public static void ContentHashOnto(Dictionary<int, ConfigAISpacialProbeData> dict, ref int hash_code) {} // 0x0000000180FFBA90-0x0000000180FFBCA0
	[BlackList] // 0x0000000189B7D8F0-0x0000000189B7D940
	// [IDTag] // 0x0000000189B7D8F0-0x0000000189B7D940
	// [XID] // 0x0000000189B7D8F0-0x0000000189B7D940
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAISpacialProbeData> dict, ref int hash_code) {} // 0x0000000181006150-0x0000000181006390
	[BlackList] // 0x0000000189B8AD30-0x0000000189B8AD80
	// [IDTag] // 0x0000000189B8AD30-0x0000000189B8AD80
	// [XID] // 0x0000000189B8AD30-0x0000000189B8AD80
	public static void ContentHashOnto(Dictionary<int, ConfigAISpacialAdjustData> dict, ref int hash_code) {} // 0x0000000180FE1DA0-0x0000000180FE1FB0
	[BlackList] // 0x0000000189B98220-0x0000000189B98270
	// [IDTag] // 0x0000000189B98220-0x0000000189B98270
	// [XID] // 0x0000000189B98220-0x0000000189B98270
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAISpacialAdjustData> dict, ref int hash_code) {} // 0x0000000180FDA7C0-0x0000000180FDAA00
	[BlackList] // 0x0000000189BA58E0-0x0000000189BA5930
	// [IDTag] // 0x0000000189BA58E0-0x0000000189BA5930
	// [XID] // 0x0000000189BA58E0-0x0000000189BA5930
	public static void ContentHashOnto(Dictionary<int, ConfigAIBirdCirclingData> dict, ref int hash_code) {} // 0x0000000180FDC510-0x0000000180FDC720
	[BlackList] // 0x0000000189BB2BE0-0x0000000189BB2C30
	// [IDTag] // 0x0000000189BB2BE0-0x0000000189BB2C30
	// [XID] // 0x0000000189BB2BE0-0x0000000189BB2C30
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIBirdCirclingData> dict, ref int hash_code) {} // 0x0000000180FF3C60-0x0000000180FF3EA0
	[BlackList] // 0x0000000189BC0010-0x0000000189BC0060
	// [IDTag] // 0x0000000189BC0010-0x0000000189BC0060
	// [XID] // 0x0000000189BC0010-0x0000000189BC0060
	public static void ContentHashOnto(Dictionary<int, ConfigAIScriptedMoveToData> dict, ref int hash_code) {} // 0x0000000180FF4DD0-0x0000000180FF4FE0
	[BlackList] // 0x0000000189BCDFD0-0x0000000189BCE020
	// [IDTag] // 0x0000000189BCDFD0-0x0000000189BCE020
	// [XID] // 0x0000000189BCDFD0-0x0000000189BCE020
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIScriptedMoveToData> dict, ref int hash_code) {} // 0x0000000180FF34E0-0x0000000180FF3720
	[BlackList] // 0x0000000189BDB6F0-0x0000000189BDB740
	// [IDTag] // 0x0000000189BDB6F0-0x0000000189BDB740
	// [XID] // 0x0000000189BDB6F0-0x0000000189BDB740
	public static void ContentHashOnto(Dictionary<int, ConfigAILandingData> dict, ref int hash_code) {} // 0x0000000180FEE0E0-0x0000000180FEE2F0
	[BlackList] // 0x00000001895EE1E0-0x00000001895EE230
	// [IDTag] // 0x00000001895EE1E0-0x00000001895EE230
	// [XID] // 0x00000001895EE1E0-0x00000001895EE230
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAILandingData> dict, ref int hash_code) {} // 0x0000000180FFADD0-0x0000000180FFB010
	[BlackList] // 0x00000001895FB7E0-0x00000001895FB830
	// [IDTag] // 0x00000001895FB7E0-0x00000001895FB830
	// [XID] // 0x00000001895FB7E0-0x00000001895FB830
	public static void ContentHashOnto(Dictionary<int, ConfigAIExtractionData> dict, ref int hash_code) {} // 0x0000000180FEF920-0x0000000180FEFB30
	[BlackList] // 0x0000000189609130-0x0000000189609180
	// [IDTag] // 0x0000000189609130-0x0000000189609180
	// [XID] // 0x0000000189609130-0x0000000189609180
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIExtractionData> dict, ref int hash_code) {} // 0x0000000180FF1650-0x0000000180FF1890
	[BlackList] // 0x0000000189616700-0x0000000189616750
	// [IDTag] // 0x0000000189616700-0x0000000189616750
	// [XID] // 0x0000000189616700-0x0000000189616750
	public static void ContentHashOnto(Dictionary<int, ConfigAIBrownianMotionData> dict, ref int hash_code) {} // 0x0000000180FDB770-0x0000000180FDB980
	[BlackList] // 0x0000000189623C60-0x0000000189623CB0
	// [IDTag] // 0x0000000189623C60-0x0000000189623CB0
	// [XID] // 0x0000000189623C60-0x0000000189623CB0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigAIBrownianMotionData> dict, ref int hash_code) {} // 0x0000000180FF3190-0x0000000180FF33D0
	[BlackList] // 0x0000000189631610-0x0000000189631660
	// [IDTag] // 0x0000000189631610-0x0000000189631660
	// [XID] // 0x0000000189631610-0x0000000189631660
	public static void ContentHashOnto(Dictionary<ConfigAICombatPhase, int[]> dict, ref int hash_code) {} // 0x0000000180FFBCA0-0x0000000180FFBEA0
	[BlackList] // 0x000000018963ED60-0x000000018963EDB0
	// [IDTag] // 0x000000018963ED60-0x000000018963EDB0
	// [XID] // 0x000000018963ED60-0x000000018963EDB0
	public static void ContentHashOnto(Dictionary<ConfigAICombatPhase, SimpleSafeInt32[]> dict, ref int hash_code) {} // 0x0000000180FF0080-0x0000000180FF0280
	[BlackList] // 0x000000018964C880-0x000000018964C8D0
	// [IDTag] // 0x000000018964C880-0x000000018964C8D0
	// [XID] // 0x000000018964C880-0x000000018964C8D0
	public static void ContentHashOnto(Dictionary<byte, uint[]> dict, ref int hash_code) {} // 0x0000000181004780-0x0000000181004990
	[BlackList] // 0x0000000189659BD0-0x0000000189659C20
	// [IDTag] // 0x0000000189659BD0-0x0000000189659C20
	// [XID] // 0x0000000189659BD0-0x0000000189659C20
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt8, SimpleSafeUInt32[]> dict, ref int hash_code) {} // 0x0000000180FF57E0-0x0000000180FF5A10
	[BlackList] // 0x0000000189667590-0x00000001896675E0
	// [IDTag] // 0x0000000189667590-0x00000001896675E0
	// [XID] // 0x0000000189667590-0x00000001896675E0
	public static void ContentHashOnto(ConfigAISkillGroupCD[] arr, ref int hash_code) {} // 0x0000000180FE60E0-0x0000000180FE61F0
	[BlackList] // 0x0000000189675270-0x00000001896752C0
	// [IDTag] // 0x0000000189675270-0x00000001896752C0
	// [XID] // 0x0000000189675270-0x00000001896752C0
	public static void ContentHashOnto(Dictionary<string, ConfigAISkill> dict, ref int hash_code) {} // 0x0000000180FF6020-0x0000000180FF6230
	[BlackList] // 0x0000000189682770-0x00000001896827C0
	// [IDTag] // 0x0000000189682770-0x00000001896827C0
	// [XID] // 0x0000000189682770-0x00000001896827C0
	public static void ContentHashOnto(ConfigAIMixinSetBool[] arr, ref int hash_code) {} // 0x0000000180FE3AB0-0x0000000180FE3BC0
	[BlackList] // 0x0000000189690750-0x00000001896907A0
	// [IDTag] // 0x0000000189690750-0x00000001896907A0
	// [XID] // 0x0000000189690750-0x00000001896907A0
	public static void ContentHashOnto(ConfigAIMixinSetInt[] arr, ref int hash_code) {} // 0x0000000181004350-0x0000000181004460
	[BlackList] // 0x000000018969DEF0-0x000000018969DF40
	// [IDTag] // 0x000000018969DEF0-0x000000018969DF40
	// [XID] // 0x000000018969DEF0-0x000000018969DF40
	public static void ContentHashOnto(ConfigAIMixinSetFloat[] arr, ref int hash_code) {} // 0x0000000180FFCA60-0x0000000180FFCB70
	[BlackList] // 0x00000001896AADF0-0x00000001896AAE40
	// [IDTag] // 0x00000001896AADF0-0x00000001896AAE40
	// [XID] // 0x00000001896AADF0-0x00000001896AAE40
	public static void ContentHashOnto(ConfigAIMixinSetAnimatorTrigger[] arr, ref int hash_code) {} // 0x0000000180FE9CB0-0x0000000180FE9DC0
	[BlackList] // 0x00000001896B8230-0x00000001896B8280
	// [IDTag] // 0x00000001896B8230-0x00000001896B8280
	// [XID] // 0x00000001896B8230-0x00000001896B8280
	public static void ContentHashOnto(ConfigAIMixinSetControllerParameter[] arr, ref int hash_code) {} // 0x0000000180FEBC50-0x0000000180FEBD60
	[BlackList] // 0x00000001896C5460-0x00000001896C54B0
	// [IDTag] // 0x00000001896C5460-0x00000001896C54B0
	// [XID] // 0x00000001896C5460-0x00000001896C54B0
	public static void ContentHashOnto(ConfigAIMixinSetControllerCondition[] arr, ref int hash_code) {} // 0x0000000180FF55C0-0x0000000180FF56D0
	[BlackList] // 0x00000001896D26E0-0x00000001896D2730
	// [IDTag] // 0x00000001896D26E0-0x00000001896D2730
	// [XID] // 0x00000001896D26E0-0x00000001896D2730
	public static void ContentHashOnto(Dictionary<string, ConfigAnimationRecurrentSpeech> dict, ref int hash_code) {} // 0x0000000181006A00-0x0000000181006C10
	[BlackList] // 0x00000001896E0080-0x00000001896E00D0
	// [IDTag] // 0x00000001896E0080-0x00000001896E00D0
	// [XID] // 0x00000001896E0080-0x00000001896E00D0
	public static void ContentHashOnto(ConfigBaseAttackPattern[] arr, ref int hash_code) {} // 0x0000000181003780-0x0000000181003890
	[BlackList] // 0x00000001896ED170-0x00000001896ED1C0
	// [IDTag] // 0x00000001896ED170-0x00000001896ED1C0
	// [XID] // 0x00000001896ED170-0x00000001896ED1C0
	public static void ContentHashOnto(Dictionary<string, ConfigBaseAttackPattern> dict, ref int hash_code) {} // 0x0000000180FFE3F0-0x0000000180FFE600
	[BlackList] // 0x00000001896FA8D0-0x00000001896FA920
	// [IDTag] // 0x00000001896FA8D0-0x00000001896FA920
	// [XID] // 0x00000001896FA8D0-0x00000001896FA920
	public static void ContentHashOnto(AudioAmbiencePositionedEvent[] arr, ref int hash_code) {} // 0x0000000180FE4E00-0x0000000180FE4F10
	[BlackList] // 0x0000000189707DF0-0x0000000189707E40
	// [IDTag] // 0x0000000189707DF0-0x0000000189707E40
	// [XID] // 0x0000000189707DF0-0x0000000189707E40
	public static void ContentHashOnto(AudioTreeDataAssetNamePattern[] arr, ref int hash_code) {} // 0x0000000180FF45E0-0x0000000180FF46F0
	[BlackList] // 0x0000000189715380-0x00000001897153D0
	// [IDTag] // 0x0000000189715380-0x00000001897153D0
	// [XID] // 0x0000000189715380-0x00000001897153D0
	public static void ContentHashOnto(ConfigAudioArea2DAmbience[] arr, ref int hash_code) {} // 0x0000000181004670-0x0000000181004780
	[BlackList] // 0x0000000189722BA0-0x0000000189722BF0
	// [IDTag] // 0x0000000189722BA0-0x0000000189722BF0
	// [XID] // 0x0000000189722BA0-0x0000000189722BF0
	public static void ContentHashOnto(AudioPlatformMoveSettings[] arr, ref int hash_code) {} // 0x0000000180FFEF70-0x0000000180FFF0B0
	[BlackList] // 0x00000001897302D0-0x0000000189730320
	// [IDTag] // 0x00000001897302D0-0x0000000189730320
	// [XID] // 0x00000001897302D0-0x0000000189730320
	public static void ContentHashOnto(AudioPlatformMoveSettingsUsagePair[] arr, ref int hash_code) {} // 0x0000000180FE3570-0x0000000180FE3680
	[BlackList] // 0x000000018973DF60-0x000000018973DFB0
	// [IDTag] // 0x000000018973DF60-0x000000018973DFB0
	// [XID] // 0x000000018973DF60-0x000000018973DFB0
	public static void ContentHashOnto(AudioImpactOverrideEvent[] arr, ref int hash_code) {} // 0x0000000180FFE910-0x0000000180FFEA20
	[BlackList] // 0x000000018974B5C0-0x000000018974B610
	// [IDTag] // 0x000000018974B5C0-0x000000018974B610
	// [XID] // 0x000000018974B5C0-0x000000018974B610
	public static void ContentHashOnto(Dictionary<StrikeType, ConfigWwiseString> dict, ref int hash_code) {} // 0x0000000181006C10-0x0000000181006E20
	[BlackList] // 0x00000001897584F0-0x0000000189758540
	// [IDTag] // 0x00000001897584F0-0x0000000189758540
	// [XID] // 0x00000001897584F0-0x0000000189758540
	public static void ContentHashOnto(Dictionary<ElementType, ConfigWwiseString> dict, ref int hash_code) {} // 0x0000000180FDE7D0-0x0000000180FDE9E0
	[BlackList] // 0x0000000189765E20-0x0000000189765E70
	// [IDTag] // 0x0000000189765E20-0x0000000189765E70
	// [XID] // 0x0000000189765E20-0x0000000189765E70
	public static void ContentHashOnto(AudioDialogReaction[] arr, ref int hash_code) {} // 0x0000000180FEDC90-0x0000000180FEDDA0
	[BlackList] // 0x0000000189773460-0x00000001897734B0
	// [IDTag] // 0x0000000189773460-0x00000001897734B0
	// [XID] // 0x0000000189773460-0x00000001897734B0
	public static void ContentHashOnto(Dictionary<string, ConfigAudioEmitter> dict, ref int hash_code) {} // 0x0000000180FDF6A0-0x0000000180FDF8B0
	[BlackList] // 0x0000000189780E60-0x0000000189780EB0
	// [IDTag] // 0x0000000189780E60-0x0000000189780EB0
	// [XID] // 0x0000000189780E60-0x0000000189780EB0
	public static void ContentHashOnto(ConfigAudioEventCullingRuleBase[] arr, ref int hash_code) {} // 0x0000000180FE1B70-0x0000000180FE1C80
	[BlackList] // 0x000000018978E260-0x000000018978E2B0
	// [IDTag] // 0x000000018978E260-0x000000018978E2B0
	// [XID] // 0x000000018978E260-0x000000018978E2B0
	public static void ContentHashOnto(Dictionary<string, ConfigAudioEventCullingRuleBase[]> dict, ref int hash_code) {} // 0x0000000180FD9200-0x0000000180FD9400
	[BlackList] // 0x000000018979C2D0-0x000000018979C320
	// [IDTag] // 0x000000018979C2D0-0x000000018979C320
	// [XID] // 0x000000018979C2D0-0x000000018979C320
	public static void ContentHashOnto(ConfigAudioMapArea[] arr, ref int hash_code) {} // 0x0000000180FDC400-0x0000000180FDC510
	[BlackList] // 0x00000001897A9730-0x00000001897A9780
	// [IDTag] // 0x00000001897A9730-0x00000001897A9780
	// [XID] // 0x00000001897A9730-0x00000001897A9780
	public static void ContentHashOnto(Dictionary<int, ConfigWwiseString> dict, ref int hash_code) {} // 0x0000000180FE3790-0x0000000180FE39A0
	[BlackList] // 0x00000001897B7720-0x00000001897B7770
	// [IDTag] // 0x00000001897B7720-0x00000001897B7770
	// [XID] // 0x00000001897B7720-0x00000001897B7770
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigWwiseString> dict, ref int hash_code) {} // 0x0000000181001A90-0x0000000181001CD0
	[BlackList] // 0x00000001897C5250-0x00000001897C52A0
	// [IDTag] // 0x00000001897C5250-0x00000001897C52A0
	// [XID] // 0x00000001897C5250-0x00000001897C52A0
	public static void ContentHashOnto(Dictionary<int, Dictionary<int, ConfigWwiseString>> dict, ref int hash_code) {} // 0x0000000180FD9EA0-0x0000000180FDA0A0
	[BlackList] // 0x00000001897D2980-0x00000001897D29D0
	// [IDTag] // 0x00000001897D2980-0x00000001897D29D0
	// [XID] // 0x00000001897D2980-0x00000001897D29D0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigWwiseString>> dict, ref int hash_code) {} // 0x0000000180FED300-0x0000000180FED530
	[BlackList] // 0x00000001897E02A0-0x00000001897E02F0
	// [IDTag] // 0x00000001897E02A0-0x00000001897E02F0
	// [XID] // 0x00000001897E02A0-0x00000001897E02F0
	public static void ContentHashOnto(Dictionary<int, int> dict, ref int hash_code) {} // 0x0000000181005340-0x0000000181005530
	[BlackList] // 0x00000001897EDE20-0x00000001897EDE70
	// [IDTag] // 0x00000001897EDE20-0x00000001897EDE70
	// [XID] // 0x00000001897EDE20-0x00000001897EDE70
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, SimpleSafeInt32> dict, ref int hash_code) {} // 0x0000000180FFA600-0x0000000180FFA820
	[BlackList] // 0x00000001897FB9F0-0x00000001897FBA40
	// [IDTag] // 0x00000001897FB9F0-0x00000001897FBA40
	// [XID] // 0x00000001897FB9F0-0x00000001897FBA40
	public static void ContentHashOnto(MusicEnemyCombatPhaseState[] arr, ref int hash_code) {} // 0x0000000180FE6B50-0x0000000180FE6C60
	[BlackList] // 0x0000000189808B40-0x0000000189808B90
	// [IDTag] // 0x0000000189808B40-0x0000000189808B90
	// [XID] // 0x0000000189808B40-0x0000000189808B90
	public static void ContentHashOnto(MusicEnemySettings[] arr, ref int hash_code) {} // 0x0000000181002CE0-0x0000000181002DF0
	[BlackList] // 0x00000001898161E0-0x0000000189816230
	// [IDTag] // 0x00000001898161E0-0x0000000189816230
	// [XID] // 0x00000001898161E0-0x0000000189816230
	public static void ContentHashOnto(AudioMutualExclusion[] arr, ref int hash_code) {} // 0x0000000180FE59B0-0x0000000180FE5AC0
	[BlackList] // 0x0000000189823860-0x00000001898238B0
	// [IDTag] // 0x0000000189823860-0x00000001898238B0
	// [XID] // 0x0000000189823860-0x00000001898238B0
	public static void ContentHashOnto(Dictionary<string, ConfigAudioOperation> dict, ref int hash_code) {} // 0x0000000181002180-0x0000000181002390
	[BlackList] // 0x0000000189830EF0-0x0000000189830F40
	// [IDTag] // 0x0000000189830EF0-0x0000000189830F40
	// [XID] // 0x0000000189830EF0-0x0000000189830F40
	public static void ContentHashOnto(ConfigAudioQuestOps[] arr, ref int hash_code) {} // 0x0000000181000700-0x0000000181000810
	[BlackList] // 0x000000018983E460-0x000000018983E4B0
	// [IDTag] // 0x000000018983E460-0x000000018983E4B0
	// [XID] // 0x000000018983E460-0x000000018983E4B0
	public static void ContentHashOnto(Dictionary<string, ConfigAudioIncrementalResources> dict, ref int hash_code) {} // 0x0000000180FE7550-0x0000000180FE7760
	[BlackList] // 0x000000018984BA00-0x000000018984BA50
	// [IDTag] // 0x000000018984BA00-0x000000018984BA50
	// [XID] // 0x000000018984BA00-0x000000018984BA50
	public static void ContentHashOnto(AudioSettingSlider_PostVoiceItem[] arr, ref int hash_code) {} // 0x0000000180FFCFB0-0x0000000180FFD0C0
	[BlackList] // 0x0000000189858D40-0x0000000189858D90
	// [IDTag] // 0x0000000189858D40-0x0000000189858D90
	// [XID] // 0x0000000189858D40-0x0000000189858D90
	public static void ContentHashOnto(ConfigAudioStageProgressEvent[] arr, ref int hash_code) {} // 0x0000000180FF8220-0x0000000180FF8330
	[BlackList] // 0x0000000189865D10-0x0000000189865D60
	// [IDTag] // 0x0000000189865D10-0x0000000189865D60
	// [XID] // 0x0000000189865D10-0x0000000189865D60
	public static void ContentHashOnto(Dictionary<string, AudioWeatherProperties> dict, ref int hash_code) {} // 0x0000000180FF72D0-0x0000000180FF74E0
	[BlackList] // 0x00000001898731E0-0x0000000189873230
	// [IDTag] // 0x00000001898731E0-0x0000000189873230
	// [XID] // 0x00000001898731E0-0x0000000189873230
	public static void ContentHashOnto(ConfigWeatherType[] arr, ref int hash_code) {} // 0x0000000181006F30-0x0000000181007050
	[BlackList] // 0x0000000189880900-0x0000000189880950
	// [IDTag] // 0x0000000189880900-0x0000000189880950
	// [XID] // 0x0000000189880900-0x0000000189880950
	public static void ContentHashOnto(AudioWeatherVoTrigger[] arr, ref int hash_code) {} // 0x0000000180FE9130-0x0000000180FE9240
	[BlackList] // 0x000000018988D960-0x000000018988D9B0
	// [IDTag] // 0x000000018988D960-0x000000018988D9B0
	// [XID] // 0x000000018988D960-0x000000018988D9B0
	public static void ContentHashOnto(AvatarSpeechEquipObtain[] arr, ref int hash_code) {} // 0x0000000180FF1010-0x0000000180FF1120
	[BlackList] // 0x000000018989B100-0x000000018989B150
	// [IDTag] // 0x000000018989B100-0x000000018989B150
	// [XID] // 0x000000018989B100-0x000000018989B150
	public static void ContentHashOnto(VoiceSound[] arr, ref int hash_code) {} // 0x0000000180FFBEA0-0x0000000180FFBFB0
	[BlackList] // 0x00000001898A8230-0x00000001898A8280
	// [IDTag] // 0x00000001898A8230-0x00000001898A8280
	// [XID] // 0x00000001898A8230-0x00000001898A8280
	public static void ContentHashOnto(Dictionary<uint, VoiceTriggerIdentity> dict, ref int hash_code) {} // 0x0000000180FE1300-0x0000000180FE1510
	[BlackList] // 0x00000001898B5B10-0x00000001898B5B60
	// [IDTag] // 0x00000001898B5B10-0x00000001898B5B60
	// [XID] // 0x00000001898B5B10-0x00000001898B5B60
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, VoiceTriggerIdentity> dict, ref int hash_code) {} // 0x0000000180FE9870-0x0000000180FE9AB0
	[BlackList] // 0x00000001898C32A0-0x00000001898C32F0
	// [IDTag] // 0x00000001898C32A0-0x00000001898C32F0
	// [XID] // 0x00000001898C32A0-0x00000001898C32F0
	public static void ContentHashOnto(Dictionary<string, ConfigBoundary> dict, ref int hash_code) {} // 0x0000000180FDEF60-0x0000000180FDF170
	[BlackList] // 0x00000001898D0BB0-0x00000001898D0C00
	// [IDTag] // 0x00000001898D0BB0-0x00000001898D0C00
	// [XID] // 0x00000001898D0BB0-0x00000001898D0C00
	public static void ContentHashOnto(Dictionary<string, ConfigCameraMove> dict, ref int hash_code) {} // 0x0000000180FD9C90-0x0000000180FD9EA0
	[BlackList] // 0x00000001898DE940-0x00000001898DE990
	// [IDTag] // 0x00000001898DE940-0x00000001898DE990
	// [XID] // 0x00000001898DE940-0x00000001898DE990
	public static void ContentHashOnto(JsonClimateType[] arr, ref int hash_code) {} // 0x0000000180FD8EA0-0x0000000180FD8FC0
	[BlackList] // 0x00000001898EC170-0x00000001898EC1C0
	// [IDTag] // 0x00000001898EC170-0x00000001898EC1C0
	// [XID] // 0x00000001898EC170-0x00000001898EC1C0
	public static void ContentHashOnto(Dictionary<JsonClimateType, string> dict, ref int hash_code) {} // 0x0000000180FFB450-0x0000000180FFB650
	[BlackList] // 0x00000001898F9B30-0x00000001898F9B80
	// [IDTag] // 0x00000001898F9B30-0x00000001898F9B80
	// [XID] // 0x00000001898F9B30-0x00000001898F9B80
	public static void ContentHashOnto(Dictionary<JsonClimateType, uint[]> dict, ref int hash_code) {} // 0x0000000180FE29B0-0x0000000180FE2BB0
	[BlackList] // 0x0000000189907470-0x00000001899074C0
	// [IDTag] // 0x0000000189907470-0x00000001899074C0
	// [XID] // 0x0000000189907470-0x00000001899074C0
	public static void ContentHashOnto(Dictionary<JsonClimateType, SimpleSafeUInt32[]> dict, ref int hash_code) {} // 0x0000000180FFDED0-0x0000000180FFE0D0
	[BlackList] // 0x0000000189914C00-0x0000000189914C50
	// [IDTag] // 0x0000000189914C00-0x0000000189914C50
	// [XID] // 0x0000000189914C00-0x0000000189914C50
	public static void ContentHashOnto(Dictionary<string, ConfigClimateInfoBase> dict, ref int hash_code) {} // 0x0000000180FDF170-0x0000000180FDF380
	[BlackList] // 0x00000001899225C0-0x0000000189922610
	// [IDTag] // 0x00000001899225C0-0x0000000189922610
	// [XID] // 0x00000001899225C0-0x0000000189922610
	public static void ContentHashOnto(ConfigClimateArea[] arr, ref int hash_code) {} // 0x0000000180FF47A0-0x0000000180FF48B0
	[BlackList] // 0x000000018992FB10-0x000000018992FB60
	// [IDTag] // 0x000000018992FB10-0x000000018992FB60
	// [XID] // 0x000000018992FB10-0x000000018992FB60
	public static void ContentHashOnto(ConfigCodexQuestText[] arr, ref int hash_code) {} // 0x0000000180FE0270-0x0000000180FE0380
	[BlackList] // 0x000000018993D550-0x000000018993D5A0
	// [IDTag] // 0x000000018993D550-0x000000018993D5A0
	// [XID] // 0x000000018993D550-0x000000018993D5A0
	public static void ContentHashOnto(ConfigCodexQuestDialogSingle[] arr, ref int hash_code) {} // 0x0000000180FDA6B0-0x0000000180FDA7C0
	[BlackList] // 0x000000018994A7E0-0x000000018994A830
	// [IDTag] // 0x000000018994A7E0-0x000000018994A830
	// [XID] // 0x000000018994A7E0-0x000000018994A830
	public static void ContentHashOnto(ConfigCodexQuestItem[] arr, ref int hash_code) {} // 0x0000000180FEC4A0-0x0000000180FEC5B0
	[BlackList] // 0x0000000189958100-0x0000000189958150
	// [IDTag] // 0x0000000189958100-0x0000000189958150
	// [XID] // 0x0000000189958100-0x0000000189958150
	public static void ContentHashOnto(ConfigCodexQuestSubQuest[] arr, ref int hash_code) {} // 0x0000000180FDFD00-0x0000000180FDFE10
	[BlackList] // 0x0000000189965880-0x00000001899658D0
	// [IDTag] // 0x0000000189965880-0x00000001899658D0
	// [XID] // 0x0000000189965880-0x00000001899658D0
	public static void ContentHashOnto(StrikeType[] arr, ref int hash_code) {} // 0x0000000180FDBDD0-0x0000000180FDBEF0
	[BlackList] // 0x00000001899730B0-0x0000000189973100
	// [IDTag] // 0x00000001899730B0-0x0000000189973100
	// [XID] // 0x00000001899730B0-0x0000000189973100
	public static void ContentHashOnto(Dictionary<string, ConfigAttackEvent> dict, ref int hash_code) {} // 0x0000000180FEED80-0x0000000180FEEF90
	[BlackList] // 0x0000000189980600-0x0000000189980650
	// [IDTag] // 0x0000000189980600-0x0000000189980650
	// [XID] // 0x0000000189980600-0x0000000189980650
	public static void ContentHashOnto(Dictionary<TargetType, ConfigAttackInfo> dict, ref int hash_code) {} // 0x0000000180FFC640-0x0000000180FFC850
	[BlackList] // 0x000000018998E1E0-0x000000018998E230
	// [IDTag] // 0x000000018998E1E0-0x000000018998E230
	// [XID] // 0x000000018998E1E0-0x000000018998E230
	public static void ContentHashOnto(CombatPropertyIndex[] arr, ref int hash_code) {} // 0x0000000180FE0FD0-0x0000000180FE10F0
	[BlackList] // 0x000000018999BE40-0x000000018999BE90
	// [IDTag] // 0x000000018999BE40-0x000000018999BE90
	// [XID] // 0x000000018999BE40-0x000000018999BE90
	public static void ContentHashOnto(ShakeByAinmator[] arr, ref int hash_code) {} // 0x0000000180FEA740-0x0000000180FEA850
	[BlackList] // 0x00000001899A98F0-0x00000001899A9940
	// [IDTag] // 0x00000001899A98F0-0x00000001899A9940
	// [XID] // 0x00000001899A98F0-0x00000001899A9940
	public static void ContentHashOnto(ConfigSummonTag[] arr, ref int hash_code) {} // 0x0000000180FEB940-0x0000000180FEBA50
	[BlackList] // 0x00000001899B6E70-0x00000001899B6EC0
	// [IDTag] // 0x00000001899B6E70-0x00000001899B6EC0
	// [XID] // 0x00000001899B6E70-0x00000001899B6EC0
	public static void ContentHashOnto(ComponentTag[] arr, ref int hash_code) {} // 0x0000000180FEE2F0-0x0000000180FEE410
	[BlackList] // 0x00000001899C4AC0-0x00000001899C4B10
	// [IDTag] // 0x00000001899C4AC0-0x00000001899C4B10
	// [XID] // 0x00000001899C4AC0-0x00000001899C4B10
	public static void ContentHashOnto(CoopCond[] arr, ref int hash_code) {} // 0x0000000180FF33D0-0x0000000180FF34E0
	[BlackList] // 0x00000001899D1F00-0x00000001899D1F50
	// [IDTag] // 0x00000001899D1F00-0x00000001899D1F50
	// [XID] // 0x00000001899D1F00-0x00000001899D1F50
	public static void ContentHashOnto(ConfigCoopAction[] arr, ref int hash_code) {} // 0x0000000180FF56D0-0x0000000180FF57E0
	[BlackList] // 0x00000001899DF270-0x00000001899DF2C0
	// [IDTag] // 0x00000001899DF270-0x00000001899DF2C0
	// [XID] // 0x00000001899DF270-0x00000001899DF2C0
	public static void ContentHashOnto(CoopSelectNodeContent[] arr, ref int hash_code) {} // 0x0000000180FED640-0x0000000180FED750
	[BlackList] // 0x00000001899ECA70-0x00000001899ECAC0
	// [IDTag] // 0x00000001899ECA70-0x00000001899ECAC0
	// [XID] // 0x00000001899ECA70-0x00000001899ECAC0
	public static void ContentHashOnto(Dictionary<CoopTemperamentType, CoopTemperament> dict, ref int hash_code) {} // 0x0000000180FDAE70-0x0000000180FDB080
	[BlackList] // 0x00000001899FA3F0-0x00000001899FA440
	// [IDTag] // 0x00000001899FA3F0-0x00000001899FA440
	// [XID] // 0x00000001899FA3F0-0x00000001899FA440
	public static void ContentHashOnto(Dictionary<uint, ConfigCoopBaseNode> dict, ref int hash_code) {} // 0x0000000180FDB980-0x0000000180FDBB90
	[BlackList] // 0x0000000189A07870-0x0000000189A078C0
	// [IDTag] // 0x0000000189A07870-0x0000000189A078C0
	// [XID] // 0x0000000189A07870-0x0000000189A078C0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ConfigCoopBaseNode> dict, ref int hash_code) {} // 0x0000000180FE30F0-0x0000000180FE3330
	[BlackList] // 0x0000000189A14FC0-0x0000000189A15010
	// [IDTag] // 0x0000000189A14FC0-0x0000000189A15010
	// [XID] // 0x0000000189A14FC0-0x0000000189A15010
	public static void ContentHashOnto(Dictionary<uint, ConfigCoopInteractionGroup> dict, ref int hash_code) {} // 0x0000000181007050-0x0000000181007260
	[BlackList] // 0x0000000189A223F0-0x0000000189A22440
	// [IDTag] // 0x0000000189A223F0-0x0000000189A22440
	// [XID] // 0x0000000189A223F0-0x0000000189A22440
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ConfigCoopInteractionGroup> dict, ref int hash_code) {} // 0x0000000181003000-0x0000000181003240
	[BlackList] // 0x0000000189A2F620-0x0000000189A2F670
	// [IDTag] // 0x0000000189A2F620-0x0000000189A2F670
	// [XID] // 0x0000000189A2F620-0x0000000189A2F670
	public static void ContentHashOnto(Dictionary<uint, CoopSubStartPoint> dict, ref int hash_code) {} // 0x0000000180FF9230-0x0000000180FF9440
	[BlackList] // 0x0000000189A3CCA0-0x0000000189A3CCF0
	// [IDTag] // 0x0000000189A3CCA0-0x0000000189A3CCF0
	// [XID] // 0x0000000189A3CCA0-0x0000000189A3CCF0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, CoopSubStartPoint> dict, ref int hash_code) {} // 0x0000000180FF2B30-0x0000000180FF2D70
	[BlackList] // 0x0000000189A4A3E0-0x0000000189A4A430
	// [IDTag] // 0x0000000189A4A3E0-0x0000000189A4A430
	// [XID] // 0x0000000189A4A3E0-0x0000000189A4A430
	public static void ContentHashOnto(Dictionary<uint, CoopSavePoint> dict, ref int hash_code) {} // 0x0000000180FF2D70-0x0000000180FF2F80
	[BlackList] // 0x0000000189A57A90-0x0000000189A57AE0
	// [IDTag] // 0x0000000189A57A90-0x0000000189A57AE0
	// [XID] // 0x0000000189A57A90-0x0000000189A57AE0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, CoopSavePoint> dict, ref int hash_code) {} // 0x0000000180FED750-0x0000000180FED990
	[BlackList] // 0x0000000189A65790-0x0000000189A657E0
	// [IDTag] // 0x0000000189A65790-0x0000000189A657E0
	// [XID] // 0x0000000189A65790-0x0000000189A657E0
	public static void ContentHashOnto(QuestState[] arr, ref int hash_code) {} // 0x0000000180FE5020-0x0000000180FE5140
	[BlackList] // 0x0000000189A72FD0-0x0000000189A73020
	// [IDTag] // 0x0000000189A72FD0-0x0000000189A73020
	// [XID] // 0x0000000189A72FD0-0x0000000189A73020
	public static void ContentHashOnto(ConfigCrowdQuestRestriction[] arr, ref int hash_code) {} // 0x0000000180FDD1F0-0x0000000180FDD300
	[BlackList] // 0x0000000189A80640-0x0000000189A80690
	// [IDTag] // 0x0000000189A80640-0x0000000189A80690
	// [XID] // 0x0000000189A80640-0x0000000189A80690
	public static void ContentHashOnto(ConfigCrowdActivityRestriction[] arr, ref int hash_code) {} // 0x0000000180FDDA50-0x0000000180FDDB60
	[BlackList] // 0x0000000189A8E3E0-0x0000000189A8E430
	// [IDTag] // 0x0000000189A8E3E0-0x0000000189A8E430
	// [XID] // 0x0000000189A8E3E0-0x0000000189A8E430
	public static void ContentHashOnto(ConfigCrowdTimeRestriction[] arr, ref int hash_code) {} // 0x0000000180FE9240-0x0000000180FE9350
	[BlackList] // 0x0000000189A9B8C0-0x0000000189A9B910
	// [IDTag] // 0x0000000189A9B8C0-0x0000000189A9B910
	// [XID] // 0x0000000189A9B8C0-0x0000000189A9B910
	public static void ContentHashOnto(ConfigCrowdSceneTagRestriction[] arr, ref int hash_code) {} // 0x0000000180FE58A0-0x0000000180FE59B0
	[BlackList] // 0x0000000189AA8B60-0x0000000189AA8BB0
	// [IDTag] // 0x0000000189AA8B60-0x0000000189AA8BB0
	// [XID] // 0x0000000189AA8B60-0x0000000189AA8BB0
	public static void ContentHashOnto(ConfigCrowdRestrictionGroup[] arr, ref int hash_code) {} // 0x0000000180FF87B0-0x0000000180FF88C0
	[BlackList] // 0x0000000189AB6720-0x0000000189AB6770
	// [IDTag] // 0x0000000189AB6720-0x0000000189AB6770
	// [XID] // 0x0000000189AB6720-0x0000000189AB6770
	public static void ContentHashOnto(ConfigCrowdGroupInfo[] arr, ref int hash_code) {} // 0x0000000180FE8130-0x0000000180FE8240
	[BlackList] // 0x0000000189AC43E0-0x0000000189AC4430
	// [IDTag] // 0x0000000189AC43E0-0x0000000189AC4430
	// [XID] // 0x0000000189AC43E0-0x0000000189AC4430
	public static void ContentHashOnto(ColorVector[] arr, ref int hash_code) {} // 0x0000000180FFC530-0x0000000180FFC640
	[BlackList] // 0x0000000189AD1AF0-0x0000000189AD1B40
	// [IDTag] // 0x0000000189AD1AF0-0x0000000189AD1B40
	// [XID] // 0x0000000189AD1AF0-0x0000000189AD1B40
	public static void ContentHashOnto(ConfigCrowdSpawnInfo[] arr, ref int hash_code) {} // 0x00000001810029C0-0x0000000181002AD0
	[BlackList] // 0x0000000189ADFBF0-0x0000000189ADFC40
	// [IDTag] // 0x0000000189ADFBF0-0x0000000189ADFC40
	// [XID] // 0x0000000189ADFBF0-0x0000000189ADFC40
	public static void ContentHashOnto(ConfigCrowdGroupColliderInfo[] arr, ref int hash_code) {} // 0x0000000180FE4F10-0x0000000180FE5020
	[BlackList] // 0x0000000189AED060-0x0000000189AED0B0
	// [IDTag] // 0x0000000189AED060-0x0000000189AED0B0
	// [XID] // 0x0000000189AED060-0x0000000189AED0B0
	public static void ContentHashOnto(Dictionary<int, ConfigCutsceneContext> dict, ref int hash_code) {} // 0x0000000180FEF500-0x0000000180FEF710
	[BlackList] // 0x0000000189AFAD20-0x0000000189AFAD70
	// [IDTag] // 0x0000000189AFAD20-0x0000000189AFAD70
	// [XID] // 0x0000000189AFAD20-0x0000000189AFAD70
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigCutsceneContext> dict, ref int hash_code) {} // 0x0000000180FD8FC0-0x0000000180FD9200
	[BlackList] // 0x0000000189B07F90-0x0000000189B07FE0
	// [IDTag] // 0x0000000189B07F90-0x0000000189B07FE0
	// [XID] // 0x0000000189B07F90-0x0000000189B07FE0
	public static void ContentHashOnto(DebugBoardInfo[] arr, ref int hash_code) {} // 0x0000000180FF1E90-0x0000000180FF1FA0
	[BlackList] // 0x0000000189B15360-0x0000000189B153B0
	// [IDTag] // 0x0000000189B15360-0x0000000189B153B0
	// [XID] // 0x0000000189B15360-0x0000000189B153B0
	public static void ContentHashOnto(DebugBlletinInfo[] arr, ref int hash_code) {} // 0x0000000180FDAB20-0x0000000180FDAC30
	[BlackList] // 0x0000000189B22AF0-0x0000000189B22B40
	// [IDTag] // 0x0000000189B22AF0-0x0000000189B22B40
	// [XID] // 0x0000000189B22AF0-0x0000000189B22B40
	public static void ContentHashOnto(bool[] arr, ref int hash_code) {} // 0x0000000180FFDA70-0x0000000180FFDBA0
	[BlackList] // 0x0000000189B2FC70-0x0000000189B2FCC0
	// [IDTag] // 0x0000000189B2FC70-0x0000000189B2FCC0
	// [XID] // 0x0000000189B2FC70-0x0000000189B2FCC0
	public static void ContentHashOnto(double[] arr, ref int hash_code) {} // 0x0000000180FEA400-0x0000000180FEA520
	[BlackList] // 0x0000000189B3D220-0x0000000189B3D270
	// [IDTag] // 0x0000000189B3D220-0x0000000189B3D270
	// [XID] // 0x0000000189B3D220-0x0000000189B3D270
	public static void ContentHashOnto(int[] arr, ref int hash_code) {} // 0x0000000180FE3FE0-0x0000000180FE4100
	[BlackList] // 0x0000000189B4AEB0-0x0000000189B4AF00
	// [IDTag] // 0x0000000189B4AEB0-0x0000000189B4AF00
	// [XID] // 0x0000000189B4AEB0-0x0000000189B4AF00
	public static void ContentHashOnto(SimpleSafeInt32[] arr, ref int hash_code) {} // 0x0000000180FDB080-0x0000000180FDB1E0
	[BlackList] // 0x0000000189B58910-0x0000000189B58960
	// [IDTag] // 0x0000000189B58910-0x0000000189B58960
	// [XID] // 0x0000000189B58910-0x0000000189B58960
	public static void ContentHashOnto(uint[] arr, ref int hash_code) {} // 0x0000000181003660-0x0000000181003780
	[BlackList] // 0x0000000189B66010-0x0000000189B66060
	// [IDTag] // 0x0000000189B66010-0x0000000189B66060
	// [XID] // 0x0000000189B66010-0x0000000189B66060
	public static void ContentHashOnto(SimpleSafeUInt32[] arr, ref int hash_code) {} // 0x0000000180FDCC60-0x0000000180FDCDC0
	[BlackList] // 0x0000000189B734C0-0x0000000189B73510
	// [IDTag] // 0x0000000189B734C0-0x0000000189B73510
	// [XID] // 0x0000000189B734C0-0x0000000189B73510
	public static void ContentHashOnto(float[] arr, ref int hash_code) {} // 0x0000000181001410-0x0000000181001530
	[BlackList] // 0x0000000189B80740-0x0000000189B80790
	// [IDTag] // 0x0000000189B80740-0x0000000189B80790
	// [XID] // 0x0000000189B80740-0x0000000189B80790
	public static void ContentHashOnto(SimpleSafeFloat[] arr, ref int hash_code) {} // 0x0000000180FF9950-0x0000000180FF9AB0
	[BlackList] // 0x0000000189B8DDD0-0x0000000189B8DE20
	// [IDTag] // 0x0000000189B8DDD0-0x0000000189B8DE20
	// [XID] // 0x0000000189B8DDD0-0x0000000189B8DE20
	public static void ContentHashOnto(string[] arr, ref int hash_code) {} // 0x0000000180FEF3E0-0x0000000180FEF500
	[BlackList] // 0x0000000189B9B3E0-0x0000000189B9B430
	// [IDTag] // 0x0000000189B9B3E0-0x0000000189B9B430
	// [XID] // 0x0000000189B9B3E0-0x0000000189B9B430
	public static void ContentHashOnto(ulong[] arr, ref int hash_code) {} // 0x0000000181003CB0-0x0000000181003DD0
	[BlackList] // 0x0000000189BA8640-0x0000000189BA8690
	// [IDTag] // 0x0000000189BA8640-0x0000000189BA8690
	// [XID] // 0x0000000189BA8640-0x0000000189BA8690
	public static void ContentHashOnto(Dictionary<string, int> dict, ref int hash_code) {} // 0x0000000180FF3A60-0x0000000180FF3C60
	[BlackList] // 0x0000000189BB59E0-0x0000000189BB5A30
	// [IDTag] // 0x0000000189BB59E0-0x0000000189BB5A30
	// [XID] // 0x0000000189BB59E0-0x0000000189BB5A30
	public static void ContentHashOnto(Dictionary<string, SimpleSafeInt32> dict, ref int hash_code) {} // 0x0000000180FFED40-0x0000000180FFEF70
	[BlackList] // 0x0000000189BC3880-0x0000000189BC38D0
	// [IDTag] // 0x0000000189BC3880-0x0000000189BC38D0
	// [XID] // 0x0000000189BC3880-0x0000000189BC38D0
	public static void ContentHashOnto(Dictionary<string, float> dict, ref int hash_code) {} // 0x0000000181005730-0x0000000181005930
	[BlackList] // 0x0000000189BD0CE0-0x0000000189BD0D30
	// [IDTag] // 0x0000000189BD0CE0-0x0000000189BD0D30
	// [XID] // 0x0000000189BD0CE0-0x0000000189BD0D30
	public static void ContentHashOnto(Dictionary<string, SimpleSafeFloat> dict, ref int hash_code) {} // 0x0000000180FE6720-0x0000000180FE6950
	[BlackList] // 0x0000000189BDE810-0x0000000189BDE860
	// [IDTag] // 0x0000000189BDE810-0x0000000189BDE860
	// [XID] // 0x0000000189BDE810-0x0000000189BDE860
	public static void ContentHashOnto(Dictionary<string, string> dict, ref int hash_code) {} // 0x0000000180FE25A0-0x0000000180FE27A0
	[BlackList] // 0x00000001895F0FE0-0x00000001895F1030
	// [IDTag] // 0x00000001895F0FE0-0x00000001895F1030
	// [XID] // 0x00000001895F0FE0-0x00000001895F1030
	public static void ContentHashOnto(Dictionary<uint, uint> dict, ref int hash_code) {} // 0x0000000180FED990-0x0000000180FEDB80
	[BlackList] // 0x00000001895FE680-0x00000001895FE6D0
	// [IDTag] // 0x00000001895FE680-0x00000001895FE6D0
	// [XID] // 0x00000001895FE680-0x00000001895FE6D0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> dict, ref int hash_code) {} // 0x0000000180FDD600-0x0000000180FDD820
	[BlackList] // 0x000000018960C100-0x000000018960C150
	// [IDTag] // 0x000000018960C100-0x000000018960C150
	// [XID] // 0x000000018960C100-0x000000018960C150
	public static void ContentHashOnto(Dictionary<uint, int[]> dict, ref int hash_code) {} // 0x0000000180FE9670-0x0000000180FE9870
	[BlackList] // 0x0000000189619850-0x00000001896198A0
	// [IDTag] // 0x0000000189619850-0x00000001896198A0
	// [XID] // 0x0000000189619850-0x00000001896198A0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, SimpleSafeInt32[]> dict, ref int hash_code) {} // 0x0000000180FEFE50-0x0000000180FF0080
	[BlackList] // 0x0000000189626C00-0x0000000189626C50
	// [IDTag] // 0x0000000189626C00-0x0000000189626C50
	// [XID] // 0x0000000189626C00-0x0000000189626C50
	public static void ContentHashOnto(Dictionary<int, string[]> dict, ref int hash_code) {} // 0x0000000180FE5AC0-0x0000000180FE5CC0
	[BlackList] // 0x00000001896348E0-0x0000000189634930
	// [IDTag] // 0x00000001896348E0-0x0000000189634930
	// [XID] // 0x00000001896348E0-0x0000000189634930
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, string[]> dict, ref int hash_code) {} // 0x0000000180FDDF80-0x0000000180FDE1B0
	[BlackList] // 0x0000000189641E60-0x0000000189641EB0
	// [IDTag] // 0x0000000189641E60-0x0000000189641EB0
	// [XID] // 0x0000000189641E60-0x0000000189641EB0
	public static void ContentHashOnto(Dictionary<uint, Dictionary<int, string[]>> dict, ref int hash_code) {} // 0x0000000180FE6EC0-0x0000000180FE70C0
	[BlackList] // 0x000000018964F3C0-0x000000018964F410
	// [IDTag] // 0x000000018964F3C0-0x000000018964F410
	// [XID] // 0x000000018964F3C0-0x000000018964F410
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, Dictionary<SimpleSafeInt32, string[]>> dict, ref int hash_code) {} // 0x0000000180FDB1E0-0x0000000180FDB410
	[BlackList] // 0x000000018965CD60-0x000000018965CDB0
	// [IDTag] // 0x000000018965CD60-0x000000018965CDB0
	// [XID] // 0x000000018965CD60-0x000000018965CDB0
	public static void ContentHashOnto(Dictionary<string, string[]> dict, ref int hash_code) {} // 0x0000000180FEBA50-0x0000000180FEBC50
	[BlackList] // 0x000000018966A5E0-0x000000018966A630
	// [IDTag] // 0x000000018966A5E0-0x000000018966A630
	// [XID] // 0x000000018966A5E0-0x000000018966A630
	public static void ContentHashOnto(Dictionary<string, uint[]> dict, ref int hash_code) {} // 0x0000000180FF09A0-0x0000000180FF0BA0
	[BlackList] // 0x0000000189678140-0x0000000189678190
	// [IDTag] // 0x0000000189678140-0x0000000189678190
	// [XID] // 0x0000000189678140-0x0000000189678190
	public static void ContentHashOnto(Dictionary<string, SimpleSafeUInt32[]> dict, ref int hash_code) {} // 0x0000000181000810-0x0000000181000A10
	[BlackList] // 0x00000001896857E0-0x0000000189685830
	// [IDTag] // 0x00000001896857E0-0x0000000189685830
	// [XID] // 0x00000001896857E0-0x0000000189685830
	public static void ContentHashOnto(Dictionary<string, Dictionary<string, string>> dict, ref int hash_code) {} // 0x0000000180FF9AB0-0x0000000180FF9CB0
	[BlackList] // 0x00000001896937C0-0x0000000189693810
	// [IDTag] // 0x00000001896937C0-0x0000000189693810
	// [XID] // 0x00000001896937C0-0x0000000189693810
	public static void ContentHashOnto(Dictionary<string, Dictionary<string, float>> dict, ref int hash_code) {} // 0x0000000180FFE600-0x0000000180FFE800
	[BlackList] // 0x00000001896A0990-0x00000001896A09E0
	// [IDTag] // 0x00000001896A0990-0x00000001896A09E0
	// [XID] // 0x00000001896A0990-0x00000001896A09E0
	public static void ContentHashOnto(Dictionary<string, Dictionary<string, SimpleSafeFloat>> dict, ref int hash_code) {} // 0x0000000180FE9AB0-0x0000000180FE9CB0
	[BlackList] // 0x00000001896ADBE0-0x00000001896ADC30
	// [IDTag] // 0x00000001896ADBE0-0x00000001896ADC30
	// [XID] // 0x00000001896ADBE0-0x00000001896ADC30
	public static void ContentHashOnto(string[][] arr, ref int hash_code) {} // 0x0000000180FF6560-0x0000000180FF6680
	[BlackList] // 0x00000001896BB1B0-0x00000001896BB200
	// [IDTag] // 0x00000001896BB1B0-0x00000001896BB200
	// [XID] // 0x00000001896BB1B0-0x00000001896BB200
	public static void ContentHashOnto(DynamicFloat[] arr, ref int hash_code) {} // 0x0000000180FE39A0-0x0000000180FE3AB0
	[BlackList] // 0x00000001896C8310-0x00000001896C8360
	// [IDTag] // 0x00000001896C8310-0x00000001896C8360
	// [XID] // 0x00000001896C8310-0x00000001896C8360
	public static void ContentHashOnto(Dictionary<string, DynamicFloat> dict, ref int hash_code) {} // 0x0000000180FF2920-0x0000000180FF2B30
	[BlackList] // 0x00000001896D58B0-0x00000001896D5900
	// [IDTag] // 0x00000001896D58B0-0x00000001896D5900
	// [XID] // 0x00000001896D58B0-0x00000001896D5900
	public static void ContentHashOnto(DynamicInt[] arr, ref int hash_code) {} // 0x0000000180FE3680-0x0000000180FE3790
	[BlackList] // 0x00000001896E2E40-0x00000001896E2E90
	// [IDTag] // 0x00000001896E2E40-0x00000001896E2E90
	// [XID] // 0x00000001896E2E40-0x00000001896E2E90
	public static void ContentHashOnto(Dictionary<string, DynamicInt> dict, ref int hash_code) {} // 0x0000000180FE8910-0x0000000180FE8B20
	[BlackList] // 0x00000001896EFE80-0x00000001896EFED0
	// [IDTag] // 0x00000001896EFE80-0x00000001896EFED0
	// [XID] // 0x00000001896EFE80-0x00000001896EFED0
	public static void ContentHashOnto(DynamicString[] arr, ref int hash_code) {} // 0x0000000180FE8590-0x0000000180FE86A0
	[BlackList] // 0x00000001896FDA80-0x00000001896FDAD0
	// [IDTag] // 0x00000001896FDA80-0x00000001896FDAD0
	// [XID] // 0x00000001896FDA80-0x00000001896FDAD0
	public static void ContentHashOnto(Dictionary<string, DynamicString> dict, ref int hash_code) {} // 0x0000000180FEE410-0x0000000180FEE620
	[BlackList] // 0x000000018970AEA0-0x000000018970AEF0
	// [IDTag] // 0x000000018970AEA0-0x000000018970AEF0
	// [XID] // 0x000000018970AEA0-0x000000018970AEF0
	public static void ContentHashOnto(Point2D[] arr, ref int hash_code) {} // 0x0000000180FFAA50-0x0000000180FFAB60
	[BlackList] // 0x0000000189718550-0x00000001897185A0
	// [IDTag] // 0x0000000189718550-0x00000001897185A0
	// [XID] // 0x0000000189718550-0x00000001897185A0
	public static void ContentHashOnto(MoleMole.Config.Vector[] arr, ref int hash_code) {} // 0x0000000180FDAA00-0x0000000180FDAB20
	[BlackList] // 0x0000000189725BD0-0x0000000189725C20
	// [IDTag] // 0x0000000189725BD0-0x0000000189725C20
	// [XID] // 0x0000000189725BD0-0x0000000189725C20
	public static void ContentHashOnto(EntityType[] arr, ref int hash_code) {} // 0x0000000180FE5140-0x0000000180FE5260
	[BlackList] // 0x0000000189733180-0x00000001897331D0
	// [IDTag] // 0x0000000189733180-0x00000001897331D0
	// [XID] // 0x0000000189733180-0x00000001897331D0
	public static void ContentHashOnto(Dictionary<uint, ulong> dict, ref int hash_code) {} // 0x0000000180FE6950-0x0000000180FE6B50
	[BlackList] // 0x0000000189740E00-0x0000000189740E50
	// [IDTag] // 0x0000000189740E00-0x0000000189740E50
	// [XID] // 0x0000000189740E00-0x0000000189740E50
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ulong> dict, ref int hash_code) {} // 0x0000000180FFD2D0-0x0000000180FFD500
	[BlackList] // 0x000000018974E500-0x000000018974E550
	// [IDTag] // 0x000000018974E500-0x000000018974E550
	// [XID] // 0x000000018974E500-0x000000018974E550
	public static void ContentHashOnto(Dictionary<string, ulong> dict, ref int hash_code) {} // 0x0000000180FF48B0-0x0000000180FF4AB0
	[BlackList] // 0x000000018975B5A0-0x000000018975B5F0
	// [IDTag] // 0x000000018975B5A0-0x000000018975B5F0
	// [XID] // 0x000000018975B5A0-0x000000018975B5F0
	public static void ContentHashOnto(Dictionary<string, ConfigDynamicAbilityPreload> dict, ref int hash_code) {} // 0x0000000180FEFB30-0x0000000180FEFD40
	[BlackList] // 0x0000000189768DC0-0x0000000189768E10
	// [IDTag] // 0x0000000189768DC0-0x0000000189768E10
	// [XID] // 0x0000000189768DC0-0x0000000189768E10
	public static void ContentHashOnto(ConfigDynamicTalent[] arr, ref int hash_code) {} // 0x0000000180FFB230-0x0000000180FFB340
	[BlackList] // 0x0000000189776700-0x0000000189776750
	// [IDTag] // 0x0000000189776700-0x0000000189776750
	// [XID] // 0x0000000189776700-0x0000000189776750
	public static void ContentHashOnto(Dictionary<string, ConfigEffectPoolItem> dict, ref int hash_code) {} // 0x0000000180FE5690-0x0000000180FE58A0
	[BlackList] // 0x0000000189783E60-0x0000000189783EB0
	// [IDTag] // 0x0000000189783E60-0x0000000189783EB0
	// [XID] // 0x0000000189783E60-0x0000000189783EB0
	public static void ContentHashOnto(ConfigEffectWithThreshold[] arr, ref int hash_code) {} // 0x0000000180FEC7C0-0x0000000180FEC8D0
	[BlackList] // 0x0000000189791250-0x00000001897912A0
	// [IDTag] // 0x0000000189791250-0x00000001897912A0
	// [XID] // 0x0000000189791250-0x00000001897912A0
	public static void ContentHashOnto(ConfigRecoverEnergyEffect[] arr, ref int hash_code) {} // 0x0000000180FE0490-0x0000000180FE05A0
	[BlackList] // 0x000000018979F220-0x000000018979F270
	// [IDTag] // 0x000000018979F220-0x000000018979F270
	// [XID] // 0x000000018979F220-0x000000018979F270
	public static void ContentHashOnto(Dictionary<string, ConfigSkipUnindexedEffectCreation> dict, ref int hash_code) {} // 0x0000000180FF69A0-0x0000000180FF6BB0
	[BlackList] // 0x00000001897AC6E0-0x00000001897AC730
	// [IDTag] // 0x00000001897AC6E0-0x00000001897AC730
	// [XID] // 0x00000001897AC6E0-0x00000001897AC730
	public static void ContentHashOnto(Dictionary<string, TokenForceEnqueueReason> dict, ref int hash_code) {} // 0x0000000180FE6400-0x0000000180FE6600
	[BlackList] // 0x00000001897BA0F0-0x00000001897BA140
	// [IDTag] // 0x00000001897BA0F0-0x00000001897BA140
	// [XID] // 0x00000001897BA0F0-0x00000001897BA140
	public static void ContentHashOnto(ElementType[] arr, ref int hash_code) {} // 0x0000000181004990-0x0000000181004AB0
	[BlackList] // 0x00000001897C8550-0x00000001897C85A0
	// [IDTag] // 0x00000001897C8550-0x00000001897C85A0
	// [XID] // 0x00000001897C8550-0x00000001897C85A0
	public static void ContentHashOnto(Dictionary<AbilityState, string> dict, ref int hash_code) {} // 0x0000000180FF88C0-0x0000000180FF8AC0
	[BlackList] // 0x00000001897D59B0-0x00000001897D5A00
	// [IDTag] // 0x00000001897D59B0-0x00000001897D5A00
	// [XID] // 0x00000001897D59B0-0x00000001897D5A00
	public static void ContentHashOnto(ConfigEmojiBubbleData[] arr, ref int hash_code) {} // 0x0000000180FFACC0-0x0000000180FFADD0
	[BlackList] // 0x00000001897E3390-0x00000001897E33E0
	// [IDTag] // 0x00000001897E3390-0x00000001897E33E0
	// [XID] // 0x00000001897E3390-0x00000001897E33E0
	public static void ContentHashOnto(Dictionary<string, ConfigEmojiBubbleData> dict, ref int hash_code) {} // 0x0000000180FF8AC0-0x0000000180FF8CD0
	[BlackList] // 0x00000001897F0F50-0x00000001897F0FA0
	// [IDTag] // 0x00000001897F0F50-0x00000001897F0FA0
	// [XID] // 0x00000001897F0F50-0x00000001897F0FA0
	public static void ContentHashOnto(ConfigMatLinearChangedByDistance[] arr, ref int hash_code) {} // 0x0000000180FF43B0-0x0000000180FF44C0
	[BlackList] // 0x00000001897FE240-0x00000001897FE290
	// [IDTag] // 0x00000001897FE240-0x00000001897FE290
	// [XID] // 0x00000001897FE240-0x00000001897FE290
	public static void ContentHashOnto(ConfigGadgetStateAction[] arr, ref int hash_code) {} // 0x0000000180FD9B80-0x0000000180FD9C90
	[BlackList] // 0x000000018980B900-0x000000018980B950
	// [IDTag] // 0x000000018980B900-0x000000018980B950
	// [XID] // 0x000000018980B900-0x000000018980B950
	public static void ContentHashOnto(ConfigControlPart[] arr, ref int hash_code) {} // 0x0000000180FE4440-0x0000000180FE4550
	[BlackList] // 0x0000000189819690-0x00000001898196E0
	// [IDTag] // 0x0000000189819690-0x00000001898196E0
	// [XID] // 0x0000000189819690-0x00000001898196E0
	public static void ContentHashOnto(Dictionary<string, ConfigGadget> dict, ref int hash_code) {} // 0x0000000180FE5370-0x0000000180FE5580
	[BlackList] // 0x00000001898269B0-0x0000000189826A00
	// [IDTag] // 0x00000001898269B0-0x0000000189826A00
	// [XID] // 0x00000001898269B0-0x0000000189826A00
	public static void ContentHashOnto(ConfigKeyInput[] arr, ref int hash_code) {} // 0x0000000180FF23D0-0x0000000180FF24E0
	[BlackList] // 0x0000000189833FD0-0x0000000189834020
	// [IDTag] // 0x0000000189833FD0-0x0000000189834020
	// [XID] // 0x0000000189833FD0-0x0000000189834020
	public static void ContentHashOnto(Dictionary<EFootprintPlatform, ConfigFootprintEffect> dict, ref int hash_code) {} // 0x00000001810027B0-0x00000001810029C0
	[BlackList] // 0x00000001898411F0-0x0000000189841240
	// [IDTag] // 0x00000001898411F0-0x0000000189841240
	// [XID] // 0x00000001898411F0-0x0000000189841240
	public static void ContentHashOnto(Dictionary<SceneSurfaceType, Dictionary<EFootprintPlatform, ConfigFootprintEffect>> dict, ref int hash_code) {} // 0x0000000180FF5C20-0x0000000180FF5E20
	[BlackList] // 0x000000018984E9B0-0x000000018984EA00
	// [IDTag] // 0x000000018984E9B0-0x000000018984EA00
	// [XID] // 0x000000018984E9B0-0x000000018984EA00
	public static void ContentHashOnto(Dictionary<string, ConfigMonsterInitialPose> dict, ref int hash_code) {} // 0x0000000180FFEA20-0x0000000180FFEC30
	[BlackList] // 0x000000018985BBC0-0x000000018985BC10
	// [IDTag] // 0x000000018985BBC0-0x000000018985BC10
	// [XID] // 0x000000018985BBC0-0x000000018985BC10
	public static void ContentHashOnto(Dictionary<string, ConfigLevelEntity> dict, ref int hash_code) {} // 0x0000000181004460-0x0000000181004670
	[BlackList] // 0x0000000189868E90-0x0000000189868EE0
	// [IDTag] // 0x0000000189868E90-0x0000000189868EE0
	// [XID] // 0x0000000189868E90-0x0000000189868EE0
	public static void ContentHashOnto(TransPointUpdateMaterial[] arr, ref int hash_code) {} // 0x0000000180FE1740-0x0000000180FE1850
	[BlackList] // 0x00000001898761E0-0x0000000189876230
	// [IDTag] // 0x00000001898761E0-0x0000000189876230
	// [XID] // 0x00000001898761E0-0x0000000189876230
	public static void ContentHashOnto(Dictionary<string, ConfigAttachment> dict, ref int hash_code) {} // 0x0000000180FDCDC0-0x0000000180FDCFD0
	[BlackList] // 0x00000001898834A0-0x00000001898834F0
	// [IDTag] // 0x00000001898834A0-0x00000001898834F0
	// [XID] // 0x00000001898834A0-0x00000001898834F0
	public static void ContentHashOnto(ConfigEntityBlackGrp[] arr, ref int hash_code) {} // 0x0000000180FF24E0-0x0000000180FF25F0
	[BlackList] // 0x0000000189890960-0x00000001898909B0
	// [IDTag] // 0x0000000189890960-0x00000001898909B0
	// [XID] // 0x0000000189890960-0x00000001898909B0
	public static void ContentHashOnto(Dictionary<string, ConfigEntityBlackGrp[]> dict, ref int hash_code) {} // 0x0000000180FDBEF0-0x0000000180FDC0F0
	[BlackList] // 0x000000018989DCC0-0x000000018989DD10
	// [IDTag] // 0x000000018989DCC0-0x000000018989DD10
	// [XID] // 0x000000018989DCC0-0x000000018989DD10
	public static void ContentHashOnto(ConfigEntityReuse[] arr, ref int hash_code) {} // 0x0000000180FDE1B0-0x0000000180FDE2C0
	[BlackList] // 0x00000001898AB0E0-0x00000001898AB130
	// [IDTag] // 0x00000001898AB0E0-0x00000001898AB130
	// [XID] // 0x00000001898AB0E0-0x00000001898AB130
	public static void ContentHashOnto(BowDrawTime[] arr, ref int hash_code) {} // 0x0000000180FE5260-0x0000000180FE5370
	[BlackList] // 0x00000001898B8DD0-0x00000001898B8E20
	// [IDTag] // 0x00000001898B8DD0-0x00000001898B8E20
	// [XID] // 0x00000001898B8DD0-0x00000001898B8E20
	public static void ContentHashOnto(TriggerToStates[] arr, ref int hash_code) {} // 0x0000000180FF3950-0x0000000180FF3A60
	[BlackList] // 0x00000001898C6190-0x00000001898C61E0
	// [IDTag] // 0x00000001898C6190-0x00000001898C61E0
	// [XID] // 0x00000001898C6190-0x00000001898C61E0
	public static void ContentHashOnto(WeaponAwayFromHandState[] arr, ref int hash_code) {} // 0x0000000180FDC0F0-0x0000000180FDC200
	[BlackList] // 0x00000001898D39A0-0x00000001898D39F0
	// [IDTag] // 0x00000001898D39A0-0x00000001898D39F0
	// [XID] // 0x00000001898D39A0-0x00000001898D39F0
	public static void ContentHashOnto(ConfigExternalVoiceSound[] arr, ref int hash_code) {} // 0x0000000180FEB2C0-0x0000000180FEB3D0
	[BlackList] // 0x00000001898E1870-0x00000001898E18C0
	// [IDTag] // 0x00000001898E1870-0x00000001898E18C0
	// [XID] // 0x00000001898E1870-0x00000001898E18C0
	public static void ContentHashOnto(ConfigExternalVoiceInferiorItem[] arr, ref int hash_code) {} // 0x0000000180FEF2D0-0x0000000180FEF3E0
	[BlackList] // 0x00000001898EF360-0x00000001898EF3B0
	// [IDTag] // 0x00000001898EF360-0x00000001898EF3B0
	// [XID] // 0x00000001898EF360-0x00000001898EF3B0
	public static void ContentHashOnto(Dictionary<string, ConfigExternalVoiceItem> dict, ref int hash_code) {} // 0x0000000180FFF3C0-0x0000000180FFF5D0
	[BlackList] // 0x00000001898FCA70-0x00000001898FCAC0
	// [IDTag] // 0x00000001898FCA70-0x00000001898FCAC0
	// [XID] // 0x00000001898FCA70-0x00000001898FCAC0
	public static void ContentHashOnto(Dictionary<uint, ConfigExternalVoiceLookupItem> dict, ref int hash_code) {} // 0x0000000180FE9DC0-0x0000000180FE9FD0
	[BlackList] // 0x000000018990A2A0-0x000000018990A2F0
	// [IDTag] // 0x000000018990A2A0-0x000000018990A2F0
	// [XID] // 0x000000018990A2A0-0x000000018990A2F0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ConfigExternalVoiceLookupItem> dict, ref int hash_code) {} // 0x0000000180FE3330-0x0000000180FE3570
	[BlackList] // 0x0000000189917DF0-0x0000000189917E40
	// [IDTag] // 0x0000000189917DF0-0x0000000189917E40
	// [XID] // 0x0000000189917DF0-0x0000000189917E40
	public static void ContentHashOnto(Dictionary<string, ConfigFlycloakFashion> dict, ref int hash_code) {} // 0x0000000180FF6BB0-0x0000000180FF6DC0
	[BlackList] // 0x0000000189925600-0x0000000189925650
	// [IDTag] // 0x0000000189925600-0x0000000189925650
	// [XID] // 0x0000000189925600-0x0000000189925650
	public static void ContentHashOnto(ConfigBaseGadgetTriggerAction[] arr, ref int hash_code) {} // 0x0000000180FFFD70-0x0000000180FFFE80
	[BlackList] // 0x0000000189932CC0-0x0000000189932D10
	// [IDTag] // 0x0000000189932CC0-0x0000000189932D10
	// [XID] // 0x0000000189932CC0-0x0000000189932D10
	public static void ContentHashOnto(Dictionary<string, ConfigPublicAISkillCD> dict, ref int hash_code) {} // 0x0000000181003AA0-0x0000000181003CB0
	[BlackList] // 0x00000001899401F0-0x0000000189940240
	// [IDTag] // 0x00000001899401F0-0x0000000189940240
	// [XID] // 0x00000001899401F0-0x0000000189940240
	public static void ContentHashOnto(Dictionary<string, ConfigBladeElementFx> dict, ref int hash_code) {} // 0x0000000180FF6790-0x0000000180FF69A0
	[BlackList] // 0x000000018994D810-0x000000018994D860
	// [IDTag] // 0x000000018994D810-0x000000018994D860
	// [XID] // 0x000000018994D810-0x000000018994D860
	public static void ContentHashOnto(ElementReactionType[] arr, ref int hash_code) {} // 0x0000000180FE7CC0-0x0000000180FE7DE0
	[BlackList] // 0x000000018995AE90-0x000000018995AEE0
	// [IDTag] // 0x000000018995AE90-0x000000018995AEE0
	// [XID] // 0x000000018995AE90-0x000000018995AEE0
	public static void ContentHashOnto(Dictionary<AbilityState, ElementReactionType[]> dict, ref int hash_code) {} // 0x0000000181003460-0x0000000181003660
	[BlackList] // 0x0000000189968760-0x00000001899687B0
	// [IDTag] // 0x0000000189968760-0x00000001899687B0
	// [XID] // 0x0000000189968760-0x00000001899687B0
	public static void ContentHashOnto(Dictionary<ElementType, ConfigElementShieldResistance> dict, ref int hash_code) {} // 0x0000000180FEC5B0-0x0000000180FEC7C0
	[BlackList] // 0x0000000189975ED0-0x0000000189975F20
	// [IDTag] // 0x0000000189975ED0-0x0000000189975F20
	// [XID] // 0x0000000189975ED0-0x0000000189975F20
	public static void ContentHashOnto(Dictionary<string, ConfigEliteShieldResistance> dict, ref int hash_code) {} // 0x0000000180FEE830-0x0000000180FEEA40
	[BlackList] // 0x0000000189983990-0x00000001899839E0
	// [IDTag] // 0x0000000189983990-0x00000001899839E0
	// [XID] // 0x0000000189983990-0x00000001899839E0
	public static void ContentHashOnto(Dictionary<ElementReactionType, string> dict, ref int hash_code) {} // 0x0000000180FF9EC0-0x0000000180FFA0C0
	[BlackList] // 0x00000001899913C0-0x0000000189991410
	// [IDTag] // 0x00000001899913C0-0x0000000189991410
	// [XID] // 0x00000001899913C0-0x0000000189991410
	public static void ContentHashOnto(Dictionary<string, ConfigAttackAttenuation> dict, ref int hash_code) {} // 0x0000000180FEC290-0x0000000180FEC4A0
	[BlackList] // 0x000000018999EF70-0x000000018999EFC0
	// [IDTag] // 0x000000018999EF70-0x000000018999EFC0
	// [XID] // 0x000000018999EF70-0x000000018999EFC0
	public static void ContentHashOnto(ConfigGadgetCreationLimit[] arr, ref int hash_code) {} // 0x0000000180FFB120-0x0000000180FFB230
	[BlackList] // 0x00000001899ACAF0-0x00000001899ACB40
	// [IDTag] // 0x00000001899ACAF0-0x00000001899ACB40
	// [XID] // 0x00000001899ACAF0-0x00000001899ACB40
	public static void ContentHashOnto(ConfigElementDecrate[] arr, ref int hash_code) {} // 0x0000000180FFA2E0-0x0000000180FFA3F0
	[BlackList] // 0x00000001899B9E60-0x00000001899B9EB0
	// [IDTag] // 0x00000001899B9E60-0x00000001899B9EB0
	// [XID] // 0x00000001899B9E60-0x00000001899B9EB0
	public static void ContentHashOnto(Dictionary<string, ConfigElementDecrate[]> dict, ref int hash_code) {} // 0x0000000180FF1890-0x0000000180FF1A90
	[BlackList] // 0x00000001899C78C0-0x00000001899C7910
	// [IDTag] // 0x00000001899C78C0-0x00000001899C7910
	// [XID] // 0x00000001899C78C0-0x00000001899C7910
	public static void ContentHashOnto(Dictionary<int, float> dict, ref int hash_code) {} // 0x0000000180FE3BC0-0x0000000180FE3DB0
	[BlackList] // 0x00000001899D4E30-0x00000001899D4E80
	// [IDTag] // 0x00000001899D4E30-0x00000001899D4E80
	// [XID] // 0x00000001899D4E30-0x00000001899D4E80
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, SimpleSafeFloat> dict, ref int hash_code) {} // 0x0000000180FE7970-0x0000000180FE7BB0
	[BlackList] // 0x00000001899E25A0-0x00000001899E25F0
	// [IDTag] // 0x00000001899E25A0-0x00000001899E25F0
	// [XID] // 0x00000001899E25A0-0x00000001899E25F0
	public static void ContentHashOnto(EquipSizeData[] arr, ref int hash_code) {} // 0x0000000180FDD300-0x0000000180FDD410
	[BlackList] // 0x00000001899EFDB0-0x00000001899EFE00
	// [IDTag] // 0x00000001899EFDB0-0x00000001899EFE00
	// [XID] // 0x00000001899EFDB0-0x00000001899EFE00
	public static void ContentHashOnto(Dictionary<int, EquipSizeData[]> dict, ref int hash_code) {} // 0x0000000180FE08B0-0x0000000180FE0AB0
	[BlackList] // 0x00000001899FD290-0x00000001899FD2E0
	// [IDTag] // 0x00000001899FD290-0x00000001899FD2E0
	// [XID] // 0x00000001899FD290-0x00000001899FD2E0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, EquipSizeData[]> dict, ref int hash_code) {} // 0x0000000180FEF0A0-0x0000000180FEF2D0
	[BlackList] // 0x0000000189A0A700-0x0000000189A0A750
	// [IDTag] // 0x0000000189A0A700-0x0000000189A0A750
	// [XID] // 0x0000000189A0A700-0x0000000189A0A750
	public static void ContentHashOnto(Dictionary<TDPlayTowerType, ConfigTDPlayTowerData> dict, ref int hash_code) {} // 0x0000000180FE2390-0x0000000180FE25A0
	[BlackList] // 0x0000000189A17CE0-0x0000000189A17D30
	// [IDTag] // 0x0000000189A17CE0-0x0000000189A17D30
	// [XID] // 0x0000000189A17CE0-0x0000000189A17D30
	public static void ContentHashOnto(Dictionary<NPCBodyType, FirstPersonCoopCamConfig> dict, ref int hash_code) {} // 0x0000000180FE4660-0x0000000180FE48D0
	[BlackList] // 0x0000000189A25060-0x0000000189A250B0
	// [IDTag] // 0x0000000189A25060-0x0000000189A250B0
	// [XID] // 0x0000000189A25060-0x0000000189A250B0
	public static void ContentHashOnto(ConfigGraphicsSettingEntry[] arr, ref int hash_code) {} // 0x0000000180FF8110-0x0000000180FF8220
	[BlackList] // 0x0000000189A32460-0x0000000189A324B0
	// [IDTag] // 0x0000000189A32460-0x0000000189A324B0
	// [XID] // 0x0000000189A32460-0x0000000189A324B0
	public static void ContentHashOnto(Dictionary<OptionType, ConfigPostprocessEffectSetting> dict, ref int hash_code) {} // 0x0000000180FE0AB0-0x0000000180FE0CC0
	[BlackList] // 0x0000000189A3FEB0-0x0000000189A3FF00
	// [IDTag] // 0x0000000189A3FEB0-0x0000000189A3FF00
	// [XID] // 0x0000000189A3FEB0-0x0000000189A3FF00
	public static void ContentHashOnto(Dictionary<OptionType, ConfigParticleEffectSetting> dict, ref int hash_code) {} // 0x0000000180FF3EA0-0x0000000180FF40B0
	[BlackList] // 0x0000000189A4D420-0x0000000189A4D470
	// [IDTag] // 0x0000000189A4D420-0x0000000189A4D470
	// [XID] // 0x0000000189A4D420-0x0000000189A4D470
	public static void ContentHashOnto(Dictionary<OptionType, ConfigComprehensiveQualitySetting> dict, ref int hash_code) {} // 0x0000000180FE27A0-0x0000000180FE29B0
	[BlackList] // 0x0000000189A5AAF0-0x0000000189A5AB40
	// [IDTag] // 0x0000000189A5AAF0-0x0000000189A5AB40
	// [XID] // 0x0000000189A5AAF0-0x0000000189A5AB40
	public static void ContentHashOnto(Dictionary<VolatileType, ConfigGraphicsVolatileSetting> dict, ref int hash_code) {} // 0x0000000180FEE620-0x0000000180FEE830
	[BlackList] // 0x0000000189A68B50-0x0000000189A68BA0
	// [IDTag] // 0x0000000189A68B50-0x0000000189A68BA0
	// [XID] // 0x0000000189A68B50-0x0000000189A68BA0
	public static void ContentHashOnto(ConfigGraphicsRequirement[] arr, ref int hash_code) {} // 0x00000001810067D0-0x00000001810068E0
	[BlackList] // 0x0000000189A75F20-0x0000000189A75F70
	// [IDTag] // 0x0000000189A75F20-0x0000000189A75F70
	// [XID] // 0x0000000189A75F20-0x0000000189A75F70
	public static void ContentHashOnto(Dictionary<ShadowQuality, ConfigShadowQualitySetting> dict, ref int hash_code) {} // 0x0000000181000C30-0x0000000181000E80
	[BlackList] // 0x0000000189A83A60-0x0000000189A83AB0
	// [IDTag] // 0x0000000189A83A60-0x0000000189A83AB0
	// [XID] // 0x0000000189A83A60-0x0000000189A83AB0
	public static void ContentHashOnto(ConfigRenderResolution[] arr, ref int hash_code) {} // 0x00000001810068E0-0x0000000181006A00
	[BlackList] // 0x0000000189A91170-0x0000000189A911C0
	// [IDTag] // 0x0000000189A91170-0x0000000189A911C0
	// [XID] // 0x0000000189A91170-0x0000000189A911C0
	public static void ContentHashOnto(Dictionary<string, ConfigGraphicsRecommendSetting> dict, ref int hash_code) {} // 0x00000001810065C0-0x00000001810067D0
	[BlackList] // 0x0000000189A9E530-0x0000000189A9E580
	// [IDTag] // 0x0000000189A9E530-0x0000000189A9E580
	// [XID] // 0x0000000189A9E530-0x0000000189A9E580
	public static void ContentHashOnto(Dictionary<string, ConfigPerformanceSetting> dict, ref int hash_code) {} // 0x0000000181005D70-0x0000000181005F80
	[BlackList] // 0x0000000189AABDE0-0x0000000189AABE30
	// [IDTag] // 0x0000000189AABDE0-0x0000000189AABE30
	// [XID] // 0x0000000189AABDE0-0x0000000189AABE30
	public static void ContentHashOnto(VolatileType[] arr, ref int hash_code) {} // 0x0000000180FDC720-0x0000000180FDC840
	[BlackList] // 0x0000000189AB9450-0x0000000189AB94A0
	// [IDTag] // 0x0000000189AB9450-0x0000000189AB94A0
	// [XID] // 0x0000000189AB9450-0x0000000189AB94A0
	public static void ContentHashOnto(Dictionary<PerfCostRatioGrade, float> dict, ref int hash_code) {} // 0x0000000180FF9550-0x0000000180FF9740
	[BlackList] // 0x0000000189AC72E0-0x0000000189AC7330
	// [IDTag] // 0x0000000189AC72E0-0x0000000189AC7330
	// [XID] // 0x0000000189AC72E0-0x0000000189AC7330
	public static void ContentHashOnto(Dictionary<PerfCostRatioGrade, SimpleSafeFloat> dict, ref int hash_code) {} // 0x0000000180FEA850-0x0000000180FEAA70
	[BlackList] // 0x0000000189AD50C0-0x0000000189AD5110
	// [IDTag] // 0x0000000189AD50C0-0x0000000189AD5110
	// [XID] // 0x0000000189AD50C0-0x0000000189AD5110
	public static void ContentHashOnto(Dictionary<FadeTintQualityLevel, ConfigTintFadeSetting> dict, ref int hash_code) {} // 0x0000000180FDDD70-0x0000000180FDDF80
	[BlackList] // 0x0000000189AE25C0-0x0000000189AE2610
	// [IDTag] // 0x0000000189AE25C0-0x0000000189AE2610
	// [XID] // 0x0000000189AE25C0-0x0000000189AE2610
	public static void ContentHashOnto(ConfigGuideAction[] arr, ref int hash_code) {} // 0x0000000180FFEC30-0x0000000180FFED40
	[BlackList] // 0x0000000189AF05F0-0x0000000189AF0640
	// [IDTag] // 0x0000000189AF05F0-0x0000000189AF0640
	// [XID] // 0x0000000189AF05F0-0x0000000189AF0640
	public static void ContentHashOnto(ConfigGuideCondition[] arr, ref int hash_code) {} // 0x0000000180FFF5D0-0x0000000180FFF6E0
	[BlackList] // 0x0000000189AFD9E0-0x0000000189AFDA30
	// [IDTag] // 0x0000000189AFD9E0-0x0000000189AFDA30
	// [XID] // 0x0000000189AFD9E0-0x0000000189AFDA30
	public static void ContentHashOnto(ConfigGuideCondition[][] arr, ref int hash_code) {} // 0x0000000181006390-0x00000001810064B0
	[BlackList] // 0x0000000189B0AF60-0x0000000189B0AFB0
	// [IDTag] // 0x0000000189B0AF60-0x0000000189B0AFB0
	// [XID] // 0x0000000189B0AF60-0x0000000189B0AFB0
	public static void ContentHashOnto(Dictionary<string, ConfigGuideTask> dict, ref int hash_code) {} // 0x0000000180FFD500-0x0000000180FFD710
	[BlackList] // 0x0000000189B18460-0x0000000189B184B0
	// [IDTag] // 0x0000000189B18460-0x0000000189B184B0
	// [XID] // 0x0000000189B18460-0x0000000189B184B0
	public static void ContentHashOnto(uint[][] arr, ref int hash_code) {} // 0x0000000180FE6600-0x0000000180FE6720
	[BlackList] // 0x0000000189B25AA0-0x0000000189B25AF0
	// [IDTag] // 0x0000000189B25AA0-0x0000000189B25AF0
	// [XID] // 0x0000000189B25AA0-0x0000000189B25AF0
	public static void ContentHashOnto(SimpleSafeUInt32[][] arr, ref int hash_code) {} // 0x0000000180FE1C80-0x0000000180FE1DA0
	[BlackList] // 0x0000000189B32CE0-0x0000000189B32D30
	// [IDTag] // 0x0000000189B32CE0-0x0000000189B32D30
	// [XID] // 0x0000000189B32CE0-0x0000000189B32D30
	public static void ContentHashOnto(InputActionType[] arr, ref int hash_code) {} // 0x0000000180FFCB70-0x0000000180FFCC90
	[BlackList] // 0x0000000189B40660-0x0000000189B406B0
	// [IDTag] // 0x0000000189B40660-0x0000000189B406B0
	// [XID] // 0x0000000189B40660-0x0000000189B406B0
	public static void ContentHashOnto(ConfigInputHint[] arr, ref int hash_code) {} // 0x0000000180FEEB60-0x0000000180FEEC70
	[BlackList] // 0x0000000189B4DF20-0x0000000189B4DF70
	// [IDTag] // 0x0000000189B4DF20-0x0000000189B4DF70
	// [XID] // 0x0000000189B4DF20-0x0000000189B4DF70
	public static void ContentHashOnto(ConfigGuideWidgetContent[] arr, ref int hash_code) {} // 0x0000000180FFFE80-0x0000000180FFFF90
	[BlackList] // 0x0000000189B5B960-0x0000000189B5B9B0
	// [IDTag] // 0x0000000189B5B960-0x0000000189B5B9B0
	// [XID] // 0x0000000189B5B960-0x0000000189B5B9B0
	public static void ContentHashOnto(ConfigHomeworldFurnitureUnit[] arr, ref int hash_code) {} // 0x0000000180FFF0B0-0x0000000180FFF1C0
	[BlackList] // 0x0000000189B69080-0x0000000189B690D0
	// [IDTag] // 0x0000000189B69080-0x0000000189B690D0
	// [XID] // 0x0000000189B69080-0x0000000189B690D0
	public static void ContentHashOnto(ConfigInterActor[] arr, ref int hash_code) {} // 0x0000000180FE7DE0-0x0000000180FE7EF0
	[BlackList] // 0x0000000189B76370-0x0000000189B763C0
	// [IDTag] // 0x0000000189B76370-0x0000000189B763C0
	// [XID] // 0x0000000189B76370-0x0000000189B763C0
	public static void ContentHashOnto(ConfigBaseInterAction[] arr, ref int hash_code) {} // 0x0000000180FE8800-0x0000000180FE8910
	[BlackList] // 0x0000000189B83C10-0x0000000189B83C60
	// [IDTag] // 0x0000000189B83C10-0x0000000189B83C60
	// [XID] // 0x0000000189B83C10-0x0000000189B83C60
	public static void ContentHashOnto(ConfigBaseInterAction[][] arr, ref int hash_code) {} // 0x0000000180FFF7F0-0x0000000180FFF910
	[BlackList] // 0x0000000189B91050-0x0000000189B910A0
	// [IDTag] // 0x0000000189B91050-0x0000000189B910A0
	// [XID] // 0x0000000189B91050-0x0000000189B910A0
	public static void ContentHashOnto(ConfigInterGrpId[] arr, ref int hash_code) {} // 0x0000000180FED530-0x0000000180FED640
	[BlackList] // 0x0000000189B9DF20-0x0000000189B9DF70
	// [IDTag] // 0x0000000189B9DF20-0x0000000189B9DF70
	// [XID] // 0x0000000189B9DF20-0x0000000189B9DF70
	public static void ContentHashOnto(Dictionary<string, ConfigLCBaseIntee> dict, ref int hash_code) {} // 0x0000000180FE1850-0x0000000180FE1A60
	[BlackList] // 0x0000000189BAB570-0x0000000189BAB5C0
	// [IDTag] // 0x0000000189BAB570-0x0000000189BAB5C0
	// [XID] // 0x0000000189BAB570-0x0000000189BAB5C0
	public static void ContentHashOnto(Dictionary<string, ConfigLCGadgetIntee> dict, ref int hash_code) {} // 0x0000000180FF53B0-0x0000000180FF55C0
	[BlackList] // 0x0000000189BB8690-0x0000000189BB86E0
	// [IDTag] // 0x0000000189BB8690-0x0000000189BB86E0
	// [XID] // 0x0000000189BB8690-0x0000000189BB86E0
	public static void ContentHashOnto(Dictionary<ConfigKeyCode, string> dict, ref int hash_code) {} // 0x0000000180FF1A90-0x0000000180FF1C90
	[BlackList] // 0x0000000189BC63B0-0x0000000189BC6400
	// [IDTag] // 0x0000000189BC63B0-0x0000000189BC6400
	// [XID] // 0x0000000189BC63B0-0x0000000189BC6400
	public static void ContentHashOnto(Dictionary<KeyboardType, ConfigKeyboardLayoutItem> dict, ref int hash_code) {} // 0x0000000180FE8D30-0x0000000180FE8F40
	[BlackList] // 0x0000000189BD3DD0-0x0000000189BD3E20
	// [IDTag] // 0x0000000189BD3DD0-0x0000000189BD3E20
	// [XID] // 0x0000000189BD3DD0-0x0000000189BD3E20
	public static void ContentHashOnto(Dictionary<InputActionGroupType, InputActionType[]> dict, ref int hash_code) {} // 0x0000000180FF1C90-0x0000000180FF1E90
	[BlackList] // 0x00000001895E6610-0x00000001895E6660
	// [IDTag] // 0x00000001895E6610-0x00000001895E6660
	// [XID] // 0x00000001895E6610-0x00000001895E6660
	public static void ContentHashOnto(TextLanguageType[] arr, ref int hash_code) {} // 0x0000000180FDD930-0x0000000180FDDA50
	[BlackList] // 0x00000001895F3F20-0x00000001895F3F70
	// [IDTag] // 0x00000001895F3F20-0x00000001895F3F70
	// [XID] // 0x00000001895F3F20-0x00000001895F3F70
	public static void ContentHashOnto(Dictionary<string, TextLanguageType[]> dict, ref int hash_code) {} // 0x0000000181002390-0x0000000181002590
	[BlackList] // 0x00000001896018B0-0x0000000189601900
	// [IDTag] // 0x00000001896018B0-0x0000000189601900
	// [XID] // 0x00000001896018B0-0x0000000189601900
	public static void ContentHashOnto(VoiceLanguageType[] arr, ref int hash_code) {} // 0x0000000180FFA930-0x0000000180FFAA50
	[BlackList] // 0x000000018960F140-0x000000018960F190
	// [IDTag] // 0x000000018960F140-0x000000018960F190
	// [XID] // 0x000000018960F140-0x000000018960F190
	public static void ContentHashOnto(Dictionary<string, VoiceLanguageType[]> dict, ref int hash_code) {} // 0x0000000180FF5E20-0x0000000180FF6020
	[BlackList] // 0x000000018961C810-0x000000018961C860
	// [IDTag] // 0x000000018961C810-0x000000018961C860
	// [XID] // 0x000000018961C810-0x000000018961C860
	public static void ContentHashOnto(ConfigActionPoint[] arr, ref int hash_code) {} // 0x0000000180FF7700-0x0000000180FF7810
	[BlackList] // 0x0000000189629E70-0x0000000189629EC0
	// [IDTag] // 0x0000000189629E70-0x0000000189629EC0
	// [XID] // 0x0000000189629E70-0x0000000189629EC0
	public static void ContentHashOnto(IndicatorCondition[] arr, ref int hash_code) {} // 0x0000000180FEA2F0-0x0000000180FEA400
	[BlackList] // 0x00000001896379C0-0x0000000189637A10
	// [IDTag] // 0x00000001896379C0-0x0000000189637A10
	// [XID] // 0x00000001896379C0-0x0000000189637A10
	public static void ContentHashOnto(IndicatorLogic[] arr, ref int hash_code) {} // 0x0000000180FE2FE0-0x0000000180FE30F0
	[BlackList] // 0x0000000189644D90-0x0000000189644DE0
	// [IDTag] // 0x0000000189644D90-0x0000000189644DE0
	// [XID] // 0x0000000189644D90-0x0000000189644DE0
	public static void ContentHashOnto(Dictionary<string, ConfigUIIndicator> dict, ref int hash_code) {} // 0x0000000180FE5CC0-0x0000000180FE5ED0
	[BlackList] // 0x0000000189652440-0x0000000189652490
	// [IDTag] // 0x0000000189652440-0x0000000189652490
	// [XID] // 0x0000000189652440-0x0000000189652490
	public static void ContentHashOnto(LevelGadget[] arr, ref int hash_code) {} // 0x0000000180FDE6C0-0x0000000180FDE7D0
	[BlackList] // 0x000000018965FB90-0x000000018965FBE0
	// [IDTag] // 0x000000018965FB90-0x000000018965FBE0
	// [XID] // 0x000000018965FB90-0x000000018965FBE0
	public static void ContentHashOnto(ConfigLevelBlockMeta[] arr, ref int hash_code) {} // 0x0000000180FDE2C0-0x0000000180FDE3D0
	[BlackList] // 0x000000018966D2B0-0x000000018966D300
	// [IDTag] // 0x000000018966D2B0-0x000000018966D300
	// [XID] // 0x000000018966D2B0-0x000000018966D300
	public static void ContentHashOnto(Dictionary<uint, ConfigLevelBlockMeta[]> dict, ref int hash_code) {} // 0x0000000180FEAC70-0x0000000180FEAE70
	[BlackList] // 0x000000018967AF50-0x000000018967AFA0
	// [IDTag] // 0x000000018967AF50-0x000000018967AFA0
	// [XID] // 0x000000018967AF50-0x000000018967AFA0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ConfigLevelBlockMeta[]> dict, ref int hash_code) {} // 0x0000000180FE1510-0x0000000180FE1740
	[BlackList] // 0x0000000189688C30-0x0000000189688C80
	// [IDTag] // 0x0000000189688C30-0x0000000189688C80
	// [XID] // 0x0000000189688C30-0x0000000189688C80
	public static void ContentHashOnto(ConfigLevelMonsterUnit[] arr, ref int hash_code) {} // 0x0000000180FFDBA0-0x0000000180FFDCB0
	[BlackList] // 0x0000000189696840-0x0000000189696890
	// [IDTag] // 0x0000000189696840-0x0000000189696890
	// [XID] // 0x0000000189696840-0x0000000189696890
	public static void ContentHashOnto(ConfigLevelPolygonTag[] arr, ref int hash_code) {} // 0x0000000180FFD950-0x0000000180FFDA70
	[BlackList] // 0x00000001896A39A0-0x00000001896A39F0
	// [IDTag] // 0x00000001896A39A0-0x00000001896A39F0
	// [XID] // 0x00000001896A39A0-0x00000001896A39F0
	public static void ContentHashOnto(ConfigLevelPolygon[] arr, ref int hash_code) {} // 0x0000000181005F80-0x0000000181006090
	[BlackList] // 0x00000001896B0850-0x00000001896B08A0
	// [IDTag] // 0x00000001896B0850-0x00000001896B08A0
	// [XID] // 0x00000001896B0850-0x00000001896B08A0
	public static void ContentHashOnto(ConfigWaypoint[] arr, ref int hash_code) {} // 0x0000000180FFDCB0-0x0000000180FFDDC0
	[BlackList] // 0x00000001896BDC30-0x00000001896BDC80
	// [IDTag] // 0x00000001896BDC30-0x00000001896BDC80
	// [XID] // 0x00000001896BDC30-0x00000001896BDC80
	public static void ContentHashOnto(ConfigRoute[] arr, ref int hash_code) {} // 0x0000000180FEDB80-0x0000000180FEDC90
	[BlackList] // 0x00000001896CB0D0-0x00000001896CB120
	// [IDTag] // 0x00000001896CB0D0-0x00000001896CB120
	// [XID] // 0x00000001896CB0D0-0x00000001896CB120
	public static void ContentHashOnto(ConfigPoint[] arr, ref int hash_code) {} // 0x0000000180FE4550-0x0000000180FE4660
	[BlackList] // 0x00000001896D8750-0x00000001896D87A0
	// [IDTag] // 0x00000001896D8750-0x00000001896D87A0
	// [XID] // 0x00000001896D8750-0x00000001896D87A0
	public static void ContentHashOnto(ConfigPointArray[] arr, ref int hash_code) {} // 0x0000000180FF7810-0x0000000180FF7920
	[BlackList] // 0x00000001896E5B30-0x00000001896E5B80
	// [IDTag] // 0x00000001896E5B30-0x00000001896E5B80
	// [XID] // 0x00000001896E5B30-0x00000001896E5B80
	public static void ContentHashOnto(Dictionary<string, ConfigLogoPage> dict, ref int hash_code) {} // 0x0000000180FDA0A0-0x0000000180FDA2B0
	[BlackList] // 0x00000001896F31B0-0x00000001896F3200
	// [IDTag] // 0x00000001896F31B0-0x00000001896F3200
	// [XID] // 0x00000001896F31B0-0x00000001896F3200
	public static void ContentHashOnto(ConfigVCustomMapMark[] arr, ref int hash_code) {} // 0x0000000180FF1120-0x0000000180FF1230
	[BlackList] // 0x0000000189700600-0x0000000189700650
	// [IDTag] // 0x0000000189700600-0x0000000189700650
	// [XID] // 0x0000000189700600-0x0000000189700650
	public static void ContentHashOnto(ConfigVBaseMark[] arr, ref int hash_code) {} // 0x0000000180FE0CC0-0x0000000180FE0DD0
	[BlackList] // 0x000000018970DEE0-0x000000018970DF30
	// [IDTag] // 0x000000018970DEE0-0x000000018970DF30
	// [XID] // 0x000000018970DEE0-0x000000018970DF30
	public static void ContentHashOnto(Dictionary<MarkType, ConfigMark> dict, ref int hash_code) {} // 0x0000000180FD9510-0x0000000180FD9760
	[BlackList] // 0x000000018971B7C0-0x000000018971B810
	// [IDTag] // 0x000000018971B7C0-0x000000018971B810
	// [XID] // 0x000000018971B7C0-0x000000018971B810
	public static void ContentHashOnto(Dictionary<MarkIconType, ConfigMarkIcon> dict, ref int hash_code) {} // 0x0000000180FDE3D0-0x0000000180FDE6C0
	[BlackList] // 0x0000000189728A10-0x0000000189728A60
	// [IDTag] // 0x0000000189728A10-0x0000000189728A60
	// [XID] // 0x0000000189728A10-0x0000000189728A60
	public static void ContentHashOnto(MarkIconType[] arr, ref int hash_code) {} // 0x0000000181005930-0x0000000181005A50
	[BlackList] // 0x00000001897361B0-0x0000000189736200
	// [IDTag] // 0x00000001897361B0-0x0000000189736200
	// [XID] // 0x00000001897361B0-0x0000000189736200
	public static void ContentHashOnto(Dictionary<SceneBuildingType, MarkIconType> dict, ref int hash_code) {} // 0x0000000180FE8F40-0x0000000180FE9130
	[BlackList] // 0x0000000189743A70-0x0000000189743AC0
	// [IDTag] // 0x0000000189743A70-0x0000000189743AC0
	// [XID] // 0x0000000189743A70-0x0000000189743AC0
	public static void ContentHashOnto(Dictionary<MarkOrder, int> dict, ref int hash_code) {} // 0x0000000180FDD410-0x0000000180FDD600
	[BlackList] // 0x0000000189751020-0x0000000189751070
	// [IDTag] // 0x0000000189751020-0x0000000189751070
	// [XID] // 0x0000000189751020-0x0000000189751070
	public static void ContentHashOnto(Dictionary<MarkOrder, SimpleSafeInt32> dict, ref int hash_code) {} // 0x00000001810001C0-0x00000001810003E0
	[BlackList] // 0x000000018975E890-0x000000018975E8E0
	// [IDTag] // 0x000000018975E890-0x000000018975E8E0
	// [XID] // 0x000000018975E890-0x000000018975E8E0
	public static void ContentHashOnto(VelocityForceType[] arr, ref int hash_code) {} // 0x0000000180FF3830-0x0000000180FF3950
	[BlackList] // 0x000000018976BFE0-0x000000018976C030
	// [IDTag] // 0x000000018976BFE0-0x000000018976C030
	// [XID] // 0x000000018976BFE0-0x000000018976C030
	public static void ContentHashOnto(Dictionary<uint, PositionModifyState> dict, ref int hash_code) {} // 0x0000000180FDA2B0-0x0000000180FDA4A0
	[BlackList] // 0x00000001897795D0-0x0000000189779620
	// [IDTag] // 0x00000001897795D0-0x0000000189779620
	// [XID] // 0x00000001897795D0-0x0000000189779620
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, PositionModifyState> dict, ref int hash_code) {} // 0x0000000180FF21B0-0x0000000180FF23D0
	[BlackList] // 0x0000000189786CB0-0x0000000189786D00
	// [IDTag] // 0x0000000189786CB0-0x0000000189786D00
	// [XID] // 0x0000000189786CB0-0x0000000189786D00
	public static void ContentHashOnto(ConfigEntityCollider[] arr, ref int hash_code) {} // 0x0000000180FE48D0-0x0000000180FE49E0
	[BlackList] // 0x0000000189793EB0-0x0000000189793F00
	// [IDTag] // 0x0000000189793EB0-0x0000000189793F00
	// [XID] // 0x0000000189793EB0-0x0000000189793F00
	public static void ContentHashOnto(Dictionary<string, ConfigPlatformUIAction> dict, ref int hash_code) {} // 0x0000000180FE4BF0-0x0000000180FE4E00
	[BlackList] // 0x00000001897A1F00-0x00000001897A1F50
	// [IDTag] // 0x00000001897A1F00-0x00000001897A1F50
	// [XID] // 0x00000001897A1F00-0x00000001897A1F50
	public static void ContentHashOnto(Dictionary<string, ConfigPlatformUIData> dict, ref int hash_code) {} // 0x0000000180FF8330-0x0000000180FF8540
	[BlackList] // 0x00000001897AF890-0x00000001897AF8E0
	// [IDTag] // 0x00000001897AF890-0x00000001897AF8E0
	// [XID] // 0x00000001897AF890-0x00000001897AF8E0
	public static void ContentHashOnto(MusicGameParam[] arr, ref int hash_code) {} // 0x0000000180FDB650-0x0000000180FDB770
	[BlackList] // 0x00000001897BDDA0-0x00000001897BDDF0
	// [IDTag] // 0x00000001897BDDA0-0x00000001897BDDF0
	// [XID] // 0x00000001897BDDA0-0x00000001897BDDF0
	public static void ContentHashOnto(ConfigMusicCondition[] arr, ref int hash_code) {} // 0x0000000180FF4CC0-0x0000000180FF4DD0
	[BlackList] // 0x00000001897CB260-0x00000001897CB2B0
	// [IDTag] // 0x00000001897CB260-0x00000001897CB2B0
	// [XID] // 0x00000001897CB260-0x00000001897CB2B0
	public static void ContentHashOnto(ConfigMusicShifter[] arr, ref int hash_code) {} // 0x0000000180FFB650-0x0000000180FFB760
	[BlackList] // 0x00000001897D90A0-0x00000001897D90F0
	// [IDTag] // 0x00000001897D90A0-0x00000001897D90F0
	// [XID] // 0x00000001897D90A0-0x00000001897D90F0
	public static void ContentHashOnto(ConfigMusicFixedTimeTransitions[] arr, ref int hash_code) {} // 0x0000000181004CF0-0x0000000181004E00
	[BlackList] // 0x00000001897E6370-0x00000001897E63C0
	// [IDTag] // 0x00000001897E6370-0x00000001897E63C0
	// [XID] // 0x00000001897E6370-0x00000001897E63C0
	public static void ContentHashOnto(ConfigMusicStimulusHandler[] arr, ref int hash_code) {} // 0x0000000180FFCC90-0x0000000180FFCDA0
	[BlackList] // 0x00000001897F3F90-0x00000001897F3FE0
	// [IDTag] // 0x00000001897F3F90-0x00000001897F3FE0
	// [XID] // 0x00000001897F3F90-0x00000001897F3FE0
	public static void ContentHashOnto(ConfigSong[] arr, ref int hash_code) {} // 0x0000000180FD9760-0x0000000180FD9870
	[BlackList] // 0x0000000189801600-0x0000000189801650
	// [IDTag] // 0x0000000189801600-0x0000000189801650
	// [XID] // 0x0000000189801600-0x0000000189801650
	public static void ContentHashOnto(ConfigMusicGameKey[] arr, ref int hash_code) {} // 0x0000000180FF74E0-0x0000000180FF75F0
	[BlackList] // 0x000000018980EAF0-0x000000018980EB40
	// [IDTag] // 0x000000018980EAF0-0x000000018980EB40
	// [XID] // 0x000000018980EAF0-0x000000018980EB40
	public static void ContentHashOnto(CameraPlayCondition[] arr, ref int hash_code) {} // 0x0000000180FF8F10-0x0000000180FF9020
	[BlackList] // 0x000000018981C360-0x000000018981C3B0
	// [IDTag] // 0x000000018981C360-0x000000018981C3B0
	// [XID] // 0x000000018981C360-0x000000018981C3B0
	public static void ContentHashOnto(ConfigMusicCamera[] arr, ref int hash_code) {} // 0x0000000181007260-0x0000000181007370
	[BlackList] // 0x0000000189829910-0x0000000189829960
	// [IDTag] // 0x0000000189829910-0x0000000189829960
	// [XID] // 0x0000000189829910-0x0000000189829960
	public static void ContentHashOnto(ConfigNpcBornPos[] arr, ref int hash_code) {} // 0x0000000181003FD0-0x00000001810040E0
	[BlackList] // 0x0000000189836FD0-0x0000000189837020
	// [IDTag] // 0x0000000189836FD0-0x0000000189837020
	// [XID] // 0x0000000189836FD0-0x0000000189837020
	public static void ContentHashOnto(ConfigActionButton[] arr, ref int hash_code) {} // 0x0000000180FE4330-0x0000000180FE4440
	[BlackList] // 0x00000001898444A0-0x00000001898444F0
	// [IDTag] // 0x00000001898444A0-0x00000001898444F0
	// [XID] // 0x00000001898444A0-0x00000001898444F0
	public static void ContentHashOnto(Dictionary<ActionSlotType, ConfigActionButton[]> dict, ref int hash_code) {} // 0x0000000180FF07A0-0x0000000180FF09A0
	[BlackList] // 0x00000001898516D0-0x0000000189851720
	// [IDTag] // 0x00000001898516D0-0x0000000189851720
	// [XID] // 0x00000001898516D0-0x0000000189851720
	public static void ContentHashOnto(Dictionary<string, ConfigActionPanelState> dict, ref int hash_code) {} // 0x0000000180FF9020-0x0000000180FF9230
	[BlackList] // 0x000000018985E390-0x000000018985E3E0
	// [IDTag] // 0x000000018985E390-0x000000018985E3E0
	// [XID] // 0x000000018985E390-0x000000018985E3E0
	public static void ContentHashOnto(Dictionary<ActionPanelState, string> dict, ref int hash_code) {} // 0x0000000181005530-0x0000000181005730
	[BlackList] // 0x000000018986BDD0-0x000000018986BE20
	// [IDTag] // 0x000000018986BDD0-0x000000018986BE20
	// [XID] // 0x000000018986BDD0-0x000000018986BE20
	public static void ContentHashOnto(Dictionary<PlayModeType, ConfigActionPanelMode> dict, ref int hash_code) {} // 0x0000000180FFD0C0-0x0000000180FFD2D0
	[BlackList] // 0x0000000189879370-0x00000001898793C0
	// [IDTag] // 0x0000000189879370-0x00000001898793C0
	// [XID] // 0x0000000189879370-0x00000001898793C0
	public static void ContentHashOnto(Dictionary<ConfigPreloadType, string[]> dict, ref int hash_code) {} // 0x0000000180FEAA70-0x0000000180FEAC70
	[BlackList] // 0x0000000189886780-0x00000001898867D0
	// [IDTag] // 0x0000000189886780-0x00000001898867D0
	// [XID] // 0x0000000189886780-0x00000001898867D0
	public static void ContentHashOnto(Dictionary<uint, ConfigPreload> dict, ref int hash_code) {} // 0x0000000180FEBE70-0x0000000180FEC080
	[BlackList] // 0x0000000189893970-0x00000001898939C0
	// [IDTag] // 0x0000000189893970-0x00000001898939C0
	// [XID] // 0x0000000189893970-0x00000001898939C0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ConfigPreload> dict, ref int hash_code) {} // 0x0000000180FDBB90-0x0000000180FDBDD0
	[BlackList] // 0x00000001898A0B60-0x00000001898A0BB0
	// [IDTag] // 0x00000001898A0B60-0x00000001898A0BB0
	// [XID] // 0x00000001898A0B60-0x00000001898A0BB0
	public static void ContentHashOnto(ConfigPreloadType[] arr, ref int hash_code) {} // 0x0000000180FF2800-0x0000000180FF2920
	[BlackList] // 0x00000001898AE6F0-0x00000001898AE740
	// [IDTag] // 0x00000001898AE6F0-0x00000001898AE740
	// [XID] // 0x00000001898AE6F0-0x00000001898AE740
	public static void ContentHashOnto(Dictionary<ConfigPreloadType, ConfigPreloadType[]> dict, ref int hash_code) {} // 0x0000000180FF1230-0x0000000180FF1430
	[BlackList] // 0x00000001898BBDF0-0x00000001898BBE40
	// [IDTag] // 0x00000001898BBDF0-0x00000001898BBE40
	// [XID] // 0x00000001898BBDF0-0x00000001898BBE40
	public static void ContentHashOnto(ConfigContentRestriction[] arr, ref int hash_code) {} // 0x0000000180FDEE50-0x0000000180FDEF60
	[BlackList] // 0x00000001898C9390-0x00000001898C93E0
	// [IDTag] // 0x00000001898C9390-0x00000001898C93E0
	// [XID] // 0x00000001898C9390-0x00000001898C93E0
	public static void ContentHashOnto(QuestCondEx[] arr, ref int hash_code) {} // 0x0000000181001300-0x0000000181001410
	[BlackList] // 0x00000001898D6C80-0x00000001898D6CD0
	// [IDTag] // 0x00000001898D6C80-0x00000001898D6CD0
	// [XID] // 0x00000001898D6C80-0x00000001898D6CD0
	public static void ContentHashOnto(QuestContentEx[] arr, ref int hash_code) {} // 0x0000000180FDFE10-0x0000000180FDFF20
	[BlackList] // 0x00000001898E4820-0x00000001898E4870
	// [IDTag] // 0x00000001898E4820-0x00000001898E4870
	// [XID] // 0x00000001898E4820-0x00000001898E4870
	public static void ContentHashOnto(QuestExecEx[] arr, ref int hash_code) {} // 0x0000000180FF1430-0x0000000180FF1540
	[BlackList] // 0x00000001898F2350-0x00000001898F23A0
	// [IDTag] // 0x00000001898F2350-0x00000001898F23A0
	// [XID] // 0x00000001898F2350-0x00000001898F23A0
	public static void ContentHashOnto(ConfigTalkScheme[] arr, ref int hash_code) {} // 0x0000000180FF6450-0x0000000180FF6560
	[BlackList] // 0x00000001898FFC90-0x00000001898FFCE0
	// [IDTag] // 0x00000001898FFC90-0x00000001898FFCE0
	// [XID] // 0x00000001898FFC90-0x00000001898FFCE0
	public static void ContentHashOnto(ConfigQuestScheme[] arr, ref int hash_code) {} // 0x0000000181005A50-0x0000000181005B60
	[BlackList] // 0x000000018990D510-0x000000018990D560
	// [IDTag] // 0x000000018990D510-0x000000018990D560
	// [XID] // 0x000000018990D510-0x000000018990D560
	public static void ContentHashOnto(AnimatorFloat[] arr, ref int hash_code) {} // 0x0000000180FE9560-0x0000000180FE9670
	[BlackList] // 0x000000018991AE40-0x000000018991AE90
	// [IDTag] // 0x000000018991AE40-0x000000018991AE90
	// [XID] // 0x000000018991AE40-0x000000018991AE90
	public static void ContentHashOnto(AnimatorInt[] arr, ref int hash_code) {} // 0x00000001810005F0-0x0000000181000700
	[BlackList] // 0x00000001899286A0-0x00000001899286F0
	// [IDTag] // 0x00000001899286A0-0x00000001899286F0
	// [XID] // 0x00000001899286A0-0x00000001899286F0
	public static void ContentHashOnto(AnimatorBool[] arr, ref int hash_code) {} // 0x0000000180FE5580-0x0000000180FE5690
	[BlackList] // 0x00000001899358B0-0x0000000189935900
	// [IDTag] // 0x00000001899358B0-0x0000000189935900
	// [XID] // 0x00000001899358B0-0x0000000189935900
	public static void ContentHashOnto(AnimatorTrigger[] arr, ref int hash_code) {} // 0x0000000181002590-0x00000001810026A0
	[BlackList] // 0x0000000189942F70-0x0000000189942FC0
	// [IDTag] // 0x0000000189942F70-0x0000000189942FC0
	// [XID] // 0x0000000189942F70-0x0000000189942FC0
	public static void ContentHashOnto(RendererFloat[] arr, ref int hash_code) {} // 0x0000000180FF5A10-0x0000000180FF5B20
	[BlackList] // 0x0000000189950950-0x00000001899509A0
	// [IDTag] // 0x0000000189950950-0x00000001899509A0
	// [XID] // 0x0000000189950950-0x00000001899509A0
	public static void ContentHashOnto(MaterialFloat[] arr, ref int hash_code) {} // 0x0000000180FFF910-0x0000000180FFFA20
	[BlackList] // 0x000000018995E030-0x000000018995E080
	// [IDTag] // 0x000000018995E030-0x000000018995E080
	// [XID] // 0x000000018995E030-0x000000018995E080
	public static void ContentHashOnto(ConfigRecordEmoFunc[] arr, ref int hash_code) {} // 0x0000000180FFA1D0-0x0000000180FFA2E0
	[BlackList] // 0x000000018996B510-0x000000018996B560
	// [IDTag] // 0x000000018996B510-0x000000018996B560
	// [XID] // 0x000000018996B510-0x000000018996B560
	public static void ContentHashOnto(ConfigRecordActorBase[] arr, ref int hash_code) {} // 0x0000000180FF9440-0x0000000180FF9550
	[BlackList] // 0x0000000189979560-0x00000001899795B0
	// [IDTag] // 0x0000000189979560-0x00000001899795B0
	// [XID] // 0x0000000189979560-0x00000001899795B0
	public static void ContentHashOnto(ConfigRecordFrame[] arr, ref int hash_code) {} // 0x0000000180FECB90-0x0000000180FECCA0
	[BlackList] // 0x00000001899865B0-0x0000000189986600
	// [IDTag] // 0x00000001899865B0-0x0000000189986600
	// [XID] // 0x00000001899865B0-0x0000000189986600
	public static void ContentHashOnto(ConfigRecordActorInfo[] arr, ref int hash_code) {} // 0x00000001810026A0-0x00000001810027B0
	[BlackList] // 0x0000000189994630-0x0000000189994680
	// [IDTag] // 0x0000000189994630-0x0000000189994680
	// [XID] // 0x0000000189994630-0x0000000189994680
	public static void ContentHashOnto(Dictionary<ElementType, ConfigResonanceCutScene> dict, ref int hash_code) {} // 0x0000000180FDC840-0x0000000180FDCA50
	[BlackList] // 0x00000001899A2060-0x00000001899A20B0
	// [IDTag] // 0x00000001899A2060-0x00000001899A20B0
	// [XID] // 0x00000001899A2060-0x00000001899A20B0
	public static void ContentHashOnto(Dictionary<string, ConfigScenePoint> dict, ref int hash_code) {} // 0x0000000180FE9350-0x0000000180FE9560
	[BlackList] // 0x00000001899AFA10-0x00000001899AFA60
	// [IDTag] // 0x00000001899AFA10-0x00000001899AFA60
	// [XID] // 0x00000001899AFA10-0x00000001899AFA60
	public static void ContentHashOnto(DungeonQuestCondition[] arr, ref int hash_code) {} // 0x0000000180FE1FB0-0x0000000180FE20C0
	[BlackList] // 0x00000001899BD0D0-0x00000001899BD120
	// [IDTag] // 0x00000001899BD0D0-0x00000001899BD120
	// [XID] // 0x00000001899BD0D0-0x00000001899BD120
	public static void ContentHashOnto(Dictionary<string, ConfigSceneArea> dict, ref int hash_code) {} // 0x0000000180FEF710-0x0000000180FEF920
	[BlackList] // 0x00000001899CA890-0x00000001899CA8E0
	// [IDTag] // 0x00000001899CA890-0x00000001899CA8E0
	// [XID] // 0x00000001899CA890-0x00000001899CA8E0
	public static void ContentHashOnto(Dictionary<string, ConfigForceField> dict, ref int hash_code) {} // 0x0000000181005130-0x0000000181005340
	[BlackList] // 0x00000001899D7D40-0x00000001899D7D90
	// [IDTag] // 0x00000001899D7D40-0x00000001899D7D90
	// [XID] // 0x00000001899D7D40-0x00000001899D7D90
	public static void ContentHashOnto(Dictionary<string, ConfigLocalEntity> dict, ref int hash_code) {} // 0x0000000180FDF8B0-0x0000000180FDFAC0
	[BlackList] // 0x00000001899E5910-0x00000001899E5960
	// [IDTag] // 0x00000001899E5910-0x00000001899E5960
	// [XID] // 0x00000001899E5910-0x00000001899E5960
	public static void ContentHashOnto(Dictionary<string, ConfigLoadingDoor> dict, ref int hash_code) {} // 0x0000000180FEC080-0x0000000180FEC290
	[BlackList] // 0x00000001899F2DB0-0x00000001899F2E00
	// [IDTag] // 0x00000001899F2DB0-0x00000001899F2E00
	// [XID] // 0x00000001899F2DB0-0x00000001899F2E00
	public static void ContentHashOnto(ConfigWorldArea[] arr, ref int hash_code) {} // 0x0000000180FEBD60-0x0000000180FEBE70
	[BlackList] // 0x0000000189A000D0-0x0000000189A00120
	// [IDTag] // 0x0000000189A000D0-0x0000000189A00120
	// [XID] // 0x0000000189A000D0-0x0000000189A00120
	public static void ContentHashOnto(ConfigLevel1WorldArea[] arr, ref int hash_code) {} // 0x0000000180FF42A0-0x0000000180FF43B0
	[BlackList] // 0x0000000189A0D950-0x0000000189A0D9A0
	// [IDTag] // 0x0000000189A0D950-0x0000000189A0D9A0
	// [XID] // 0x0000000189A0D950-0x0000000189A0D9A0
	public static void ContentHashOnto(ConfigLevelArea[] arr, ref int hash_code) {} // 0x0000000180FDE9E0-0x0000000180FDEAF0
	[BlackList] // 0x0000000189A1AB00-0x0000000189A1AB50
	// [IDTag] // 0x0000000189A1AB00-0x0000000189A1AB50
	// [XID] // 0x0000000189A1AB00-0x0000000189A1AB50
	public static void ContentHashOnto(ConfigLevelBlock[] arr, ref int hash_code) {} // 0x0000000180FE7BB0-0x0000000180FE7CC0
	[BlackList] // 0x0000000189A27E70-0x0000000189A27EC0
	// [IDTag] // 0x0000000189A27E70-0x0000000189A27EC0
	// [XID] // 0x0000000189A27E70-0x0000000189A27EC0
	public static void ContentHashOnto(EnvZoneEventType[] arr, ref int hash_code) {} // 0x00000001810000A0-0x00000001810001C0
	[BlackList] // 0x0000000189A357D0-0x0000000189A35820
	// [IDTag] // 0x0000000189A357D0-0x0000000189A35820
	// [XID] // 0x0000000189A357D0-0x0000000189A35820
	public static void ContentHashOnto(ConfigEnvironmentZone[] arr, ref int hash_code) {} // 0x0000000180FEFD40-0x0000000180FEFE50
	[BlackList] // 0x0000000189A42EB0-0x0000000189A42F00
	// [IDTag] // 0x0000000189A42EB0-0x0000000189A42F00
	// [XID] // 0x0000000189A42EB0-0x0000000189A42F00
	public static void ContentHashOnto(ConfigWeatherArea[] arr, ref int hash_code) {} // 0x0000000180FE20C0-0x0000000180FE21D0
	[BlackList] // 0x0000000189A505C0-0x0000000189A50610
	// [IDTag] // 0x0000000189A505C0-0x0000000189A50610
	// [XID] // 0x0000000189A505C0-0x0000000189A50610
	public static void ContentHashOnto(ConfigHomeFurniture[] arr, ref int hash_code) {} // 0x0000000180FE9FD0-0x0000000180FEA0E0
	[BlackList] // 0x0000000189A5DF10-0x0000000189A5DF60
	// [IDTag] // 0x0000000189A5DF10-0x0000000189A5DF60
	// [XID] // 0x0000000189A5DF10-0x0000000189A5DF60
	public static void ContentHashOnto(ConfigHomeFurnitureSuite[] arr, ref int hash_code) {} // 0x0000000181003240-0x0000000181003350
	[BlackList] // 0x0000000189A6B910-0x0000000189A6B960
	// [IDTag] // 0x0000000189A6B910-0x0000000189A6B960
	// [XID] // 0x0000000189A6B910-0x0000000189A6B960
	public static void ContentHashOnto(ConfigHomeAnimal[] arr, ref int hash_code) {} // 0x0000000180FF75F0-0x0000000180FF7700
	[BlackList] // 0x0000000189A790C0-0x0000000189A79110
	// [IDTag] // 0x0000000189A790C0-0x0000000189A79110
	// [XID] // 0x0000000189A790C0-0x0000000189A79110
	public static void ContentHashOnto(ConfigWeekendDjinn[] arr, ref int hash_code) {} // 0x0000000180FE6DB0-0x0000000180FE6EC0
	[BlackList] // 0x0000000189A866F0-0x0000000189A86740
	// [IDTag] // 0x0000000189A866F0-0x0000000189A86740
	// [XID] // 0x0000000189A866F0-0x0000000189A86740
	public static void ContentHashOnto(ConfigHomeBlock[] arr, ref int hash_code) {} // 0x0000000180FE0380-0x0000000180FE0490
	[BlackList] // 0x0000000189A93EE0-0x0000000189A93F30
	// [IDTag] // 0x0000000189A93EE0-0x0000000189A93F30
	// [XID] // 0x0000000189A93EE0-0x0000000189A93F30
	public static void ContentHashOnto(Dictionary<int, ConfigJob> dict, ref int hash_code) {} // 0x0000000180FF6DC0-0x0000000180FF6FD0
	[BlackList] // 0x0000000189AA1490-0x0000000189AA14E0
	// [IDTag] // 0x0000000189AA1490-0x0000000189AA14E0
	// [XID] // 0x0000000189AA1490-0x0000000189AA14E0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, ConfigJob> dict, ref int hash_code) {} // 0x0000000180FECED0-0x0000000180FED110
	[BlackList] // 0x0000000189AAED40-0x0000000189AAED90
	// [IDTag] // 0x0000000189AAED40-0x0000000189AAED90
	// [XID] // 0x0000000189AAED40-0x0000000189AAED90
	public static void ContentHashOnto(Dictionary<int, Dictionary<int, ConfigJob>> dict, ref int hash_code) {} // 0x0000000180FFF1C0-0x0000000180FFF3C0
	[BlackList] // 0x0000000189ABCA80-0x0000000189ABCAD0
	// [IDTag] // 0x0000000189ABCA80-0x0000000189ABCAD0
	// [XID] // 0x0000000189ABCA80-0x0000000189ABCAD0
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigJob>> dict, ref int hash_code) {} // 0x0000000180FE4100-0x0000000180FE4330
	[BlackList] // 0x0000000189ACA200-0x0000000189ACA250
	// [IDTag] // 0x0000000189ACA200-0x0000000189ACA250
	// [XID] // 0x0000000189ACA200-0x0000000189ACA250
	public static void ContentHashOnto(SECTR_PlatformStreamLayer[] arr, ref int hash_code) {} // 0x0000000180FFFF90-0x00000001810000A0
	[BlackList] // 0x0000000189AD7EE0-0x0000000189AD7F30
	// [IDTag] // 0x0000000189AD7EE0-0x0000000189AD7F30
	// [XID] // 0x0000000189AD7EE0-0x0000000189AD7F30
	public static void ContentHashOnto(SECTR_AttachStreamLayer[] arr, ref int hash_code) {} // 0x0000000180FD9400-0x0000000180FD9510
	[BlackList] // 0x0000000189AE5C30-0x0000000189AE5C80
	// [IDTag] // 0x0000000189AE5C30-0x0000000189AE5C80
	// [XID] // 0x0000000189AE5C30-0x0000000189AE5C80
	public static void ContentHashOnto(SECTR_StreamLayer[] arr, ref int hash_code) {} // 0x0000000180FFE2E0-0x0000000180FFE3F0
	[BlackList] // 0x0000000189AF34F0-0x0000000189AF3540
	// [IDTag] // 0x0000000189AF34F0-0x0000000189AF3540
	// [XID] // 0x0000000189AF34F0-0x0000000189AF3540
	public static void ContentHashOnto(SECTR_LayerGroup[] arr, ref int hash_code) {} // 0x0000000180FFFC60-0x0000000180FFFD70
	[BlackList] // 0x0000000189B00930-0x0000000189B00980
	// [IDTag] // 0x0000000189B00930-0x0000000189B00980
	// [XID] // 0x0000000189B00930-0x0000000189B00980
	public static void ContentHashOnto(SECTR_StreamObject[] arr, ref int hash_code) {} // 0x0000000180FFA820-0x0000000180FFA930
	[BlackList] // 0x0000000189B0E0E0-0x0000000189B0E130
	// [IDTag] // 0x0000000189B0E0E0-0x0000000189B0E130
	// [XID] // 0x0000000189B0E0E0-0x0000000189B0E130
	public static void ContentHashOnto(SECTR_BakeLayerInfo[] arr, ref int hash_code) {} // 0x0000000180FE8240-0x0000000180FE8350
	[BlackList] // 0x0000000189B1B510-0x0000000189B1B560
	// [IDTag] // 0x0000000189B1B510-0x0000000189B1B560
	// [XID] // 0x0000000189B1B510-0x0000000189B1B560
	public static void ContentHashOnto(Dictionary<string, ConfigBaseShape> dict, ref int hash_code) {} // 0x0000000180FF7B60-0x0000000180FF7D70
	[BlackList] // 0x0000000189B28950-0x0000000189B289A0
	// [IDTag] // 0x0000000189B28950-0x0000000189B289A0
	// [XID] // 0x0000000189B28950-0x0000000189B289A0
	public static void ContentHashOnto(TemplateParam[] arr, ref int hash_code) {} // 0x0000000180FF3720-0x0000000180FF3830
	[BlackList] // 0x0000000189B35AB0-0x0000000189B35B00
	// [IDTag] // 0x0000000189B35AB0-0x0000000189B35B00
	// [XID] // 0x0000000189B35AB0-0x0000000189B35B00
	public static void ContentHashOnto(SkinColor[] arr, ref int hash_code) {} // 0x0000000181001770-0x0000000181001880
	[BlackList] // 0x0000000189B437A0-0x0000000189B437F0
	// [IDTag] // 0x0000000189B437A0-0x0000000189B437F0
	// [XID] // 0x0000000189B437A0-0x0000000189B437F0
	public static void ContentHashOnto(Dictionary<string, ConfigSkin> dict, ref int hash_code) {} // 0x0000000180FFCDA0-0x0000000180FFCFB0
	[BlackList] // 0x0000000189B510E0-0x0000000189B51130
	// [IDTag] // 0x0000000189B510E0-0x0000000189B51130
	// [XID] // 0x0000000189B510E0-0x0000000189B51130
	public static void ContentHashOnto(Dictionary<string, ConfigSoundBankUnloadPolicy> dict, ref int hash_code) {} // 0x0000000181003890-0x0000000181003AA0
	[BlackList] // 0x0000000189B5E9A0-0x0000000189B5E9F0
	// [IDTag] // 0x0000000189B5E9A0-0x0000000189B5E9F0
	// [XID] // 0x0000000189B5E9A0-0x0000000189B5E9F0
	public static void ContentHashOnto(ConfigSpatialBoxRoomTrigger[] arr, ref int hash_code) {} // 0x0000000180FF6340-0x0000000180FF6450
	[BlackList] // 0x0000000189B6BBB0-0x0000000189B6BC00
	// [IDTag] // 0x0000000189B6BBB0-0x0000000189B6BC00
	// [XID] // 0x0000000189B6BBB0-0x0000000189B6BC00
	public static void ContentHashOnto(ConfigSpatialSphereRoomTrigger[] arr, ref int hash_code) {} // 0x0000000180FEA520-0x0000000180FEA630
	[BlackList] // 0x0000000189B79300-0x0000000189B79350
	// [IDTag] // 0x0000000189B79300-0x0000000189B79350
	// [XID] // 0x0000000189B79300-0x0000000189B79350
	public static void ContentHashOnto(ConfigSpatialRoom[] arr, ref int hash_code) {} // 0x0000000180FEA630-0x0000000180FEA740
	[BlackList] // 0x0000000189B86C90-0x0000000189B86CE0
	// [IDTag] // 0x0000000189B86C90-0x0000000189B86CE0
	// [XID] // 0x0000000189B86C90-0x0000000189B86CE0
	public static void ContentHashOnto(ConfigSpatialPortal[] arr, ref int hash_code) {} // 0x0000000180FECCA0-0x0000000180FECDB0
	[BlackList] // 0x0000000189B93CC0-0x0000000189B93D10
	// [IDTag] // 0x0000000189B93CC0-0x0000000189B93D10
	// [XID] // 0x0000000189B93CC0-0x0000000189B93D10
	public static void ContentHashOnto(ConfigStateAudioEvent[] arr, ref int hash_code) {} // 0x0000000180FE2280-0x0000000180FE2390
	[BlackList] // 0x0000000189BA0F60-0x0000000189BA0FB0
	// [IDTag] // 0x0000000189BA0F60-0x0000000189BA0FB0
	// [XID] // 0x0000000189BA0F60-0x0000000189BA0FB0
	public static void ContentHashOnto(ConfigAnimatorBoolean[] arr, ref int hash_code) {} // 0x0000000180FF0F00-0x0000000180FF1010
	[BlackList] // 0x0000000189BAE130-0x0000000189BAE180
	// [IDTag] // 0x0000000189BAE130-0x0000000189BAE180
	// [XID] // 0x0000000189BAE130-0x0000000189BAE180
	public static void ContentHashOnto(ConfigCanChangeAvatar[] arr, ref int hash_code) {} // 0x0000000180FFA0C0-0x0000000180FFA1D0
	[BlackList] // 0x0000000189BBB990-0x0000000189BBB9E0
	// [IDTag] // 0x0000000189BBB990-0x0000000189BBB9E0
	// [XID] // 0x0000000189BBB990-0x0000000189BBB9E0
	public static void ContentHashOnto(ConfigEquipReattach[] arr, ref int hash_code) {} // 0x0000000180FDD820-0x0000000180FDD930
	[BlackList] // 0x0000000189BC9460-0x0000000189BC94B0
	// [IDTag] // 0x0000000189BC9460-0x0000000189BC94B0
	// [XID] // 0x0000000189BC9460-0x0000000189BC94B0
	public static void ContentHashOnto(Dictionary<string, ConfigNormalStateIDInfo> dict, ref int hash_code) {} // 0x0000000180FFE0D0-0x0000000180FFE2E0
	[BlackList] // 0x0000000189BD69B0-0x0000000189BD6A00
	// [IDTag] // 0x0000000189BD69B0-0x0000000189BD6A00
	// [XID] // 0x0000000189BD69B0-0x0000000189BD6A00
	public static void ContentHashOnto(Dictionary<string, ConfigBaseStateLayer> dict, ref int hash_code) {} // 0x0000000181002AD0-0x0000000181002CE0
	[BlackList] // 0x00000001895E98B0-0x00000001895E9900
	// [IDTag] // 0x00000001895E98B0-0x00000001895E9900
	// [XID] // 0x00000001895E98B0-0x00000001895E9900
	public static void ContentHashOnto(ConfigTalentMixin[] arr, ref int hash_code) {} // 0x0000000180FED110-0x0000000180FED220
	[BlackList] // 0x00000001895F72C0-0x00000001895F7310
	// [IDTag] // 0x00000001895F72C0-0x00000001895F7310
	// [XID] // 0x00000001895F72C0-0x00000001895F7310
	public static void ContentHashOnto(Dictionary<string, ConfigTalentMixin[]> dict, ref int hash_code) {} // 0x0000000180FF0280-0x0000000180FF0480
	[BlackList] // 0x0000000189604940-0x0000000189604990
	// [IDTag] // 0x0000000189604940-0x0000000189604990
	// [XID] // 0x0000000189604940-0x0000000189604990
	public static void ContentHashOnto(TalkCondEx[] arr, ref int hash_code) {} // 0x0000000180FF1540-0x0000000180FF1650
	[BlackList] // 0x0000000189611F60-0x0000000189611FB0
	// [IDTag] // 0x0000000189611F60-0x0000000189611FB0
	// [XID] // 0x0000000189611F60-0x0000000189611FB0
	public static void ContentHashOnto(TalkExecEx[] arr, ref int hash_code) {} // 0x0000000180FD9870-0x0000000180FD9980
	[BlackList] // 0x000000018961F8D0-0x000000018961F920
	// [IDTag] // 0x000000018961F8D0-0x000000018961F920
	// [XID] // 0x000000018961F8D0-0x000000018961F920
	public static void ContentHashOnto(ConfigDialogScheme[] arr, ref int hash_code) {} // 0x0000000180FF0690-0x0000000180FF07A0
	[BlackList] // 0x000000018962CC00-0x000000018962CC50
	// [IDTag] // 0x000000018962CC00-0x000000018962CC50
	// [XID] // 0x000000018962CC00-0x000000018962CC50
	public static void ContentHashOnto(Dictionary<int, TextMapLevelStruct> dict, ref int hash_code) {} // 0x0000000180FDCFD0-0x0000000180FDD1F0
	[BlackList] // 0x000000018963A720-0x000000018963A770
	// [IDTag] // 0x000000018963A720-0x000000018963A770
	// [XID] // 0x000000018963A720-0x000000018963A770
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, TextMapLevelStruct> dict, ref int hash_code) {} // 0x0000000180FE70C0-0x0000000180FE7310
	[BlackList] // 0x0000000189647D10-0x0000000189647D60
	// [IDTag] // 0x0000000189647D10-0x0000000189647D60
	// [XID] // 0x0000000189647D10-0x0000000189647D60
	public static void ContentHashOnto(Dictionary<TextMapPlatformType, int> dict, ref int hash_code) {} // 0x0000000180FF40B0-0x0000000180FF42A0
	[BlackList] // 0x0000000189655670-0x00000001896556C0
	// [IDTag] // 0x0000000189655670-0x00000001896556C0
	// [XID] // 0x0000000189655670-0x00000001896556C0
	public static void ContentHashOnto(Dictionary<TextMapPlatformType, SimpleSafeInt32> dict, ref int hash_code) {} // 0x0000000181000A10-0x0000000181000C30
	[BlackList] // 0x0000000189662A40-0x0000000189662A90
	// [IDTag] // 0x0000000189662A40-0x0000000189662A90
	// [XID] // 0x0000000189662A40-0x0000000189662A90
	public static void ContentHashOnto(Dictionary<InputActionType, ConfigBaseInputAction> dict, ref int hash_code) {} // 0x0000000180FEB610-0x0000000180FEB820
	[BlackList] // 0x0000000189670910-0x0000000189670960
	// [IDTag] // 0x0000000189670910-0x0000000189670960
	// [XID] // 0x0000000189670910-0x0000000189670960
	public static void ContentHashOnto(Dictionary<InputEventType, ConfigBaseInputEvent> dict, ref int hash_code) {} // 0x0000000180FDCA50-0x0000000180FDCC60
	[BlackList] // 0x000000018967DF60-0x000000018967DFB0
	// [IDTag] // 0x000000018967DF60-0x000000018967DFB0
	// [XID] // 0x000000018967DF60-0x000000018967DFB0
	public static void ContentHashOnto(InputActionEvent[] arr, ref int hash_code) {} // 0x0000000180FEDFB0-0x0000000180FEE0E0
	[BlackList] // 0x000000018968BB90-0x000000018968BBE0
	// [IDTag] // 0x000000018968BB90-0x000000018968BBE0
	// [XID] // 0x000000018968BB90-0x000000018968BBE0
	public static void ContentHashOnto(Dictionary<string, InputActionEvent[]> dict, ref int hash_code) {} // 0x0000000180FD9980-0x0000000180FD9B80
	[BlackList] // 0x0000000189699520-0x0000000189699570
	// [IDTag] // 0x0000000189699520-0x0000000189699570
	// [XID] // 0x0000000189699520-0x0000000189699570
	public static void ContentHashOnto(Dictionary<int, DeviceAction> dict, ref int hash_code) {} // 0x0000000180FF8540-0x0000000180FF87B0
	[BlackList] // 0x00000001896A66C0-0x00000001896A6710
	// [IDTag] // 0x00000001896A66C0-0x00000001896A6710
	// [XID] // 0x00000001896A66C0-0x00000001896A6710
	public static void ContentHashOnto(Dictionary<SimpleSafeInt32, DeviceAction> dict, ref int hash_code) {} // 0x0000000181001CD0-0x0000000181001F70
	[BlackList] // 0x00000001896B3AB0-0x00000001896B3B00
	// [IDTag] // 0x00000001896B3AB0-0x00000001896B3B00
	// [XID] // 0x00000001896B3AB0-0x00000001896B3B00
	public static void ContentHashOnto(Dictionary<string, ConfigBaseContext> dict, ref int hash_code) {} // 0x0000000181005B60-0x0000000181005D70
	[BlackList] // 0x00000001896C0C90-0x00000001896C0CE0
	// [IDTag] // 0x00000001896C0C90-0x00000001896C0CE0
	// [XID] // 0x00000001896C0C90-0x00000001896C0CE0
	public static void ContentHashOnto(MainPageUIDisableType[] arr, ref int hash_code) {} // 0x0000000180FDEAF0-0x0000000180FDEC10
	[BlackList] // 0x00000001896CE350-0x00000001896CE3A0
	// [IDTag] // 0x00000001896CE350-0x00000001896CE3A0
	// [XID] // 0x00000001896CE350-0x00000001896CE3A0
	public static void ContentHashOnto(InputEventType[] arr, ref int hash_code) {} // 0x0000000180FECDB0-0x0000000180FECED0
	[BlackList] // 0x00000001896DB6F0-0x00000001896DB740
	// [IDTag] // 0x00000001896DB6F0-0x00000001896DB740
	// [XID] // 0x00000001896DB6F0-0x00000001896DB740
	public static void ContentHashOnto(Dictionary<string, ConfigMainPageDisableInfo> dict, ref int hash_code) {} // 0x00000001810003E0-0x00000001810005F0
	[BlackList] // 0x00000001896E8B60-0x00000001896E8BB0
	// [IDTag] // 0x00000001896E8B60-0x00000001896E8BB0
	// [XID] // 0x00000001896E8B60-0x00000001896E8BB0
	public static void ContentHashOnto(ConfigElemBall[] arr, ref int hash_code) {} // 0x0000000180FFB340-0x0000000180FFB450
	[BlackList] // 0x00000001896F6210-0x00000001896F6260
	// [IDTag] // 0x00000001896F6210-0x00000001896F6260
	// [XID] // 0x00000001896F6210-0x00000001896F6260
	public static void ContentHashOnto(Dictionary<string, ConfigBaseWidget> dict, ref int hash_code) {} // 0x0000000180FE5ED0-0x0000000180FE60E0
	[BlackList] // 0x0000000189703790-0x00000001897037E0
	// [IDTag] // 0x0000000189703790-0x00000001897037E0
	// [XID] // 0x0000000189703790-0x00000001897037E0
	public static void ContentHashOnto(ConfigWidgetAction[] arr, ref int hash_code) {} // 0x0000000181003350-0x0000000181003460
	[BlackList] // 0x0000000189711090-0x00000001897110E0
	// [IDTag] // 0x0000000189711090-0x00000001897110E0
	// [XID] // 0x0000000189711090-0x00000001897110E0
	public static void ContentHashOnto(ConfigWidgetPredict[] arr, ref int hash_code) {} // 0x0000000180FDFF20-0x0000000180FE0030
	[BlackList] // 0x000000018971E5B0-0x000000018971E600
	// [IDTag] // 0x000000018971E5B0-0x000000018971E600
	// [XID] // 0x000000018971E5B0-0x000000018971E600
	public static void ContentHashOnto(WidgetOccupyTag[] arr, ref int hash_code) {} // 0x0000000181005010-0x0000000181005130
	[BlackList] // 0x000000018972B970-0x000000018972B9C0
	// [IDTag] // 0x000000018972B970-0x000000018972B9C0
	// [XID] // 0x000000018972B970-0x000000018972B9C0
	public static void ContentHashOnto(Dictionary<uint, ConfigWidgetGadget> dict, ref int hash_code) {} // 0x0000000180FF9CB0-0x0000000180FF9EC0
	[BlackList] // 0x0000000189739050-0x00000001897390A0
	// [IDTag] // 0x0000000189739050-0x00000001897390A0
	// [XID] // 0x0000000189739050-0x00000001897390A0
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ConfigWidgetGadget> dict, ref int hash_code) {} // 0x0000000180FFFA20-0x0000000180FFFC60
	[BlackList] // 0x0000000189746BA0-0x0000000189746BF0
	// [IDTag] // 0x0000000189746BA0-0x0000000189746BF0
	// [XID] // 0x0000000189746BA0-0x0000000189746BF0
	public static void ContentHashOnto(Dictionary<uint, ConfigWidgetCdGroup> dict, ref int hash_code) {} // 0x0000000180FF25F0-0x0000000180FF2800
	[BlackList] // 0x0000000189754220-0x0000000189754270
	// [IDTag] // 0x0000000189754220-0x0000000189754270
	// [XID] // 0x0000000189754220-0x0000000189754270
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ConfigWidgetCdGroup> dict, ref int hash_code) {} // 0x0000000180FF7D70-0x0000000180FF7FB0
	[BlackList] // 0x0000000189761A20-0x0000000189761A70
	// [IDTag] // 0x0000000189761A20-0x0000000189761A70
	// [XID] // 0x0000000189761A20-0x0000000189761A70
	public static void ContentHashOnto(Dictionary<uint, ConfigBaseWidgetToy> dict, ref int hash_code) {} // 0x0000000180FEC980-0x0000000180FECB90
	[BlackList] // 0x000000018976EC00-0x000000018976EC50
	// [IDTag] // 0x000000018976EC00-0x000000018976EC50
	// [XID] // 0x000000018976EC00-0x000000018976EC50
	public static void ContentHashOnto(Dictionary<SimpleSafeUInt32, ConfigBaseWidgetToy> dict, ref int hash_code) {} // 0x0000000180FDEC10-0x0000000180FDEE50
	[BlackList] // 0x000000018977C3F0-0x000000018977C440
	// [IDTag] // 0x000000018977C3F0-0x000000018977C440
	// [XID] // 0x000000018977C3F0-0x000000018977C440
	public static void ContentHashOnto(ConfigWwiseString[] arr, ref int hash_code) {} // 0x0000000180FF4FE0-0x0000000180FF50F0
	[BlackList] // 0x0000000189789A40-0x0000000189789A90
	// [IDTag] // 0x0000000189789A40-0x0000000189789A90
	// [XID] // 0x0000000189789A40-0x0000000189789A90
	public static void ContentHashOnto(Dictionary<string, ConfigWwiseString> dict, ref int hash_code) {} // 0x0000000180FFA3F0-0x0000000180FFA600
}

