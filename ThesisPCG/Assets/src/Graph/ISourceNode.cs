﻿using System.Collections;
using UniRx;
using System.Reflection;
using System;
using UnityEditor;
using System.Threading.Tasks;

using Graph.Parameters;
using System.Diagnostics;
using System.Collections.Generic;

namespace Graph
{
	public interface ISourceNode<Tout> : INode where Tout : Parameter
	{
		//return source as observable based on its output parameter
		//maybe use generic observable to hide casting inside sourcenode,
		IObservable<Tout> AsObservable ();

		IObservable<Tout> AsObservable (int size);

		int GetSize ();

		Tout GetOutputParameter ();


	}

}