﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library.Editor
//       File: PropertyHandler.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:10 PM
#endregion

using UnityEditor;
using UnityEngine;

namespace ForestOfChaos.Unity.Editor {
    public class PropertyHandler: IPropertyLayoutHandler {
        public void HandleProperty(SerializedProperty property) {
            FoCsGUI.Layout.PropertyField(new GUIContent(property.displayName), property, property.isExpanded);
        }

        public float PropertyHeight(SerializedProperty property) => FoCsGUI.GetPropertyHeight(property);

        public bool IsValidProperty(SerializedProperty property) => true;

        public void DrawAfterEditor(SerializedProperty serializedProperty) { }
    }
}