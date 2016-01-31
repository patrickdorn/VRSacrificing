using UnityEngine;
using System.Collections;
using Jam;

public class EndApplicationOnTouch : MonoBehaviour {

    private DancePointCollisionDetector detector;

    // Use this for initialization
    void Start () {
        detector = GetComponent<DancePointCollisionDetector>();
        detector.RattleEvent += Click;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Click()
    {
        Application.Quit();
    }
}
