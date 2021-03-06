﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library
//       File: RigidbodyExtension.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:09 PM
#endregion

using UnityEngine;

namespace ForestOfChaos.Unity.Extensions {
    public static class RigidbodyExtension {
        public static void ResetVelocity(this Rigidbody rB) {
            rB.velocity        = Vector3.zero;
            rB.angularVelocity = Vector3.zero;
        }
    }
}