using UnityEngine;
using System;
using Jam;

public class WaterController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    void FixedUpdate()
    {
        var factor = 1 - Math.Abs(Balance.balance);
        transform.position = new Vector3(transform.position.x, -1 * factor, transform.position.z);
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
