﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.AdvVar.Editor
//       File: AdvReferencePropertyDrawerBase.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:11 PM
#endregion

using System;
using ForestOfChaos.Unity.AdvVar.Base;
using ForestOfChaos.Unity.Editor;
using ForestOfChaos.Unity.Editor.PropertyDrawers;
using ForestOfChaos.Unity.Extensions;
using ForestOfChaos.Unity.Utilities;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;

namespace ForestOfChaos.Unity.AdvVar.Editor {
    [CustomPropertyDrawer(typeof(AdvVariable), true)]
    public class AdvReferencePropertyDrawerBase: ObjectReferenceDrawer {
        internal const           float        WIDTH                     = 16f;
        internal const           string       REFERENCE_STR             = "Reference";
        internal const           string       LOCAL_VALUE_STR           = "LocalValue";
        internal const           string       USE_LOCAL_STR             = "UseLocal";
        internal static readonly GUIContent   localConstantGUIContent   = new GUIContent("Use Local Value", "Use Local Value");
        internal static readonly GUIContent   globalReferenceGUIContent = new GUIContent("Use Reference",   "Use Reference");
        internal static readonly GUIContent[] OPTIONS_ARRAY             = {localConstantGUIContent, globalReferenceGUIContent};
        internal static readonly RectEdit[]   EDITS_ARRAY               = {RectEdit.SetHeight(SingleLine), RectEdit.ChangeY(1)};

        public AdvReferencePropertyDrawerBase() => IsExpanded = new AnimBool {speed = 0.7f};

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            Foldout = DoDraw(position, property, Foldout, ref label);
        }

        public static bool DoDraw(Rect position, SerializedProperty property, bool foldout, ref GUIContent label) {
            var useLocal        = property.GetUseLocal();
            var localValue      = property.GetLocal();
            var globalReference = property.GetReference();

            using (var propScope = Disposables.PropertyScope(position, label, property)) {
                label = propScope.content;

                useLocal.boolValue = FoCsGUI.DrawPropertyWithMenu(position.Edit(EDITS_ARRAY),
                                                                  useLocal.boolValue? localValue : globalReference,
                                                                  label,
                                                                  OPTIONS_ARRAY,
                                                                  useLocal.boolValue? 0 : 1)
                                            .Value ==
                                     0;
            }

            if (globalReference.objectReferenceValue)
                return DrawReferenceObjectsData(position, foldout, ref useLocal, ref globalReference);

            return foldout;
        }

        public static bool DoDraw(Rect position, SerializedProperty property, bool foldout, GUIContent label, Action<Rect> drawLocalValue) {
            var useLocal        = property.FindPropertyRelative(USE_LOCAL_STR);
            var localValue      = property.FindPropertyRelative(LOCAL_VALUE_STR);
            var globalReference = property.FindPropertyRelative(REFERENCE_STR);

            using (var propScope = Disposables.PropertyScope(position, label, property)) {
                label = propScope.content;
                var editedPosition = position.Edit(RectEdit.SetHeight(SingleLinePlusPadding), RectEdit.ChangeY(1));

                if (useLocal.boolValue) {
                    if (drawLocalValue == null) {
                        var val = FoCsGUI.DrawPropertyWithMenu(editedPosition, localValue, label, OPTIONS_ARRAY, useLocal.boolValue? 0 : 1);
                        useLocal.boolValue = val.Value == 0;
                    }
                    else {
                        var val = FoCsGUI.DrawActionWithMenu(editedPosition, drawLocalValue, label, OPTIONS_ARRAY, useLocal.boolValue? 0 : 1);
                        useLocal.boolValue = val.Value == 0;
                    }
                }
                else {
                    var val = FoCsGUI.DrawPropertyWithMenu(editedPosition, globalReference, label, OPTIONS_ARRAY, useLocal.boolValue? 0 : 1);
                    useLocal.boolValue = val.Value == 0;
                }
            }

            if (globalReference.objectReferenceValue)
                return DrawReferenceObjectsData(position, foldout, ref useLocal, ref globalReference);

            return foldout;
        }

        private static bool DrawReferenceObjectsData(Rect position, bool foldout, ref SerializedProperty useLocal, ref SerializedProperty globalReference) {
            var serializedObject = new SerializedObject(globalReference.objectReferenceValue);
            var iterator         = serializedObject.GetIterator();
            iterator.Next(true);

            if (useLocal.boolValue || (globalReference.objectReferenceValue == null))
                return foldout;

            foldout = EditorGUI.Foldout(position.Edit(RectEdit.AddY(1), RectEdit.SetHeight(SingleLine), RectEdit.SetWidth(SingleLine)), foldout, foldoutGUIContent);

            if (!foldout)
                return false;

            position.height += 1;
            DrawSurroundingBox(position);
            position.y += Padding;

            using (Disposables.Indent()) {
                using (var changeCheckScope = Disposables.ChangeCheck()) {
                    var next = iterator.NextVisible(true);

                    if (FoCsEditor.IsDefaultScriptProperty(iterator))
                        iterator.NextVisible(true);

                    if (next) {
                        var drawPos = position.Edit(RectEdit.AddY(SingleLine), RectEdit.SubtractHeight(SingleLinePlusPadding));

                        do {
                            if (!FoCsEditor.IsPropertyHidden(iterator))
                                drawPos = DrawSubProp(iterator, drawPos);
                        }
                        while (iterator.NextVisible(false));
                    }

                    if (changeCheckScope.changed)
                        serializedObject.ApplyModifiedProperties();
                }
            }

            return true;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            var @ref = property.GetReference();

            if (@ref.objectReferenceValue)
                SerializedObject = new SerializedObject(@ref.objectReferenceValue);

            return PropertyHeight(property, SerializedObject, IsExpanded.value);
        }

        /// <inheritdoc />
        protected override void CheckAnimBool(SerializedProperty property) { }
    }

    internal static class AdvPropDrawerExt {
        public static SerializedProperty GetUseLocal(this SerializedProperty property) => property.FindPropertyRelative(AdvReferencePropertyDrawerBase.USE_LOCAL_STR);

        public static SerializedProperty GetLocal(this SerializedProperty property) => property.FindPropertyRelative(AdvReferencePropertyDrawerBase.LOCAL_VALUE_STR);

        public static SerializedProperty GetReference(this SerializedProperty property) => property.FindPropertyRelative(AdvReferencePropertyDrawerBase.REFERENCE_STR);
    }
}