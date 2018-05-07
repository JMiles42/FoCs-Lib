using System;
using ForestOfChaosLib.Extensions;
using UnityEngine;
using UButton = UnityEngine.UI.Button;

namespace ForestOfChaosLib.FoCsUI.Button
{
	public abstract class ButtonComponentBase: FoCsBehavior
	{
		public Action onMouseClick = () => { };
		public abstract UButton Button { get; }
		public abstract string ButtonText { get; set; }
		public abstract GameObject ButtonGO { get; }
		public abstract GameObject TextGO { get; }

		public bool Interactable
		{
			get { return Button.interactable; }
			set { Button.interactable = value; }
		}

		private void MouseClick()
		{
			onMouseClick.Trigger();
		}

		public void OnEnable()
		{
			//if(Button)
				Button.onClick.AddListener(MouseClick);
		}

		public void OnDisable()
		{
			//if(Button)
				Button.onClick.RemoveListener(MouseClick);
		}
	}
}