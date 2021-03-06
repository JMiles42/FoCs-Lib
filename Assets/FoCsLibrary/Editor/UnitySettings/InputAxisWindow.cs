﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library.Editor
//       File: InputAxisWindow.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:11 PM
#endregion

using ForestOfChaos.Unity.Editor.UnitySettings;
using ForestOfChaos.Unity.Editor.Utilities;
using ForestOfChaos.Unity.Editor.Windows;
using UnityEditor;

namespace ForestOfChaos.Unity.Editor.InputManager {
    public class InputAxisWindow: FoCsWindow<InputAxisWindow> {
        private const string Title = "InputAxisWindow";

        [MenuItem(FileStrings.FORESTOFCHAOS_TOOLS_ + Title)]
        private static void Init() {
            GetWindowAndShow();
            Window.titleContent.text = Title;
        }

        protected override void OnGUI() {
            foreach (var axisName in ReadInputManager.GetAxisProperties())
                EditorGUILayout.PropertyField(axisName, true);
        }
    }
}