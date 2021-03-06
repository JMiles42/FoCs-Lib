﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.AdvVar
//       File: Vector4Reference.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:09 PM
#endregion

using System;
using ForestOfChaos.Unity.AdvVar.Base;
using UnityEngine;

namespace ForestOfChaos.Unity.AdvVar {
    [Serializable]
    [AdvFolderNameUnity]
    [CreateAssetMenu(fileName = "New " + nameof(Vector4Reference), menuName = "ADV Variables/" + nameof(AdvReference) + "/" + nameof(Vector4Reference), order = 0)]
    public class Vector4Reference: AdvReference<Vector4> { }

    [Serializable]
    public class Vector4Variable: AdvVariable<Vector4> {
        public static implicit operator Vector4Variable(Vector4 input) {
            var fR = new Vector4Variable {UseLocal = true, Value = input};

            return fR;
        }
    }
}