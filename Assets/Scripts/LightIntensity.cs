using UnityEngine;
using Jam;

public class LightIntensity : MonoBehaviour {

    private Light sunLight;
    private LensFlare sunFlare;
    private float factor;

    // Use this for initialization
    void Start () {
        sunFlare = GetComponent<LensFlare>();
        sunLight = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Balance.balance < 0)
        {
            factor = Balance.balance / 2;
        } else
        {
            factor = Balance.balance * 3;
        }
        sunFlare.brightness = 1 + factor;
        sunLight.intensity = 1 + Balance.balance / 2;
	}
}
