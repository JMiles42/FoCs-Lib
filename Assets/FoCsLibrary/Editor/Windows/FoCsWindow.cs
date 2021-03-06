﻿#region © Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Library.Editor
//       File: FoCsWindow.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:11 PM
#endregion

using UnityEditor;
using UnityEngine;

namespace ForestOfChaos.Unity.Editor.Windows {
    /// <inheritdoc />
    /// <summary>
    ///     [MenuItem("Tools/Forest Of Chaos/Example Window")]
    ///     private static void Init(){
    ///     GetWindowAndOpenTab();
    ///     }
    /// </summary>
    /// <typeparam name="T">Class name of type that inherits directly from this class, for a static ref to its self</typeparam>
    public abstract class FoCsWindow<T>: FoCsWindow where T: FoCsWindow, IRepaintable {
        private static T window;

        protected static T Window => window? window : window = GetWindow();

        protected static T GetWindow() {
            if (window != null)
                return window;

            window = FindObjectOfType<T>() ?? CreateInstance<T>();

            return window;
        }

        protected static T GetWindowAndShow() {
            GetWindow();
            window.Show();
            window.Focus();

            return window;
        }

        protected static T GetWindowAndOpenUtility() {
            GetWindow();
            window.ShowUtility();
            window.Focus();

            return window;
        }
    }

    public abstract class FoCsWindow: EditorWindow, IRepaintable {
        protected abstract void OnGUI();

        public static void DrawSpace() {
            EditorGUILayout.Space();
        }

        public static void DrawSpace(int count) {
            for (var i = 0; i < count; i++)
                EditorGUILayout.Space();
        }

        public static void DrawSpace(float size) {
            GUILayout.Space(size);
        }
    }
}