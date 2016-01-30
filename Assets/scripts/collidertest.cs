using UnityEngine;
using System.Collections;

public class collidertest : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "controller_LEFT")
        {
            Debug.Log("LEFT controller touched the BALL");
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        else
        {
            if (other.tag == "controller_RIGHT")
            {
                Debug.Log("RIGHT controller touched the BALL");
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "controller_LEFT" || other.tag == "controller_RIGHT")
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
        }
    }
}
