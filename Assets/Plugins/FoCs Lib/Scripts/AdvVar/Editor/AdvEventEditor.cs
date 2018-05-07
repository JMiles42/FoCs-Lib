﻿using ForestOfChaosLib.AdvVar.Events;
using ForestOfChaosLib.Editor;
using UnityEditor;
using UnityEngine;

namespace ForestOfChaosLib.AdvVar.Editor
{
	[CustomEditor(typeof(AdvEvent))]
	public class AdvEventEditor: FoCsEditor<AdvEvent>
	{
		public override void DrawGUI()
		{
			using(Disposables.DisabledScope(!Application.isPlaying))
			{
				var @event = FoCsGUI.Layout.Button("Trigger Event");
				if(@event.AsButtonLeftClick)
					Target.Trigger();
			}
		}
	}
}