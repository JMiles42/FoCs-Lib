#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library.Editor
//       File: FoCsGUI.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:10 PM
#endregion

using System;
using ForestOfChaos.Unity.Editor.PropertyDrawers;
using ForestOfChaos.Unity.Extensions;
using ForestOfChaos.Unity.Utilities;
using UnityEditor;
using UnityEngine;
using GUICon = UnityEngine.GUIContent;
using eInt = ForestOfChaos.Unity.Editor.FoCsGUI.GUIEvent<int>;
using eBool = ForestOfChaos.Unity.Editor.FoCsGUI.GUIEventBool;
using eFloat = ForestOfChaos.Unity.Editor.FoCsGUI.GUIEvent<float>;
using eDouble = ForestOfChaos.Unity.Editor.FoCsGUI.GUIEvent<double>;
using eString = ForestOfChaos.Unity.Editor.FoCsGUI.GUIEvent<string>;
using SerProp = UnityEditor.SerializedProperty;
using eProp = ForestOfChaos.Unity.Editor.FoCsGUI.GUIEvent<UnityEditor.SerializedProperty>;
using eObject = ForestOfChaos.Unity.Editor.FoCsGUI.GUIEvent<UnityEngine.Object>;
using Object = UnityEngine.Object;

namespace ForestOfChaos.Unity.Editor {
    public static partial class FoCsGUI {

#region Label
        public static GUIEvent Label(Rect rect) => LabelMaster(rect, GUICon.none, LabelStyle);

        public static GUIEvent Label(Rect rect, GUIStyle style) => LabelMaster(rect, GUICon.none, style);

        public static GUIEvent Label(Rect rect, string label) => LabelMaster(rect, new GUICon(label), LabelStyle);

        public static GUIEvent Label(Rect rect, string label, GUIStyle style) => LabelMaster(rect, new GUICon(label), style);

        public static GUIEvent Label(Rect rect, object label) => LabelMaster(rect, new GUICon(label.ToString()), LabelStyle);

        public static GUIEvent Label(Rect rect, object label, GUIStyle style) => LabelMaster(rect, new GUICon(label.ToString()), style);

        public static GUIEvent Label(Rect rect, GUICon guiCon) => LabelMaster(rect, guiCon, LabelStyle);

        public static GUIEvent Label(Rect rect, GUICon guiCon, GUIStyle style) => LabelMaster(rect, guiCon, style);

        public static GUIEvent Label(Rect rect, Texture texture) => LabelMaster(rect, new GUICon(texture), LabelStyle);

        public static GUIEvent Label(Rect rect, Texture texture, GUIStyle style) => LabelMaster(rect, new GUICon(texture), style);

        private static GUIEvent LabelMaster(Rect rect, GUICon guiCon, GUIStyle style) {
            var data = new GUIEvent {Event = new Event(Event.current), Rect = rect};
            EditorGUI.LabelField(rect, guiCon, style);

            return data;
        }
#endregion

#region Button
        public static eBool Button(Rect rect) => ButtonMaster(rect, GUICon.none, ButtonStyle);

        public static eBool Button(Rect rect, GUIStyle style) => ButtonMaster(rect, GUICon.none, style);

        public static eBool Button(Rect rect, string label) => ButtonMaster(rect, new GUICon(label), ButtonStyle);

        public static eBool Button(Rect rect, string label, GUIStyle style) => ButtonMaster(rect, new GUICon(label), style);

        public static eBool Button(Rect rect, GUICon guiCon) => ButtonMaster(rect, guiCon, ButtonStyle);

        public static eBool Button(Rect rect, GUICon guiCon, GUIStyle style) => ButtonMaster(rect, guiCon, style);

        public static eBool Button(Rect rect, Texture texture) => ButtonMaster(rect, new GUICon(texture), ButtonStyle);

        public static eBool Button(Rect rect, Texture texture, GUIStyle style) => ButtonMaster(rect, new GUICon(texture), style);

        private static eBool ButtonMaster(Rect rect, GUICon guiCon, GUIStyle style) =>
                new eBool {Event = new Event(Event.current), Rect = rect, Value = GUI.Button(rect, guiCon, style)};
#endregion

#region Toggle
        public static eBool Toggle(Rect rect, bool toggle) => ToggleMaster(rect, toggle, GUICon.none, ToggleStyle);

