﻿using ForestOfChaosLib.Editor.UnitySettings;
using UnityEditor;
using UnityEngine;

namespace ForestOfChaosLib.Editor.Windows
{
	[FoCsWindow]
	public class VersionNumberWindow: FoCsWindow<VersionNumberWindow>
	{
		private const string TITLE = "Version Number";

		[MenuItem(FileStrings.FORESTOFCHAOS_ + TITLE)]
		internal static void Init()
		{
			GetWindowAndShow();
			Window.titleContent.text = TITLE;
		}

		private static readonly GUIContent         Heading = new GUIContent("Bundle Version");
		private                 string             versionNumber;
		private static          SerializedObject   SerializedObject;
		private static          SerializedProperty BundleVersion => SerializedObject.FindProperty("bundleVersion");

		private void OnEnable()
		{
			SerializedObject = new SerializedObject(UnitySettingsReader.ProjectSettings);
			versionNumber    = BundleVersion.stringValue;
		}

		protected override void OnGUI()
		{
			FoCsGUI.Layout.Label(Heading);

			using(FoCsEditor.Disposables.HorizontalScope())
			{
				using(var cc = FoCsEditor.Disposables.ChangeCheck())
				{
					versionNumber = FoCsGUI.Layout.DelayedTextField(versionNumber);

					if(cc.changed)
					{
						BundleVersion.stringValue = versionNumber;
						SerializedObject.ApplyModifiedProperties();
					}
				}
			}

		}
	}
}