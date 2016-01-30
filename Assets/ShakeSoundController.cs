using UnityEngine;
using System.Collections;

public class ShakeSoundController : MonoBehaviour {

    private Rigidbody myRigidbody;
    private Vector3 acceleration;
    private Vector3 lastVelocity;

    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
    void FixedUpdate()
    {
        acceleration = (myRigidbody.velocity - lastVelocity) / Time.fixedDeltaTime;
        lastVelocity = myRigidbody.velocity;
        Debug.LogError("acceleration: " + acceleration.magnitude);
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