        public static eBool Toggle(Rect rect, bool toggle, GUIStyle style) => ToggleMaster(rect, toggle, GUICon.none, style);

        public static eBool Toggle(Rect rect, bool toggle, string label) => ToggleMaster(rect, toggle, new GUICon(label), ToggleStyle);

        public static eBool Toggle(Rect rect, bool toggle, string label, GUIStyle style) => ToggleMaster(rect, toggle, new GUICon(label), style);

        public static eBool Toggle(Rect rect, bool toggle, GUICon guiCon) => ToggleMaster(rect, toggle, guiCon, ToggleStyle);

        public static eBool Toggle(Rect rect, bool toggle, GUICon guiCon, GUIStyle style) => ToggleMaster(rect, toggle, guiCon, style);

        public static eBool Toggle(Rect rect, bool toggle, Texture texture) => ToggleMaster(rect, toggle, new GUICon(texture), ToggleStyle);

        public static eBool Toggle(Rect rect, bool toggle, Texture texture, GUIStyle style) => ToggleMaster(rect, toggle, new GUICon(texture), style);

        public static eBool ToggleMaster(Rect rect, bool toggle, GUICon guiCon, GUIStyle style) =>
                new eBool {Event = new Event(Event.current), Rect = rect, Value = GUI.Toggle(rect, toggle, guiCon, style)};
#endregion

#region Toggle
        public static eBool ToggleLeft(Rect rect, bool toggle) => ToggleLeftMaster(rect, toggle, GUICon.none, ToggleStyle);

        public static eBool ToggleLeft(Rect rect, bool toggle, GUIStyle style) => ToggleLeftMaster(rect, toggle, GUICon.none, style);

        public static eBool ToggleLeft(Rect rect, bool toggle, string label) => ToggleLeftMaster(rect, toggle, new GUICon(label), ToggleStyle);

        public static eBool ToggleLeft(Rect rect, bool toggle, string label, GUIStyle style) => ToggleLeftMaster(rect, toggle, new GUICon(label), style);

        public static eBool ToggleLeft(Rect rect, bool toggle, GUICon guiCon) => ToggleLeftMaster(rect, toggle, guiCon, ToggleStyle);

        public static eBool ToggleLeft(Rect rect, bool toggle, GUICon guiCon, GUIStyle style) => ToggleLeftMaster(rect, toggle, guiCon, style);

        public static eBool ToggleLeft(Rect rect, bool toggle, Texture texture) => ToggleLeftMaster(rect, toggle, new GUICon(texture), ToggleStyle);

        public static eBool ToggleLeft(Rect rect, bool toggle, Texture texture, GUIStyle style) => ToggleLeftMaster(rect, toggle, new GUICon(texture), style);

        public static eBool ToggleLeftMaster(Rect rect, bool toggle, GUICon guiCon, GUIStyle style) =>
                new eBool {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.ToggleLeft(rect, guiCon, toggle, style)};
#endregion

#region Foldout
        public static eBool Foldout(Rect rect, bool foldout) => FoldoutMaster(rect, foldout, GUICon.none, FoldoutStyle);

        public static eBool Foldout(Rect rect, bool foldout, GUIStyle style) => FoldoutMaster(rect, foldout, GUICon.none, style);

        public static eBool Foldout(Rect rect, bool foldout, string label) => FoldoutMaster(rect, foldout, new GUICon(label), FoldoutStyle);

        public static eBool Foldout(Rect rect, bool foldout, string label, GUIStyle style) => FoldoutMaster(rect, foldout, new GUICon(label), style);

        public static eBool Foldout(Rect rect, bool foldout, GUICon guiCon) => FoldoutMaster(rect, foldout, guiCon, FoldoutStyle);

        public static eBool Foldout(Rect rect, bool foldout, GUICon guiCon, GUIStyle style) => FoldoutMaster(rect, foldout, guiCon, style);

        public static eBool Foldout(Rect rect, bool foldout, Texture texture) => FoldoutMaster(rect, foldout, new GUICon(texture), FoldoutStyle);

