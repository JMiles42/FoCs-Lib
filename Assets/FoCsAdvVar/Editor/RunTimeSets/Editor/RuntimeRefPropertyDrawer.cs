﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.AdvVar.Editor
//       File: RuntimeRefPropertyDrawer.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/09/12 | 12:04 AM
#endregion


using ForestOfChaos.Unity.AdvVar.RuntimeRef;
using ForestOfChaosLibrary.Editor.PropertyDrawers;
using UnityEditor;

//TODO: This file
namespace ForestOfChaos.Unity.AdvVar.Editor.RuntimeRef {
    [CustomPropertyDrawer(typeof(RunTimeRef), true)]
    public class RuntimeRefPropertyDrawer: ObjectReferenceDrawer {
        protected override bool AllowFoldout => false;
    }
}