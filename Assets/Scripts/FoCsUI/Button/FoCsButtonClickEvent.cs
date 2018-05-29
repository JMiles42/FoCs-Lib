using UnityEngine;
using UText = UnityEngine.UI.Text;
using UButton = UnityEngine.UI.Button;

namespace ForestOfChaosLib.FoCsUI.Button
{
	public class FoCsButtonClickEvent: FoCsButton
	{
		public UText TextObj;

		public override string Text
		{
			get { return TextObj == null? "" : TextObj.text; }
			set
			{
				if(TextObj != null)
					TextObj.text = value;
			}
		}

		public override GameObject TextGO => TextObj.gameObject;

		private void Reset()
		{
			Button  = GetComponentAdvanced<UButton>();
			TextObj = GetComponentInChildrenAdvanced<UText>();
		}
	}
}