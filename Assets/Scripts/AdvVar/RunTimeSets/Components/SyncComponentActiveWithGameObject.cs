﻿namespace ForestOfChaosLib.AdvVar.RuntimeRef.Components
{
	public class SyncComponentActiveWithGameObject: FoCsBehaviour
	{
		public MonoBehaviourRunTimeRef MonoBehaviourRunTimeRef;

		private void OnEnable()
		{
			if(MonoBehaviourRunTimeRef)
			{
				if(MonoBehaviourRunTimeRef.Reference)
					MonoBehaviourRunTimeRef.Reference.enabled = true;
			}
		}

		private void OnDisable()
		{
			if(MonoBehaviourRunTimeRef)
			{
				if(MonoBehaviourRunTimeRef.Reference)
					MonoBehaviourRunTimeRef.Reference.enabled = false;
			}
		}
	}
}