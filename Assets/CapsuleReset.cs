using UnityEngine;
using System.Collections;

public class CapsuleReset : MonoBehaviour {

    private Vector3 position;
    public Transform rattle;

	void Start () {
        position = rattle.position;
	}
	
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Rattle")
        {
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.position = position;
        }
    }
}
