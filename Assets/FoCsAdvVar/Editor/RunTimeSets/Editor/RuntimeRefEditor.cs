﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.AdvVar.Editor
//       File: RuntimeRefEditor.cs
//    Created: 2020/04/25 | 5:51 AM
// LastEdited: 2020/08/31 | 7:49 AM
#endregion


using ForestOfChaos.Unity.AdvVar.RuntimeRef;
using ForestOfChaosLibrary.Editor;
using UnityEditor;
using UnityEngine;

namespace ForestOfChaos.Unity.AdvVar.Editor.RuntimeRef {
    [CustomEditor(typeof(RunTimeRef), true)]
    public class RuntimeRefEditor: FoCsEditor<RunTimeRef> {
        public override void OnInspectorGUI() {
            using (Disposables.HorizontalScope(GUI.skin.box))
                EditorGUILayout.LabelField($"Has reference: {Target.HasReference}");
        }
    }
}