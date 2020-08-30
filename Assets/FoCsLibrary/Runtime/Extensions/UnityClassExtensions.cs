#region � Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.Library
//       File: UnityClassExtensions.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:48 AM
#endregion


using UnityEngine;

namespace ForestOfChaosLibrary.Extensions {
    public static class UnityClassExtensions {
        public static void SetParent(this GameObject gO, Transform parent) {
            gO.transform.SetParent(parent);
        }

        public static void SetParent(this GameObject gO, Component parent) {
            gO.transform.SetParent(parent.transform);
        }

        public static void SetParent(this GameObject gO, GameObject parent) {
            gO.transform.SetParent(parent.transform);
        }

        public static void SetParent(this Component mB, Transform parent) {
            mB.transform.SetParent(parent);
        }

        public static void SetParent(this Component mB, Component parent) {
            mB.transform.SetParent(parent.transform);
        }

        public static void SetParent(this Component mB, GameObject parent) {
            mB.transform.SetParent(parent.transform);
        }
    }
}