        public static eBool Foldout(Rect rect, bool foldout, Texture texture, GUIStyle style) => FoldoutMaster(rect, foldout, new GUICon(texture), style);

        public static eBool FoldoutMaster(Rect rect, bool foldout, GUICon guiCon, GUIStyle style) => GUIEvent.Create(EditorGUI.Foldout(rect, foldout, guiCon, style));
#endregion

#region IntField
        public static eInt IntField(Rect rect, int value) => IntFieldMaster(rect, GUICon.none, value, NumberFieldStyle);

        public static eInt IntField(Rect rect, string label, int value) => IntFieldMaster(rect, new GUICon(label), value, NumberFieldStyle);

        public static eInt IntField(Rect rect, string label, int value, GUIStyle style) => IntFieldMaster(rect, new GUICon(label), value, style);

        public static eInt IntField(Rect rect, GUICon guiCon, int value) => IntFieldMaster(rect, guiCon, value, NumberFieldStyle);

        public static eInt IntField(Rect rect, GUICon guiCon, int value, GUIStyle style) => IntFieldMaster(rect, guiCon, value, style);

        private static eInt IntFieldMaster(Rect rect, GUICon guiCon, int value, GUIStyle style) =>
                new eInt {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.IntField(rect, guiCon, value, style)};
#endregion

#region DelayedIntField
        public static eInt DelayedIntField(Rect rect, int value) => DelayedIntFieldMaster(rect, GUICon.none, value, NumberFieldStyle);

        public static eInt DelayedIntField(Rect rect, string label, int value) => DelayedIntFieldMaster(rect, new GUICon(label), value, NumberFieldStyle);

        public static eInt DelayedIntField(Rect rect, string label, int value, GUIStyle style) => DelayedIntFieldMaster(rect, new GUICon(label), value, style);

        public static eInt DelayedIntField(Rect rect, GUICon guiCon, int value) => DelayedIntFieldMaster(rect, guiCon, value, NumberFieldStyle);

        public static eInt DelayedIntField(Rect rect, GUICon guiCon, int value, GUIStyle style) => DelayedIntFieldMaster(rect, guiCon, value, style);

        private static eInt DelayedIntFieldMaster(Rect rect, GUICon guiCon, int value, GUIStyle style) =>
                new eInt {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.DelayedIntField(rect, guiCon, value, style)};
#endregion

#region FloatField
        public static eFloat FloatField(Rect rect, float value) => FloatFieldMaster(rect, GUICon.none, value, NumberFieldStyle);

        public static eFloat FloatField(Rect rect, float value, GUIStyle style) => FloatFieldMaster(rect, GUICon.none, value, style);

        public static eFloat FloatField(Rect rect, string label, float value) => FloatFieldMaster(rect, new GUICon(label), value, NumberFieldStyle);

        public static eFloat FloatField(Rect rect, string label, float value, GUIStyle style) => FloatFieldMaster(rect, new GUICon(label), value, style);

        public static eFloat FloatField(Rect rect, GUICon guiCon, float value) => FloatFieldMaster(rect, guiCon, value, NumberFieldStyle);

        public static eFloat FloatField(Rect rect, GUICon guiCon, float value, GUIStyle style) => FloatFieldMaster(rect, guiCon, value, style);

        private static eFloat FloatFieldMaster(Rect rect, GUICon guiCon, float value, GUIStyle style) =>
                new eFloat {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.FloatField(rect, guiCon, value, style)};
#endregion

#region DelayedFloatField
        public static eFloat DelayedFloatField(Rect rect, float value) => DelayedFloatFieldMaster(rect, GUICon.none, value, NumberFieldStyle);

        public static eFloat DelayedFloatField(Rect rect, float value, GUIStyle style) => DelayedFloatFieldMaster(rect, GUICon.none, value, style);

        public static eFloat DelayedFloatField(Rect rect, string label, float value) => DelayedFloatFieldMaster(rect, new GUICon(label), value, NumberFieldStyle);

        public static eFloat DelayedFloatField(Rect rect, string label, float value, GUIStyle style) => DelayedFloatFieldMaster(rect, new GUICon(label), value, style);

