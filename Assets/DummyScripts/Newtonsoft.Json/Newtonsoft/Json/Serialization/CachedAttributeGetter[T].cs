﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal static class CachedAttributeGetter<T> // TypeDefIndex: 5410
		where T : Attribute
	{
		// Fields
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;
	
		// Constructors
		static CachedAttributeGetter() {}
	
		// Methods
		public static T GetAttribute(object type) => default;
	}
}
