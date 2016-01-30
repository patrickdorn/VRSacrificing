using UnityEngine;
using System.Collections;

public class MaterialBlender : MonoBehaviour {


    public bool useBalance = true;
    [Range(0f, 1f)]
    public float Blend;

    private Material mat;
    private Color blendCol = Color.white;
    private float currentBlend;

    void Awake()
    {
        mat = gameObject.GetComponent<Renderer>().material;
    }

    void Update()
    {
        if (useBalance) currentBlend = Mathf.Lerp(currentBlend, Mathf.Clamp(Jam.Balance.balance, 0f, 1f), Time.deltaTime);
        else currentBlend = Mathf.Lerp(currentBlend, Blend, Time.deltaTime);

        blendCol.a = currentBlend;
        mat.SetColor("_Color", blendCol);
    }
}