        public static eFloat DelayedFloatField(Rect rect, GUICon guiCon, float value) => DelayedFloatFieldMaster(rect, guiCon, value, NumberFieldStyle);

        public static eFloat DelayedFloatField(Rect rect, GUICon guiCon, float value, GUIStyle style) => DelayedFloatFieldMaster(rect, guiCon, value, style);

        private static eFloat DelayedFloatFieldMaster(Rect rect, GUICon guiCon, float value, GUIStyle style) =>
                new eFloat {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.DelayedFloatField(rect, guiCon, value, style)};
#endregion

#region DoubleField
        public static eDouble DoubleField(Rect rect, double value) => DoubleFieldMaster(rect, GUICon.none, value, NumberFieldStyle);

        public static eDouble DoubleField(Rect rect, double value, GUIStyle style) => DoubleFieldMaster(rect, GUICon.none, value, style);

        public static eDouble DoubleField(Rect rect, string label, double value) => DoubleFieldMaster(rect, new GUICon(label), value, NumberFieldStyle);

        public static eDouble DoubleField(Rect rect, string label, double value, GUIStyle style) => DoubleFieldMaster(rect, new GUICon(label), value, style);

        public static eDouble DoubleField(Rect rect, GUICon guiCon, double value) => DoubleFieldMaster(rect, guiCon, value, NumberFieldStyle);

        public static eDouble DoubleField(Rect rect, GUICon guiCon, double value, GUIStyle style) => DoubleFieldMaster(rect, guiCon, value, style);

        private static eDouble DoubleFieldMaster(Rect rect, GUICon guiCon, double value, GUIStyle style) =>
                new eDouble {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.DoubleField(rect, guiCon, value, style)};
#endregion

#region DelayedDoubleField
        public static eDouble DelayedDoubleField(Rect rect, double value) => DelayedDoubleFieldMaster(rect, GUICon.none, value, NumberFieldStyle);

        public static eDouble DelayedDoubleField(Rect rect, double value, GUIStyle style) => DelayedDoubleFieldMaster(rect, GUICon.none, value, style);

        public static eDouble DelayedDoubleField(Rect rect, string label, double value) => DelayedDoubleFieldMaster(rect, new GUICon(label), value, NumberFieldStyle);

        public static eDouble DelayedDoubleField(Rect rect, string label, double value, GUIStyle style) => DelayedDoubleFieldMaster(rect, new GUICon(label), value, style);

        public static eDouble DelayedDoubleField(Rect rect, GUICon guiCon, double value) => DelayedDoubleFieldMaster(rect, guiCon, value, NumberFieldStyle);

        public static eDouble DelayedDoubleField(Rect rect, GUICon guiCon, double value, GUIStyle style) => DelayedDoubleFieldMaster(rect, guiCon, value, style);

        private static eDouble DelayedDoubleFieldMaster(Rect rect, GUICon guiCon, double value, GUIStyle style) =>
                new eDouble {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.DelayedDoubleField(rect, guiCon, value, style)};
#endregion

#region TextField
        public static eString TextField(Rect rect, string value) => TextFieldMaster(rect, GUICon.none, value, TextFieldStyle);

        public static eString TextField(Rect rect, string value, GUIStyle style) => TextFieldMaster(rect, GUICon.none, value, style);

        public static eString TextField(Rect rect, string label, string value) => TextFieldMaster(rect, new GUICon(label), value, TextFieldStyle);

        public static eString TextField(Rect rect, string label, string value, GUIStyle style) => TextFieldMaster(rect, new GUICon(label), value, style);

        public static eString TextField(Rect rect, GUICon guiCon, string value) => TextFieldMaster(rect, guiCon, value, TextFieldStyle);

        public static eString TextField(Rect rect, GUICon guiCon, string value, GUIStyle style) => TextFieldMaster(rect, guiCon, value, style);

        private static eString TextFieldMaster(Rect rect, GUICon guiCon, string value, GUIStyle style) =>
                new eString {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.TextField(rect, guiCon, value, style)};
#endregion

#region DelayedTextField
        public static eString DelayedTextField(Rect rect, string value) => DelayedTextFieldMaster(rect, GUICon.none, value, TextFieldStyle);

