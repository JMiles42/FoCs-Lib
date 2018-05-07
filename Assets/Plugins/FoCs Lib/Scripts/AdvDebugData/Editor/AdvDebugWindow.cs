﻿using System.Collections.Generic;
using ForestOfChaosLib.Editor;
using ForestOfChaosLib.Editor.Windows;
using UnityEditor;
using UnityEngine;

namespace ForestOfChaosLib.AdvDebug
{
	public class AdvDebugWindow: Window<AdvDebugWindow>
	{
		private const string WINDOW_NAME = "AdvDebugWindow";
		[MenuItem(FileStrings.FORESTOFCHAOS_ + WINDOW_NAME)]
		private static void Init()
		{
			GetWindowAndOpenTab();
			window.titleContent.text = WINDOW_NAME;
		}

		protected override void DrawGUI()
		{
			EditorGUILayout.LabelField($"Time: {Time.time}");

			foreach(var data in AdvDebug.DataDictionary)
			{
				DrawField(data);
			}
		}

		private static void DrawField(KeyValuePair<string, AdvDebug.DictionaryData> data)
		{
			using(FoCsEditor.Disposables.VerticalScope(GUI.skin.box))
			{
				EditorGUILayout.LabelField(data.Key);
				using(FoCsEditor.Disposables.HorizontalScope())
				{
					DrawData(data.Value);
					var tempData = data.Value.previousData;

					for(int i = 0; i < 5; i++)
					{
						if(tempData == null)
							break;
						DrawData(tempData);
						tempData = tempData.previousData;
					}
				}
			}
		}

		private static void DrawData(AdvDebug.DictionaryData data)
		{
			using(FoCsEditor.Disposables.VerticalScope())
			{
				EditorGUILayout.LabelField(data.Value);
				EditorGUILayout.LabelField($"Time: {data.Time}");
			}
		}

		protected override void Update()
		{
			if(Application.isPlaying)
				Repaint();
		}
	}
}