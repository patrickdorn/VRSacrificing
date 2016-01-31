using UnityEngine;
using System.Collections;

public class RenderModelSwapper : MonoBehaviour {

    public GameObject Theparent;
    public GameObject model1;
    public GameObject model2;

    private NewtonVR.NVRHand Thehand;

    void Start()
    {
        Thehand = Theparent.GetComponent<NewtonVR.NVRHand>();
    }

    void Update()
    {
        if (Thehand.HoldButtonPressed)
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