        public static eString DelayedTextField(Rect rect, string value, GUIStyle style) => DelayedTextFieldMaster(rect, GUICon.none, value, style);

        public static eString DelayedTextField(Rect rect, string label, string value) => DelayedTextFieldMaster(rect, new GUICon(label), value, TextFieldStyle);

        public static eString DelayedTextField(Rect rect, string label, string value, GUIStyle style) => DelayedTextFieldMaster(rect, new GUICon(label), value, style);

        public static eString DelayedTextField(Rect rect, GUICon guiCon, string value) => DelayedTextFieldMaster(rect, guiCon, value, TextFieldStyle);

        public static eString DelayedTextField(Rect rect, GUICon guiCon, string value, GUIStyle style) => DelayedTextFieldMaster(rect, guiCon, value, style);

        private static eString DelayedTextFieldMaster(Rect rect, GUICon guiCon, string value, GUIStyle style) =>
                new eString {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.DelayedTextField(rect, guiCon, value, style)};
#endregion

#region TextArea
        public static eString TextArea(Rect rect, string value) => TextAreaMaster(rect, value, TextAreaStyle);

        public static eString TextArea(Rect rect, string value, GUIStyle style) => TextAreaMaster(rect, value, style);

        private static eString TextAreaMaster(Rect rect, string value, GUIStyle style) =>
                new eString {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.TextArea(rect, value, style)};
#endregion

#region RawObjectField
        public static eObject RawObjectField(Rect rect, Object value, Type type, bool allowSceneObjects) => RawObjectFieldMaster(rect, GUICon.none, value, type, allowSceneObjects);

        public static eObject RawObjectField(Rect rect, string label, Object value, Type type, bool allowSceneObjects) =>
                RawObjectFieldMaster(rect, new GUICon(label), value, type, allowSceneObjects);

        public static eObject RawObjectField(Rect rect, GUICon guiCon, Object value, Type type, bool allowSceneObjects) =>
                RawObjectFieldMaster(rect, guiCon, value, type, allowSceneObjects);

        private static eObject RawObjectFieldMaster(Rect rect, GUICon guiCon, Object value, Type type, bool allowSceneObjects) =>
                new eObject {Event = new Event(Event.current), Rect = rect, Value = EditorGUI.ObjectField(rect, guiCon, value, type, allowSceneObjects)};
#endregion

#region ObjectFieldGeneric
        public static GUIEvent<T> ObjectField<T>(Rect rect, T value, Type type, bool allowSceneObjects) where T: Object =>
                ObjectFieldMaster(rect, GUICon.none, value, type, allowSceneObjects);

        public static GUIEvent<T> ObjectField<T>(Rect rect, string label, T value, Type type, bool allowSceneObjects) where T: Object =>
                ObjectFieldMaster(rect, new GUICon(label), value, type, allowSceneObjects);

        public static GUIEvent<T> ObjectField<T>(Rect rect, GUICon guiCon, T value, Type type, bool allowSceneObjects) where T: Object =>
                ObjectFieldMaster(rect, guiCon, value, type, allowSceneObjects);

        private static GUIEvent<T> ObjectFieldMaster<T>(Rect rect, GUICon guiCon, T value, Type type, bool allowSceneObjects) where T: Object =>
                new GUIEvent<T> {Event = new Event(Event.current), Rect = rect, Value = (T)EditorGUI.ObjectField(rect, guiCon, value, type, allowSceneObjects)};
#endregion

#region HelpBox
        public static GUIEvent ErrorBox(Rect rect, string text) => HelpBoxMaster(rect, text, MessageType.Error);

        public static GUIEvent InfoBox(Rect rect, string text) => HelpBoxMaster(rect, text, MessageType.Info);

        public static GUIEvent WarningBox(Rect rect, string text) => HelpBoxMaster(rect, text, MessageType.Warning);

        public static GUIEvent HelpBox(Rect rect, string text) => HelpBoxMaster(rect, text, MessageType.None);

