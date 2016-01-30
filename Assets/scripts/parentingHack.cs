using UnityEngine;
using System.Collections;

public class parentingHack : MonoBehaviour {

    public Transform parent;
    public bool ParentPosition;
    public bool SmoothPosition;

    public bool ParentRotation;
    public bool SmoothRotation;

    public bool ParentScale;
    public bool SmoothScale;

    public float SmoothFactor = 0.5f;

    void Update()
    {
        if (ParentPosition)
        {
            if (SmoothPosition) transform.position = Vector3.Lerp(transform.position, parent.position, SmoothFactor);
            else transform.position = parent.position;
        }

        if (ParentRotation)
        {
            if (SmoothRotation) transform.rotation = Quaternion.Slerp(transform.rotation, parent.rotation, SmoothFactor);
            else transform.rotation = parent.rotation;
        }

        if (ParentScale)
        {
            if (SmoothScale) transform.localScale = Vector3.Lerp(transform.localScale, parent.localScale, SmoothFactor);
            else transform.localScale = parent.localScale;

        }
    }
}
