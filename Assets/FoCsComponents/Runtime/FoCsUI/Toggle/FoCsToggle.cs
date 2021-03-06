#region � Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Components
//       File: FoCsToggle.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:09 PM
#endregion

using System;
using UnityEngine;
using UToggle = UnityEngine.UI.Toggle;

namespace ForestOfChaos.Unity.FoCsUI.Toggle {
    public abstract class FoCsToggle: FoCsBehaviour {
        public Action<bool> onValueChanged;
        public UToggle      Toggle;

        public abstract string Text { get; set; }

        public abstract GameObject TextGO { get; }

        public bool Interactable {
            get => Toggle.interactable;
            set => Toggle.interactable = value;
        }

        public bool Toggled {
            get => Toggle.isOn;
            set => Toggle.isOn = value;
        }

        private void MouseClick(bool value) {
            onValueChanged?.Invoke(value);
        }

        public void OnEnable() {
            if (Toggle)
                Toggle.onValueChanged.AddListener(MouseClick);
        }

        public void OnDisable() {
            if (Toggle)
                Toggle.onValueChanged.RemoveListener(MouseClick);
        }
    }
}