        private static GUIEvent HelpBoxMaster(Rect rect, string text, MessageType type) {
            var data = new GUIEvent {Event = new Event(Event.current), Rect = rect};
            EditorGUI.HelpBox(rect, text, type);

            return data;
        }
#endregion

#region PropertyField
        private static eProp PropFieldMaster(Rect pos, SerProp prop, GUICon cont, bool includeChildren, AttributeCheck ignoreCheck, bool autoLabelField = false) {
            if (!autoLabelField)
                return PropDraw(pos, prop, cont, includeChildren, ignoreCheck);

            using (Disposables.LabelFieldSetWidth(pos.width * 0.4f))
                return PropDraw(pos, prop, cont, includeChildren, ignoreCheck);
        }

        private static eProp PropDraw(Rect pos, SerProp prop, GUICon cont, bool includeChildren, AttributeCheck ignoreCheck) {
            var data = new eProp {Event = new Event(Event.current), Rect = pos, Value = prop};

            if (ignoreCheck == AttributeCheck.DontCheck)
                return DoPropSwitchDraw(pos, prop, cont, includeChildren, data);

            var attributes = prop.GetSerializedPropertyAttributes();

            if (attributes.Length == 0)
                return DoPropSwitchDraw(pos, prop, cont, includeChildren, data);

            EditorGUI.PropertyField(pos, prop, cont, includeChildren);

            return data;
        }

        private static eProp DoPropSwitchDraw(Rect pos, SerProp prop, GUICon cont, bool includeChildren, eProp data) {
            switch (prop.propertyType) {
                case SerializedPropertyType.Quaternion:
                case SerializedPropertyType.Vector4:
                    Vector4PropEditor.Draw(pos, prop, cont);

                    return data;
                case SerializedPropertyType.Vector3:
                    Vector3PropEditor.Draw(pos, prop, cont);

                    return data;
                case SerializedPropertyType.Vector2:
                    Vector2PropEditor.Draw(pos, prop, cont);

                    return data;
                default:
                    EditorGUI.PropertyField(pos, prop, cont, includeChildren);

                    return data;
            }
        }

        public enum AttributeCheck {
            DontCheck,
            DoCheck
        }

        public static eProp PropertyField(Rect pos, SerProp prop) => PropFieldMaster(pos, prop, new GUICon(prop.displayName), prop.isExpanded, AttributeCheck.DontCheck);

        public static eProp PropertyField(Rect pos, SerProp prop, bool autoLabelField) =>
                PropFieldMaster(pos, prop, new GUICon(prop.displayName), true, AttributeCheck.DontCheck, autoLabelField);

        public static eProp PropertyField(Rect pos, SerProp prop, bool includeChildren, bool autoLabelField) =>
                PropFieldMaster(pos, prop, new GUICon(prop.displayName), includeChildren, AttributeCheck.DontCheck, autoLabelField);

        public static eProp PropertyField(Rect pos, SerProp prop, AttributeCheck ignoreCheck, bool autoLabelField = false) =>
                PropFieldMaster(pos, prop, new GUICon(prop.displayName), true, ignoreCheck, autoLabelField);

        public static eProp PropertyField(Rect pos, SerProp prop, bool includeChildren, AttributeCheck ignoreCheck, bool autoLabelField = false) =>
                PropFieldMaster(pos, prop, new GUICon(prop.displayName), includeChildren, ignoreCheck, autoLabelField);

        public static eProp PropertyField(Rect pos, SerProp prop, GUICon cont, bool autoLabelField = false) =>
                PropFieldMaster(pos, prop, cont, true, AttributeCheck.DontCheck, autoLabelField);

        public static eProp PropertyField(Rect pos, SerProp prop, GUICon cont, bool includeChildren, bool autoLabelField) =>
                PropFieldMaster(pos, prop, cont, includeChildren, AttributeCheck.DontCheck, autoLabelField);

        public static eProp PropertyField(Rect pos, SerProp prop, GUICon cont, bool includeChildren, AttributeCheck ignoreAttributeCheck, bool autoLabelField = false) =>
                PropFieldMaster(pos, prop, cont, includeChildren, ignoreAttributeCheck, autoLabelField);

