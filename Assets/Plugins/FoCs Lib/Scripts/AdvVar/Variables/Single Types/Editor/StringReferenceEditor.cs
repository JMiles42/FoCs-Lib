﻿using ForestOfChaosLib.AdvVar;
using ForestOfChaosLib.Editor;
using ForestOfChaosLib.Editor.Utilities;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(StringReference))]
[CanEditMultipleObjects]
public class StringReferenceEditor: FoCsEditor
{
	public override void OnInspectorGUI()
	{
		using(Disposables.Indent())
		{
			DrawCopyPasteButtonsHeader();
			using(var changeCheckScope = Disposables.ChangeCheck())
			{
				var cachedGuiColor = GUI.color;
				serializedObject.Update();

				foreach(var serializedProperty in serializedObject.Properties())
				{
					GUI.color = cachedGuiColor;
					if(serializedProperty.name == "_value")
					{
						DoTextBox(serializedProperty);
					}
					else
					{
						HandleProperty(serializedProperty);
					}
				}

				if(changeCheckScope.changed)
				{
					serializedObject.ApplyModifiedProperties();
				}
			}

			EditorGUILayout.GetControlRect(false, FoCsGUI.Utilities.Padding);
		}
	}

	private void DoTextBox(SerializedProperty serializedProperty)
	{
		EditorGUILayout.LabelField("Value");
		serializedProperty.stringValue = EditorGUILayout.TextArea(serializedProperty.stringValue,GUILayout.Height(EditorGUIUtility.singleLineHeight * 5));
	}
}
