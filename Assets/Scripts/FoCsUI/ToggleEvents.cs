using System;
using ForestOfChaosLib.Extensions;
using UnityEngine;
using UnityEngine.UI;

namespace ForestOfChaosLib.FoCsUI
{
	[RequireComponent(typeof(Toggle))]
	public class ToggleEvents: FoCsBehavior
	{
		public Toggle _Toggle;

		public bool Value
		{
			get { return _Toggle.isOn; }
			set { _Toggle.isOn = value; }
		}

		public Action<bool> onValueChanged;

		private void OnEnable()
		{
			if(_Toggle == null)
				_Toggle = GetComponent<Toggle>();
			_Toggle.onValueChanged.AddListener(ValueChanged);
		}

		private void OnDisable()
		{
			_Toggle.onValueChanged.RemoveListener(ValueChanged);
		}

		private void ValueChanged(bool value)
		{
			onValueChanged.Trigger(value);
		}
	}
}