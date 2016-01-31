using UnityEngine;
using System.Collections;
using Jam;

public class RetryOnTouch : MonoBehaviour {

    private DancePointCollisionDetector detector;

    // Use this for initialization
    void Start()
    {
        detector = GetComponent<DancePointCollisionDetector>();
        detector.RattleEvent += Click;
    }

    void Click()
    {
        Application.LoadLevel(0);
    }
}
