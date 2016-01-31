using UnityEngine;
using Jam;

public class TimeTracker : MonoBehaviour {

    public int secondsToWin = 180;
	
	// Update is called once per frame
	void Update () {
	    if (Time.timeSinceLevelLoad >= secondsToWin)
        {
            Balance.balance = 0;
            Application.LoadLevel(2);
        }
	}
}
