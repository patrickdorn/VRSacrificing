using UnityEngine;
using System;

namespace Jam
{

    public class Balance : MonoBehaviour
    {

        private PrayCounter prayCounter;
        private DanceManager danceManager;
        public static float balance { get; set; }
        private float speed = 2;
        private float multi = 0.01f;

        // Use this for initialization
        void Start()
        {
            prayCounter = GetComponentsInChildren<PrayCounter>()[0];
            danceManager = GetComponentsInChildren<DanceManager>()[0];
            prayCounter.prayDoneEvent += this.DidPray;
            danceManager.danceEvent += this.DidDance;
        }

        // Update is called once per frame
        void Update()
        {
            if (Math.Abs(balance) == 1)
            {
                balance = 0;
                Application.LoadLevel(1);
            }
            balance = balance + multi * speed * Time.deltaTime;
            NormalizeBalance();
        }

        void NormalizeBalance()
        {
            if (balance < -1)
            {
                balance = -1;
            }
            if (balance > 1)
            {
                balance = 1;
            }
            if (balance == 0)
            {
                balance = 0.1f;
            }
        }

        void DidPray()
        {
            speed++;
            Debug.LogError("DidPray. Speed goes up to: " + speed);
        }

        void DidDance()
        {
            speed--;
            Debug.LogError("DidDance. Speed goes down to: " + speed);
        }
    }
}
