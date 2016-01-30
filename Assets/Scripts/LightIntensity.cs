using UnityEngine;
using Jam;

public class LightIntensity : MonoBehaviour {

    Light sun;

    // Use this for initialization
    void Start () {
        sun = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        sun.intensity = 1 + Balance.balance;
	}
}
