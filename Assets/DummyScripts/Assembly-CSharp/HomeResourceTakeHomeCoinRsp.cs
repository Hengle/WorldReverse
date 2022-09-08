﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeResourceTakeHomeCoinRsp : MessageBase, IMessage<HomeResourceTakeHomeCoinRsp> // TypeDefIndex: 23518
{
	// Fields
	private static readonly MessageParser<HomeResourceTakeHomeCoinRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04317
	private int retcode_; // 0x18
	public const int HomeCoinFieldNumber = 2; // Metadata: 0x00B0431B
	private HomeResource homeCoin_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeResourceTakeHomeCoinRsp> Parser { get => default; } // 0x00000001812F6E30-0x00000001812F6EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001812F6BC0-0x00000001812F6C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001812F6830-0x00000001812F68B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001812F5F20-0x00000001812F5F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001812F7220-0x00000001812F7310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001812F7050-0x00000001812F70B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001812F6C50-0x00000001812F6D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001812F71D0-0x00000001812F7220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001812F6950-0x00000001812F6A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001812F6790-0x00000001812F6830 0x00000001812F6350-0x00000001812F63F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResource HomeCoin { get => default; set {} } // 0x00000001812F62B0-0x00000001812F6350 0x00000001812F5E80-0x00000001812F5F20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23519
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23520
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4702
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceTakeHomeCoinRsp() {} // 0x00000001812F75B0-0x00000001812F7610
	static HomeResourceTakeHomeCoinRsp() {} // 0x00000001812F74F0-0x00000001812F75B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceTakeHomeCoinRsp Clone() => default; // 0x00000001812F6D40-0x00000001812F6E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeResourceTakeHomeCoinRsp ShallowCopy() => default; // 0x00000001812F68B0-0x00000001812F6950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001812F6100-0x00000001812F6180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812F6F50-0x00000001812F6FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812F6FD0-0x00000001812F7050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001812F6180-0x00000001812F62B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001812F6520-0x00000001812F65F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeResourceTakeHomeCoinRsp other) => default; // 0x00000001812F63F0-0x00000001812F6520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001812F6A40-0x00000001812F6BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001812F7310-0x00000001812F74F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001812F70B0-0x00000001812F71D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001812F65F0-0x00000001812F6790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeResourceTakeHomeCoinRsp other) {} // 0x00000001812F5F80-0x00000001812F6100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001812F5D40-0x00000001812F5E80
}

