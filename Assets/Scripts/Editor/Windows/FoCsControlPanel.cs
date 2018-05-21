﻿using System;
using System.Collections.Generic;
using System.Reflection;
using ForestOfChaosLib.Editor.Windows;
using ForestOfChaosLib.Extensions;
using ForestOfChaosLib.Utilities;
using UnityEditor;
using UnityEngine;

namespace ForestOfChaosLib.Editor
{
	public partial class FoCsControlPanel: FoCsWindow<FoCsControlPanel>
	{
		private const string SHORT_TITLE = "Control Panel";
		private const string TITLE = "FoCs " + SHORT_TITLE;

		public static GUISkin skin;


		private static List<Type> windowList;
		private static List<Type> WindowList => windowList ?? (windowList = ReflectionUtilities.GetTypesWith<FoCsWindowAttribute>(false));

		private static List<Type> tabList;
		private static List<Type> TabList => tabList ?? (tabList = ReflectionUtilities.GetTypesWith<ControlPanelTabAttribute>(false));

		private static int ActiveTab
		{
			get { return EditorPrefs.GetInt("FoCsCP.ActiveIndex"); }
			set { EditorPrefs.SetInt("FoCsCP.ActiveIndex", value); }
		}

		[MenuItem(FileStrings.FORESTOFCHAOS_ + SHORT_TITLE)]
		private static void Init()
		{
			GetWindowAndShow();
			Window.titleContent = new GUIContent(TITLE);
		}

		protected override void OnGUI()
		{
			FoCsGUI.Layout.Label(TITLE, FoCsGUI.Styles.UnitySkins.BoldLabel);
			using(FoCsEditor.Disposables.HorizontalScope())
			{
				using(FoCsEditor.Disposables.VerticalScope(GUILayout.Width(200)))
				{
					DrawWindowButtons();
				}
				using(FoCsEditor.Disposables.VerticalScope())
				{
					using(FoCsEditor.Disposables.HorizontalScope(FoCsGUI.Styles.Toolbar))
					{
						DrawTabButtons();
					}
					if(TabList.InRange(ActiveTab))
					{
						TabList[ActiveTab].
								GetMethod("DrawGUI")?.
								Invoke(null,
									   new object[]
									   {
										   this
									   });
					}
				}
			}
		}

		private void Update()
		{
			if(mouseOverWindow)
			{
				Repaint();
			}
		}

		private static void DrawWindowButtons()
		{
			foreach(var key in WindowList)
			{
				using(FoCsEditor.Disposables.HorizontalScope(FoCsGUI.Styles.Toolbar))
				{
					var @event = FoCsGUI.Layout.Button(key.Name.SplitCamelCase(), FoCsGUI.Styles.ToolbarButton, GUILayout.Height(32));
					if(@event.Value)
					{
						Window.ShowNotification(new GUIContent($"Clicked: {key.Name.SplitCamelCase()}"));
						key.GetMethod("Init", BindingFlags.NonPublic | BindingFlags.Static)?.Invoke(null, null);
						//var otherWin = GetWindow(key);
					}
				}
			}
		}

		private static void DrawTabButtons()
		{
			var index = 0;
			foreach(var key in TabList)
			{
				using(FoCsEditor.Disposables.HorizontalScope(FoCsGUI.Styles.Toolbar))
				{
					var @event = FoCsGUI.Layout.Toggle(ActiveTab == index, key.Name.SplitCamelCase(), FoCsGUI.Styles.ToolbarButton, GUILayout.Height(32));
					if(@event)
					{
						ActiveTab = index;
						Window.ShowNotification(new GUIContent($"Clicked: {key.Name.SplitCamelCase()}"));
					}
				}
				++index;
			}
		}
	}
}