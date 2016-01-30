using UnityEngine;
using System.Collections;
using Jam;

public class DustManager : MonoBehaviour {

    private ParticleSystem system;

	// Use this for initialization
	void Start () {
        system = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Balance.balance < 0)
        {
            system.maxParticles = (int) ( Balance.balance * -1f * 1000f);
        }
	}
}
