﻿using ForestOfChaosLib.Editor;
using ForestOfChaosLib.Editor.PropertyDrawers;
using ForestOfChaosLib.Extensions;
using UnityEditor;
using UnityEngine;

namespace ForestOfChaosLib.Animation
{
	[CustomPropertyDrawer(typeof(AnimatorKey))]
	public class AnimatorKeyDrawer: FoCsPropertyDrawer<AnimatorKey>
	{
		private const string KEY            = "Key";
		private const string KEY_LABEL      = "Key ID";
		private const string KEY_TYPE       = "KeyType";
		private const string KEY_TYPE_LABEL = "Key Type";
		private const string LABEL          = "Key Data";
		private const string INT_DATA       = "intData";
		private const string FLOAT_DATA     = "floatData";
		private const string BOOL_DATA      = "boolData";
		private const string TRIGGER_DATA   = "triggerData";

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			using(var propScope = FoCsEditor.Disposables.PropertyScope(position, label, property))
			{
				label = propScope.content;
				var labelPos = position.SetWidth(EditorGUIUtility.labelWidth);
				EditorGUI.LabelField(labelPos, label);
				using(var scope = FoCsEditor.Disposables.RectHorizontalScope(6, position.MoveX(labelPos.width).SetWidth(position.width - labelPos.width)))
				{
					using(FoCsEditor.Disposables.Indent(-1))
					{
						EditorGUI.LabelField(scope.GetNext(), KEY_LABEL);
						EditorGUI.PropertyField(scope.GetNext().MoveX(-4), property.FindPropertyRelative(KEY), GUIContent.none);
						EditorGUI.LabelField(scope.GetNext(), KEY_TYPE_LABEL);
						EditorGUI.PropertyField(scope.GetNext().MoveX(-4), property.FindPropertyRelative(KEY_TYPE), GUIContent.none);
						var key     = property.GetTargetObjectOfProperty<AnimatorKey>();
						var typeStr = INT_DATA;

						switch(key.KeyType)
						{
							case AnimatorKey.AnimType.Int:
								typeStr = INT_DATA;

								break;
							case AnimatorKey.AnimType.Float:
								typeStr = FLOAT_DATA;

								break;
							case AnimatorKey.AnimType.Bool:
								typeStr = BOOL_DATA;

								break;
							case AnimatorKey.AnimType.Trigger:
								typeStr = TRIGGER_DATA;

								break;
						}

						EditorGUI.LabelField(scope.GetNext(), LABEL);
						EditorGUI.PropertyField(scope.GetNext(), property.FindPropertyRelative(typeStr), GUIContent.none);
					}
				}
			}
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) => SingleLine;
	}
}
