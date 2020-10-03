﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.AdvVar
//       File: GameObjectReference.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/09/12 | 12:02 AM
#endregion


using System;
using ForestOfChaos.Unity.AdvVar.Base;
using UnityEngine;

namespace ForestOfChaos.Unity.AdvVar {
    [Serializable]
    [AdvFolderNameUnity]
    public class GameObjectReference: AdvReference<GameObject> { }

    [Serializable]
    public class GameObjectVariable: AdvVariable<GameObject> {
        public static implicit operator GameObjectVariable(GameObject input) {
            var fR = new GameObjectVariable {UseLocal = true, Value = input};

            return fR;
        }
    }
}