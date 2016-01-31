using UnityEngine;
using System.Collections;

public class hackkkkk : MonoBehaviour {

    void Awake()
    {

        
    }

	// Use this for initialization
	void Start () {
        foreach (AudioSource source in GetComponentsInChildren<AudioSource>())
        {
            source.Play();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
