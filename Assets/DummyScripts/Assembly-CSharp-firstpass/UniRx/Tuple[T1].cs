﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace UniRx
{
	[Serializable]
	public struct Tuple<T1> : IStructuralEquatable, IStructuralComparable, IComparable, ITuple // TypeDefIndex: 10646
	{
		// Fields
		private T1 item1;
	
		// Properties
		public T1 Item1 { get => default; }
	
		// Constructors
		public Tuple(T1 item1) : this() {
			this.item1 = default;
		}
	
		// Methods
		int IComparable.CompareTo(object obj) => default;
		int IStructuralComparable.CompareTo(object other, IComparer comparer) => default;
		public override bool Equals(object obj) => default;
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer) => default;
		public override int GetHashCode() => default;
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => default;
		string ITuple.ToString() => default;
		public override string ToString() => default;
	}
}
