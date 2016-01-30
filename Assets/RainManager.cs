using UnityEngine;
using Jam;

public class RainManager : MonoBehaviour {
    private EllipsoidParticleEmitter[] emitters;

    // Use this for initialization
    void Start()
    {
        emitters = GetComponentsInChildren<EllipsoidParticleEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (EllipsoidParticleEmitter emitter in emitters)
        {
            if (Balance.balance < 0)
            {
                emitter.maxEmission = Balance.balance * -1 * 1000;
            }
            else
            {
                emitter.maxEmission = 0;
            }

        }
    }

}
