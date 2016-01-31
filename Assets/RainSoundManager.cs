using UnityEngine;
using System;
using Jam;

public class RainSoundManager : MonoBehaviour {

    public AudioSource source;
    private float factor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Balance.balance > 0)
        {
            factor = - Balance.balance + 1;
        }
        else
        {
            factor = 1;
        }
        source.volume = factor;
    }
}
