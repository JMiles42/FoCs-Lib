#region � Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Components
//       File: DestroyAfterTime.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:09 PM
#endregion

using System.Collections;
using UnityEngine;

namespace ForestOfChaos.Unity.Components {
    [AddComponentMenu(FoCsStrings.COMPONENTS_FOLDER_ + "Destroy After Time")]
    public class DestroyAfterTime: FoCsBehaviour {
        public float lifeTime = 10f; //My lifetime

        private void Start() {
            StartCoroutine(Kill());
        }

        private IEnumerator Kill() {
            var waiter = new WaitForSeconds(lifeTime);

            yield return waiter;

            Destroy(gameObject); //Destroy object
        }
    }
}