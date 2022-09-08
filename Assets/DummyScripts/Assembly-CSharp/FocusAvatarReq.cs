﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FocusAvatarReq : MessageBase, IMessage<FocusAvatarReq> // TypeDefIndex: 22496
{
	// Fields
	private static readonly MessageParser<FocusAvatarReq> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B01B6B
	private ulong avatarGuid_; // 0x18
	public const int IsFocusFieldNumber = 2; // Metadata: 0x00B01B6F
	private bool isFocus_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FocusAvatarReq> Parser { get => default; } // 0x0000000184FBAF50-0x0000000184FBAFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184FBAC40-0x0000000184FBACD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184FBA920-0x0000000184FBA9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184FBA2A0-0x0000000184FBA300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184FBB2E0-0x0000000184FBB3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184FBB110-0x0000000184FBB170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184FBAD70-0x0000000184FBAE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184FBB290-0x0000000184FBB2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184FBAA40-0x0000000184FBAB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000184FBACD0-0x0000000184FBAD70 0x0000000184FBA430-0x0000000184FBA4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFocus { get => default; set {} } // 0x0000000184FBA880-0x0000000184FBA920 0x0000000184FBB3D0-0x0000000184FBB470

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22497
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22498
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1740
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FocusAvatarReq() {} // 0x0000000184FBB730-0x0000000184FBB790
	static FocusAvatarReq() {} // 0x0000000184FBB670-0x0000000184FBB730

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FocusAvatarReq Clone() => default; // 0x0000000184FBAE60-0x0000000184FBAF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FocusAvatarReq ShallowCopy() => default; // 0x0000000184FBA9A0-0x0000000184FBAA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184FBA4D0-0x0000000184FBA520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FBB070-0x0000000184FBB0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FBB0C0-0x0000000184FBB110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184FBA520-0x0000000184FBA590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184FBA6B0-0x0000000184FBA780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FocusAvatarReq other) => default; // 0x0000000184FBA590-0x0000000184FBA6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184FBAB30-0x0000000184FBAC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184FBB470-0x0000000184FBB670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184FBB170-0x0000000184FBB290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184FBA780-0x0000000184FBA880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FocusAvatarReq other) {} // 0x0000000184FBA300-0x0000000184FBA430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184FBA1A0-0x0000000184FBA2A0
}

