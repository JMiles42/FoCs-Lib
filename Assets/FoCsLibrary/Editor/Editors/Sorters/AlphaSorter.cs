﻿#region © Forest Of Chaos Studios 2019 - 2020
//    Project: FoCs.Unity.Library.Editor
//       File: AlphaSorter.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/08/31 | 7:49 AM
#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace ForestOfChaosLibrary.Editor {
    internal class AlphaSorter: FoCsEditor.FoCsEditorSorter {
        public static          AlphaSorter Instance;
        public static readonly GUIContent  modeName = new GUIContent("A-Z");

        ///<inheritdoc />
        public override GUIContent ModeName => modeName;

        ///<inheritdoc />
        public override List<SerializedProperty> GetPropertyOrder(IEnumerable<SerializedProperty> properties) {
            var serializedProperties = properties.ToList();
            var list                 = serializedProperties.ToList();
            FoCsEditor.RemoveDefaultProperties(list);
            list.Sort((a, b) => string.Compare(a.name, b.name, StringComparison.Ordinal));
            list.InsertRange(0, FoCsEditor.GetDefaultProperties(serializedProperties.First().serializedObject));

            return list.ToList();
        }
    }
}