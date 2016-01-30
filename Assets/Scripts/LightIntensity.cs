using UnityEngine;
using Jam;

public class LightIntensity : MonoBehaviour {

    private LensFlare sun;
    private float factor;

    // Use this for initialization
    void Start () {
        sun = GetComponent<LensFlare>();
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
        sun.brightness = 1 + factor;
	}
}
