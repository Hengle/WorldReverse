﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarFetterDataNotify : MessageBase, IMessage<AvatarFetterDataNotify> // TypeDefIndex: 22450
{
	// Fields
	private static readonly MessageParser<AvatarFetterDataNotify> _parser; // 0x00
	public const int FetterInfoMapFieldNumber = 1; // Metadata: 0x00B019AF
	private static readonly MapField<ulong, AvatarFetterInfo> _map_fetterInfoMap_codec; // 0x08
	private readonly MapField<ulong, AvatarFetterInfo> fetterInfoMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarFetterDataNotify> Parser { get => default; } // 0x0000000181889460-0x00000001818894F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818891F0-0x0000000181889280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181888EF0-0x0000000181888F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818888E0-0x0000000181888940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818897D0-0x00000001818898C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181889620-0x0000000181889680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181889280-0x0000000181889370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181889780-0x00000001818897D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181889010-0x0000000181889100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<ulong, AvatarFetterInfo> FetterInfoMap { get => default; } // 0x0000000181888E90-0x0000000181888EF0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22451
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22452
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1723
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterDataNotify() {} // 0x0000000181889B70-0x0000000181889C00
	static AvatarFetterDataNotify() {} // 0x0000000181889A10-0x0000000181889B70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterDataNotify Clone() => default; // 0x0000000181889370-0x0000000181889460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterDataNotify ShallowCopy() => default; // 0x0000000181888F70-0x0000000181889010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181888A50-0x0000000181888AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181889580-0x00000001818895D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818895D0-0x0000000181889620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181888AA0-0x0000000181888B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181888B50-0x0000000181888C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarFetterDataNotify other) => default; // 0x0000000181888C20-0x0000000181888DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181889100-0x00000001818891F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818898C0-0x0000000181889A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181889680-0x0000000181889780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181888DA0-0x0000000181888E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarFetterDataNotify other) {} // 0x0000000181888940-0x0000000181888A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818887B0-0x00000001818888E0
}

