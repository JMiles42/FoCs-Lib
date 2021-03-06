﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.AdvVar
//       File: Vector4ListReference.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:08 PM
#endregion

using System;
using ForestOfChaos.Unity.AdvVar.Base;
using UnityEngine;

namespace ForestOfChaos.Unity.AdvVar {
    [Serializable]
    [AdvFolderNameUnityLists]
    [CreateAssetMenu(fileName = "New " + nameof(Vector4ListReference), menuName = "ADV Variables/" + nameof(AdvListReference) + "/" + nameof(Vector4ListReference), order = 0)]
    public class Vector4ListReference: AdvListReference<Vector4> { }

    [Serializable]
    public class Vector4ListVariable: AdvListVariable<Vector4> { }
}