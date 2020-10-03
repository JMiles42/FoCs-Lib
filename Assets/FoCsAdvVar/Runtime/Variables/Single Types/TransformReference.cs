﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.AdvVar
//       File: TransformReference.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/09/12 | 12:02 AM
#endregion


using System;
using ForestOfChaos.Unity.AdvVar.Base;
using UnityEngine;

namespace ForestOfChaos.Unity.AdvVar {
    [Serializable]
    [AdvFolderNameUnity]
    public class TransformReference: AdvReference<Transform> { }

    [Serializable]
    public class TransformVariable: AdvVariable<Transform> {
        public static implicit operator TransformVariable(Transform input) {
            var fR = new TransformVariable {UseLocal = true, Value = input};

            return fR;
        }
    }
}