﻿using UnityEngine;
namespace Jam
{
    public class DancePointCollisionDetector : MonoBehaviour
    {
        public enum Type {
            Right, Left
        }

        public Type type;
        public delegate void RattleDelegate();
        public event RattleDelegate RattleEvent;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Rattle") && RattleEvent != null)
            {
                if (type == Type.Left) {
                    PlayGongLeft.instance.play();
                } else
                {
                    PlayRightGong.instance.play();
                }
                RattleEvent();
            }
        }
    }
}
