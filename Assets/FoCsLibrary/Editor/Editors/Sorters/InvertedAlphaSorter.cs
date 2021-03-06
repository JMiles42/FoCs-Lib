﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library.Editor
//       File: InvertedAlphaSorter.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:10 PM
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace ForestOfChaos.Unity.Editor {
    [InitializeOnLoad]
    internal class InvertedAlphaSorter: FoCsEditor.FoCsEditorSorter {
        public static          InvertedAlphaSorter Instance;
        public static readonly GUIContent          modeName = new GUIContent("Z-A");

        ///<inheritdoc />
        public override GUIContent ModeName => modeName;

        static InvertedAlphaSorter() {
            Instance = new InvertedAlphaSorter();
            FoCsEditor.AddSortingMode(Instance);
        }

        ///<inheritdoc />
        public override List<SerializedProperty> GetPropertyOrder(IEnumerable<SerializedProperty> properties) {
            var serializedProperties = properties.ToList();
            var list                 = serializedProperties.ToList();
            FoCsEditor.RemoveDefaultProperties(list);
            list.Sort((a, b) => string.Compare(a.name, b.name, StringComparison.Ordinal));
            list.Reverse();
            list.InsertRange(0, FoCsEditor.GetDefaultProperties(serializedProperties.First().serializedObject));

            return list;
        }
    }
}