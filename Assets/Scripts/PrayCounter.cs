using UnityEngine;

namespace Jam
{
    public class PrayCounter : MonoBehaviour
    {

        public delegate void PrayDoneDelegate();
        public event PrayDoneDelegate prayDoneEvent;
        private Component[] detectors;
        private PrayPositionDetector.EPrayPosition previousPosition;
        public int prayMovesToCompletePray = 3;
        private int performedPrayMoves = 0;

        // Use this for initialization
        void Start()
        {
            detectors = GetComponentsInChildren<PrayPositionDetector>();
            foreach (PrayPositionDetector detector in detectors)
            {
                detector.EnterEvent += this.OnPrayMoveDetected;
            }
        }

        void OnPrayMoveDetected(PrayPositionDetector.EPrayPosition position)
        {
            if (position != previousPosition && position == PrayPositionDetector.EPrayPosition.Top)
            {
                performedPrayMoves++;
            }
            if (performedPrayMoves >= prayMovesToCompletePray)
            {
                Debug.Log("Pray Done after " + performedPrayMoves + " moves");
                if (prayDoneEvent != null)
                {
                    prayDoneEvent();
                }
                performedPrayMoves = 0;
            }
            previousPosition = position;
        }
    }
}