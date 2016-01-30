using UnityEngine;
using System;
using Jam;

public class WaterController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void FixedUpdate()
    {
        float factor;
        if (Balance.balance == 1)
        {
            factor = 0f;
        } else { 
            factor = (float)Math.Sqrt(1 - Math.Abs(Balance.balance));
        }
        transform.position = new Vector3(transform.position.x, -6f * factor, transform.position.z);
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
