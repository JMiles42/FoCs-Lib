#region � Forest Of Chaos Studios 2019 - 2020
//   Solution: FoCs-Library
//    Project: FoCs.Unity.Components
//       File: IKControl.cs
//    Created: 2019/05/21 | 12:00 AM
// LastEdited: 2020/10/11 | 10:09 PM
#endregion

using UnityEngine;

namespace ForestOfChaos.Unity.Animation {
    [AddComponentMenu(FoCsStrings.COMPONENTS_FOLDER_ + "IKControl")]
    public class IKControl: FoCsBehaviour {
        [SerializeField]
        protected Animator animator;

        public bool      headIkActive;
        public bool      leftHandIkActive;
        public Transform leftHandObj;
        public Transform lookObj;
        public bool      rightHandIkActive;
        public Transform rightHandObj;

        private void Start() {
            if (!animator)
                animator = GetComponent<Animator>();
        }

        private void OnAnimatorIK() {
            if (!animator)
                return;

            // Set the look target position, if one has been assigned
            if ((lookObj != null) && headIkActive) {
                animator.SetLookAtWeight(1);
                animator.SetLookAtPosition(lookObj.position);
            }
            else
                animator.SetLookAtWeight(0);

            // Set the right hand target position and rotation, if one has been assigned
            if ((rightHandObj != null) && rightHandIkActive) {
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
                animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
                animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation);
            }
            else {
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0);
            }

            // Set the right hand target position and rotation, if one has been assigned
            if ((leftHandObj != null) && leftHandIkActive) {
                animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
                animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
                animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandObj.position);
                animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandObj.rotation);
            }
            else {
                animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 0);
            }
        }
    }
}