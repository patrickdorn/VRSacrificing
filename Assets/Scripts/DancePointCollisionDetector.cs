using UnityEngine;
namespace Jam
{
    public class DancePointCollisionDetector : MonoBehaviour
    {

        public delegate void RattleDelegate();
        public event RattleDelegate RattleEvent;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Rattle") && RattleEvent != null)
            {
                RattleEvent();
            }
        }
    }
}
