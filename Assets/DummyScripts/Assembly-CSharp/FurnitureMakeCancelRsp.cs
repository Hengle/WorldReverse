﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FurnitureMakeCancelRsp : MessageBase, IMessage<FurnitureMakeCancelRsp> // TypeDefIndex: 23469
{
	// Fields
	private static readonly MessageParser<FurnitureMakeCancelRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0417B
	private int retcode_; // 0x18
	public const int MakeIdFieldNumber = 2; // Metadata: 0x00B0417F
	private uint makeId_; // 0x1C
	public const int FurnitureMakeSlotFieldNumber = 3; // Metadata: 0x00B04183
	private FurnitureMakeSlot furnitureMakeSlot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FurnitureMakeCancelRsp> Parser { get => default; } // 0x0000000184AD5B40-0x0000000184AD5BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184AD58D0-0x0000000184AD5960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184AD5470-0x0000000184AD54F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184AD4AC0-0x0000000184AD4B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184AD6010-0x0000000184AD6100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184AD5E00-0x0000000184AD5E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184AD5960-0x0000000184AD5A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184AD5FC0-0x0000000184AD6010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184AD5590-0x0000000184AD5680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184AD53D0-0x0000000184AD5470 0x0000000184AD4F30-0x0000000184AD4FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MakeId { get => default; set {} } // 0x0000000184AD4CD0-0x0000000184AD4D70 0x0000000184AD4A20-0x0000000184AD4AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeSlot FurnitureMakeSlot { get => default; set {} } // 0x0000000184AD5CE0-0x0000000184AD5D80 0x0000000184AD5830-0x0000000184AD58D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23470
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23471
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4609
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeCancelRsp() {} // 0x0000000184AD6430-0x0000000184AD6490
	static FurnitureMakeCancelRsp() {} // 0x0000000184AD6370-0x0000000184AD6430

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeCancelRsp Clone() => default; // 0x0000000184AD5A50-0x0000000184AD5B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FurnitureMakeCancelRsp ShallowCopy() => default; // 0x0000000184AD54F0-0x0000000184AD5590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184AD4D70-0x0000000184AD4DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184AD5C60-0x0000000184AD5CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184AD5D80-0x0000000184AD5E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184AD4DF0-0x0000000184AD4F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184AD4FD0-0x0000000184AD50A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FurnitureMakeCancelRsp other) => default; // 0x0000000184AD50A0-0x0000000184AD51F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184AD5680-0x0000000184AD5830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184AD6100-0x0000000184AD6370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184AD5E60-0x0000000184AD5FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184AD51F0-0x0000000184AD53D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FurnitureMakeCancelRsp other) {} // 0x0000000184AD4B20-0x0000000184AD4CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184AD48C0-0x0000000184AD4A20
}

