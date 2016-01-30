using UnityEngine;
using System.Collections;
using NewtonVR;

namespace Jam
{
    public class RattleInteractableItem : NVRInteractableItem
    {
        public override void BeginInteraction(NVRHand hand)
        {
            DanceManager.instance.startDance();
            base.BeginInteraction(hand);
        }

        public override void EndInteraction()
        {
            DanceManager.instance.stopDance();
            base.EndInteraction();
        }
    }
}