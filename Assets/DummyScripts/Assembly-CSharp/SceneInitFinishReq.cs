﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneInitFinishReq : MessageBase, IMessage<SceneInitFinishReq> // TypeDefIndex: 24904
{
	// Fields
	private static readonly MessageParser<SceneInitFinishReq> _parser; // 0x00
	public const int EnterSceneTokenFieldNumber = 1; // Metadata: 0x00B07847
	private uint enterSceneToken_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneInitFinishReq> Parser { get => default; } // 0x0000000185707DD0-0x0000000185707E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185707AC0-0x0000000185707B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001857077D0-0x0000000185707850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001857072E0-0x0000000185707340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001857081C0-0x00000001857082B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185708030-0x0000000185708090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185707BF0-0x0000000185707CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185708170-0x00000001857081C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001857078F0-0x00000001857079E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterSceneToken { get => default; set {} } // 0x0000000185707B50-0x0000000185707BF0 0x0000000185707F90-0x0000000185708030

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24905
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24906
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 204
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneInitFinishReq() {} // 0x00000001857084E0-0x0000000185708540
	static SceneInitFinishReq() {} // 0x0000000185708420-0x00000001857084E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneInitFinishReq Clone() => default; // 0x0000000185707CE0-0x0000000185707DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneInitFinishReq ShallowCopy() => default; // 0x0000000185707850-0x00000001857078F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185707450-0x00000001857074A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185707EF0-0x0000000185707F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185707F40-0x0000000185707F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001857074A0-0x0000000185707510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185707510-0x00000001857075E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneInitFinishReq other) => default; // 0x00000001857075E0-0x00000001857076E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001857079E0-0x0000000185707AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001857082B0-0x0000000185708420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185708090-0x0000000185708170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001857076E0-0x00000001857077D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneInitFinishReq other) {} // 0x0000000185707340-0x0000000185707450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185707200-0x00000001857072E0
}

