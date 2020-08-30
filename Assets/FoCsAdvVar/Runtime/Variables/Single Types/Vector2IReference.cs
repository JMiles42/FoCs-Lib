﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.AdvVar
//       File: Vector2IReference.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:47 AM
#endregion


using System;
using ForestOfChaos.Unity.AdvVar.Base;
using ForestOfChaosLibrary.Types;

namespace ForestOfChaos.Unity.AdvVar {
    [Serializable]
    [AdvFolderNameForestOfChaos]
    public class Vector2IReference: AdvReference<Vector2I> { }

    [Serializable]
    public class Vector2IVariable: AdvVariable<Vector2I, Vector2IReference> {
        public static implicit operator Vector2IVariable(Vector2I input) {
            var fR = new Vector2IVariable {UseLocal = true, Value = input};

            return fR;
        }
    }
}