        public static eProp PropertyField(Rect pos, SerProp prop, GUICon cont, AttributeCheck ignoreCheck, bool autoLabelField = false) =>
                PropFieldMaster(pos, prop, cont, true, ignoreCheck, autoLabelField);

        private static float GetPropertyHeightMaster(SerProp prop, GUICon cont, bool includeChildren, AttributeCheck ignoreAttributeCheck) {
            if (ignoreAttributeCheck == AttributeCheck.DontCheck)
                return DoPropSwitchHeight(prop, cont, includeChildren);

            var attributes = prop.GetSerializedPropertyAttributes();

            if (attributes.Length == 0)
                return DoPropSwitchHeight(prop, cont, includeChildren);

            return EditorGUI.GetPropertyHeight(prop, cont, includeChildren);
        }

        private static float DoPropSwitchHeight(SerProp prop, GUICon cont, bool includeChildren) {
            switch (prop.propertyType) {
                case SerializedPropertyType.Quaternion: return FoCsPropertyDrawer.PropertyHeight(prop, cont);
                default:                                return EditorGUI.GetPropertyHeight(prop, cont, includeChildren);
            }
        }

        public static float GetPropertyHeight(SerProp prop) => GetPropertyHeightMaster(prop, new GUICon(prop.displayName), true, AttributeCheck.DoCheck);

        public static float GetPropertyHeight(SerProp prop, bool includeChildren) =>
                GetPropertyHeightMaster(prop, new GUICon(prop.displayName), includeChildren, AttributeCheck.DoCheck);

        public static float GetPropertyHeight(SerProp prop, GUICon cont, bool includeChildren) => GetPropertyHeightMaster(prop, cont, includeChildren, AttributeCheck.DoCheck);

        public static float GetPropertyHeight(SerProp prop, GUICon cont) => GetPropertyHeightMaster(prop, cont, true, AttributeCheck.DoCheck);

        public static float GetPropertyHeight(SerProp prop, AttributeCheck ignoreCheck) => GetPropertyHeightMaster(prop, new GUICon(prop.displayName), true, ignoreCheck);

        public static float GetPropertyHeight(SerProp prop, bool includeChildren, AttributeCheck ignoreCheck) =>
                GetPropertyHeightMaster(prop, new GUICon(prop.displayName), includeChildren, ignoreCheck);

        public static float GetPropertyHeight(SerProp prop, GUICon cont, bool includeChildren, AttributeCheck ignoreCheck) =>
                GetPropertyHeightMaster(prop, cont, includeChildren, ignoreCheck);

        public static float GetPropertyHeight(SerProp prop, GUICon cont, AttributeCheck ignoreCheck) => GetPropertyHeightMaster(prop, cont, true, ignoreCheck);
#endregion

#region Popup
        public static eInt Popup(Rect pos, int selected, GUICon[] Options) => GUIEvent.Create(pos, EditorGUI.Popup(pos, selected, Options));

        public static eInt Popup(Rect pos, int selected, GUICon[] Options, GUIStyle style) => GUIEvent.Create(pos, EditorGUI.Popup(pos, selected, Options, style));

        public static eInt Popup(Rect pos, string label, int selected, GUICon[] Options) => GUIEvent.Create(pos, EditorGUI.Popup(pos, selected, Options, label));

        public static eInt Popup(Rect pos, string label, int selected, string[] Options, GUIStyle style) =>
                GUIEvent.Create(pos, EditorGUI.Popup(pos, label, selected, Options, style));

        public static eInt Popup(Rect pos, GUICon label, int selected, GUICon[] Options) => GUIEvent.Create(pos, EditorGUI.Popup(pos, label, selected, Options));

        public static eInt Popup(Rect pos, GUICon label, int selected, GUICon[] Options, GUIStyle style) =>
                GUIEvent.Create(pos, EditorGUI.Popup(pos, label, selected, Options, style));
#endregion

#region EnumPopup
        public static GUIEvent<Enum> EnumPopup(Rect pos, Enum selected) => GUIEvent.Create(pos, EditorGUI.EnumPopup(pos, selected));

        public static GUIEvent<Enum> EnumPopup(Rect pos, Enum selected, GUIStyle style) => GUIEvent.Create(pos, EditorGUI.EnumPopup(pos, selected, style));

