﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.Library
//       File: RigidbodyExtension.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:48 AM
#endregion


using UnityEngine;

namespace ForestOfChaosLibrary.Extensions {
    public static class RigidbodyExtension {
        public static void ResetVelocity(this Rigidbody rB) {
            rB.velocity        = Vector3.zero;
            rB.angularVelocity = Vector3.zero;
        }
    }
}