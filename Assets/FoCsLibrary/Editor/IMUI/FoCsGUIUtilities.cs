﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.Library.Editor
//       File: FoCsGUIUtilities.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:49 AM
#endregion


using UnityEditor;

namespace ForestOfChaosLibrary.Editor {
    // ReSharper disable once MismatchedFileName
    public static partial class FoCsGUI {
        public static float SingleLine => EditorGUIUtility.singleLineHeight;

        public static float Padding => EditorGUIUtility.standardVerticalSpacing;

        public static float SingleLinePlusPadding => SingleLine + EditorGUIUtility.standardVerticalSpacing;

        public static float IndentSize => EditorGUIUtility.singleLineHeight;
    }
}