﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library.Editor
//       File: IPropertyLayoutHandler.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:10 PM
#endregion

using UnityEditor;

namespace ForestOfChaos.Unity.Editor {
    public interface IPropertyLayoutHandler {
        void HandleProperty(SerializedProperty property);

        float PropertyHeight(SerializedProperty property);

        bool IsValidProperty(SerializedProperty property);

        void DrawAfterEditor(SerializedProperty serializedProperty);
    }
}