        public static GUIEvent<Enum> EnumPopup(Rect pos, string label, Enum selected) => GUIEvent.Create(pos, EditorGUI.EnumPopup(pos, label, selected));

        public static GUIEvent<Enum> EnumPopup(Rect pos, string label, Enum selected, GUIStyle style) => GUIEvent.Create(pos, EditorGUI.EnumPopup(pos, label, selected, style));

        public static GUIEvent<Enum> EnumPopup(Rect pos, GUICon label, Enum selected) => GUIEvent.Create(pos, EditorGUI.EnumPopup(pos, label, selected));

        public static GUIEvent<Enum> EnumPopup(Rect pos, GUICon label, Enum selected, GUIStyle style) => GUIEvent.Create(pos, EditorGUI.EnumPopup(pos, label, selected, style));
#endregion

#region ProgressBar
        public static GUIEvent ProgressBar(Rect rect, float fillAmount, string label = "") {
            var data = new GUIEvent {Event = new Event(Event.current), Rect = rect};
            EditorGUI.ProgressBar(rect, fillAmount, label);

            return data;
        }

        public static void ProgressBarSplit(Rect pos, float value, bool isPositiveLeft = true) {
            //TODO: add label
            var leftPos = pos;
            leftPos.width *= 0.5f;
            var rightPos = leftPos;
            rightPos.x    += leftPos.width;
            leftPos.x     += leftPos.width;
            leftPos.width *= -1;
            float leftValue  = 0;
            float rightValue = 0;

            if (isPositiveLeft) {
                if (value >= 0) {
                    leftValue  = value;
                    rightValue = 0;
                }
                else {
                    leftValue  = 0;
                    rightValue = -value;
                }
            }
            else {
                if (value <= 0) {
                    leftValue  = -value;
                    rightValue = 0;
                }
                else {
                    leftValue  = 0;
                    rightValue = value;
                }
            }

            EditorGUI.ProgressBar(leftPos,  +leftValue,  "");
            EditorGUI.ProgressBar(rightPos, +rightValue, "");
        }
#endregion

#region WithMenus
        private const float MENU_BUTTON_SIZE = 16f;

        public static eInt DrawPropertyWithMenu(Rect position, SerProp property, GUICon label, GUICon[] Options, int active, bool autoLabelField = false) =>
                DrawDisabledPropertyWithMenu(false, position, property, label, Options, active, autoLabelField);

        public static eInt DrawDisabledPropertyWithMenu(bool disabled, Rect position, SerProp property, GUICon label, GUICon[] Options, int active, bool autoLabelField = false) {
            Action<Rect> draw = rect => {
                using (Disposables.SetIndent(0))
                    PropertyField(rect.Edit(RectEdit.ChangeY(-1), RectEdit.SetHeight(SingleLine)), property, GUICon.none, property.hasVisibleChildren, autoLabelField);
            };

            return DrawActionWithMenu(disabled, position, draw, label, Options, active);
        }

        public static eInt DrawActionWithMenu(Rect position, Action<Rect> draw, GUICon label, GUICon[] Options, int active) =>
                DrawActionWithMenu(false, position, draw, label, Options, active);

        public static eInt DrawActionWithMenu(bool disabled, Rect position, Action<Rect> draw, GUICon label, GUICon[] Options, int active) {
            var propRect  = new Rect(position);
            var labelRect = new Rect(position);
            var menuRect  = new Rect(position);
            labelRect     = labelRect.Edit(RectEdit.SubtractY(1), RectEdit.SetWidth(EditorGUIUtility.labelWidth));
            menuRect.xMin = menuRect.xMax - MENU_BUTTON_SIZE;
            menuRect.xMax = position.xMax;
            propRect.xMin = labelRect.xMax;
            propRect.xMax = menuRect.xMin - 2;
            Label(labelRect, label);

            using (Disposables.DisabledScope(disabled))
                draw.Trigger(propRect);

            using (Disposables.SetIndent(0)) {
                var index = EditorGUI.Popup(menuRect, GUICon.none, active, Options, Styles.InLineOptionsMenu);

                return GUIEvent.Create(position, index);
            }
        }
#endregion
    }
}