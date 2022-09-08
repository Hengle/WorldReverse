﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DeliveryActivityDetailInfo : MessageBase, IMessage<DeliveryActivityDetailInfo> // TypeDefIndex: 21988
{
	// Fields
	private static readonly MessageParser<DeliveryActivityDetailInfo> _parser; // 0x00
	public const int DayIndexFieldNumber = 1; // Metadata: 0x00B00833
	private uint dayIndex_; // 0x18
	public const int FinishedDeliveryQuestIndexFieldNumber = 2; // Metadata: 0x00B00837
	private static readonly FieldCodec<uint> _repeated_finishedDeliveryQuestIndex_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> finishedDeliveryQuestIndex_; // 0x20
	public const int IsTakenRewardFieldNumber = 3; // Metadata: 0x00B0083B
	private bool isTakenReward_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DeliveryActivityDetailInfo> Parser { get => default; } // 0x0000000184754D20-0x0000000184754DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184754970-0x0000000184754A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184754630-0x00000001847546B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184753E30-0x0000000184753E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184755110-0x0000000184755200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184754EE0-0x0000000184754F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184754A00-0x0000000184754AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001847550C0-0x0000000184755110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184754750-0x0000000184754840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DayIndex { get => default; set {} } // 0x0000000184754BE0-0x0000000184754C80 0x0000000184754C80-0x0000000184754D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishedDeliveryQuestIndex { get => default; } // 0x0000000184754530-0x0000000184754590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTakenReward { get => default; set {} } // 0x0000000184754590-0x0000000184754630 0x0000000184753E90-0x0000000184753F30

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DeliveryActivityDetailInfo() {} // 0x0000000184755550-0x00000001847555E0
	static DeliveryActivityDetailInfo() {} // 0x0000000184755470-0x0000000184755550

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DeliveryActivityDetailInfo Clone() => default; // 0x0000000184754AF0-0x0000000184754BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DeliveryActivityDetailInfo ShallowCopy() => default; // 0x00000001847546B0-0x0000000184754750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184754090-0x00000001847540E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184754E40-0x0000000184754E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184754E90-0x0000000184754EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001847540E0-0x00000001847541C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184754300-0x00000001847543D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DeliveryActivityDetailInfo other) => default; // 0x00000001847541C0-0x0000000184754300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184754840-0x0000000184754970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184755200-0x0000000184755470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184754F40-0x00000001847550C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001847543D0-0x0000000184754530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DeliveryActivityDetailInfo other) {} // 0x0000000184753F30-0x0000000184754090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184753CB0-0x0000000184753E30
}

