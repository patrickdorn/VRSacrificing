using UnityEngine;
namespace Jam
{

    public class PrayPositionDetector : MonoBehaviour
    {

        public delegate void EnterDelegate(EPrayPosition position);
        public event EnterDelegate EnterEvent;

        public enum EPrayPosition
        {
            Top,
            Bottom
        }

        public EPrayPosition position;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Prayer") && EnterEvent != null)
            {
                EnterEvent(position);
            }
        }
    }
}
