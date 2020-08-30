﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.AdvVar
//       File: Vector3ListReference.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:47 AM
#endregion


using System;
using ForestOfChaos.Unity.AdvVar.Base;
using UnityEngine;

namespace ForestOfChaos.Unity.AdvVar {
    [Serializable]
    [AdvFolderNameUnityLists]
    public class Vector3ListReference: AdvListReference<Vector3> { }

    [Serializable]
    public class Vector3ListVariable: AdvListVariable<Vector3, Vector3ListReference> { }
}