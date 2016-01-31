using UnityEngine;
using System.Collections;

public class MaterialBlender : MonoBehaviour {


    public bool useBalance = true;
    [Range(0f, 1f)]
    public float Blend;
    [SerializeField]
    private float balannceeeedude;

    private Material mat;
    private Color blendCol = Color.white;
    private float currentBlend;

    void Awake()
    {
        mat = gameObject.GetComponent<Renderer>().material;
        blendCol.a = 0f;
        mat.SetColor("_Color", blendCol);
    }

    void Update()
    {
        balannceeeedude = Jam.Balance.balance;
        if (useBalance) currentBlend = Mathf.Lerp(currentBlend, Mathf.Clamp(Jam.Balance.balance, 0.1f, 1f), Time.deltaTime);
        else currentBlend = Mathf.Lerp(currentBlend, Blend, Time.deltaTime);

        blendCol.a = currentBlend;
        mat.SetColor("_Color", blendCol);
    }
}
