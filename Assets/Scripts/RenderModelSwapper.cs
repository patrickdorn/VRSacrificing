using UnityEngine;
using System.Collections;

public class RenderModelSwapper : MonoBehaviour {

    public GameObject parent;
    public GameObject model1;
    public GameObject model2;

    private NewtonVR.NVRHand hand;

    void Start()
    {
        hand = parent.GetComponent<NewtonVR.NVRHand>();
    }

    void Update()
    {
        if (hand.HoldButtonPressed)
        {
            model1.SetActive(true);
            model2.SetActive(false);
        }
        else
        {
            model1.SetActive(false);
            model2.SetActive(true);
        }
    }

}
