using UnityEngine;
using System;
using Jam;

public class WaterController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void FixedUpdate()
    {
        float factor = (float) (1 - (Balance.balance * -1));
        transform.position = new Vector3(transform.position.x, -6f * factor, transform.position.z);
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
