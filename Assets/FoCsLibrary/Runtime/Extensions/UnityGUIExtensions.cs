﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.Library
//       File: UnityGUIExtensions.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:48 AM
#endregion


using UnityEngine;

namespace ForestOfChaosLibrary.Extensions {
    public static class UnityGUIExtensions {
        public static void DrawChecked(this GUIStyle style, Rect pos, bool isHover = false, bool isActive = false, bool on = false, bool hasKeyboardFocus = false) {
            if (Event.current.type == EventType.Repaint)
                style.Draw(pos, isHover, isActive, on, hasKeyboardFocus);
        }
    }
}