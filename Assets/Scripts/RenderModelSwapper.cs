using UnityEngine;
using System.Collections;

public class RenderModelSwapper : MonoBehaviour {

    public GameObject Theparent;
    public GameObject Theparent_fallback;
    public Animator animat0r;

    private NewtonVR.NVRHand Thehand;

    void Start()
    {
        if (Theparent != null)
        {
            Thehand = Theparent.GetComponent<NewtonVR.NVRHand>();
        }
        else
        {
            Thehand = Theparent_fallback.GetComponent<NewtonVR.NVRHand>();
        }
    }

    void Update()
    {
        if (animat0r.GetBool("isGrabbing"))
        {
            animat0r.SetBool("isGrabbing", false);
        }
        if (animat0r.GetBool("isOpening"))
        {
            animat0r.SetBool("isOpening", false);
        }
        if (Thehand.HoldButtonDown)
        {
            animat0r.SetBool("isGrabbing", true);
        }
        else if (Thehand.HoldButtonUp)
        {
            animat0r.SetBool("isOpening", true);
        }
    }

}
