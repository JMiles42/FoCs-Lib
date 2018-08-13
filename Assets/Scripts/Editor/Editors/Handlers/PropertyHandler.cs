﻿using UnityEditor;

namespace ForestOfChaosLib.Editor
{
	public class PropertyHandler: IPropertyLayoutHandler
	{
		private readonly FoCsEditor owner;

		public PropertyHandler(FoCsEditor _owner)
		{
			owner = _owner;
		}

		public void HandleProperty(SerializedProperty property)
		{
			FoCsGUI.Layout.PropertyField(property, property.isExpanded);
		}

		public float PropertyHeight(SerializedProperty property)
		{
			return FoCsGUI.GetPropertyHeight(property);
		}

		public bool IsValidProperty(SerializedProperty property)
		{
			return true;
		}
	}
}