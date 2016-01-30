using UnityEngine;
namespace Jam
{

    public class Balance : MonoBehaviour
    {

        private PrayCounter prayCounter;
        public static float balance { get; private set; }
        private float speed = 0;
        private float multi = 0.01f;

        // Use this for initialization
        void Start()
        {
            prayCounter = GetComponentsInChildren<PrayCounter>()[0];
            prayCounter.prayDoneEvent += this.DidPray;
        }

        // Update is called once per frame
        void Update()
        {
            balance = balance + multi * speed * Time.deltaTime;
            NormalizeBalance();
            Debug.LogError("Balance: " + balance);
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
                balance = 0.01f;
            }
        }

        void DidPray()
        {
            speed++;
            Debug.Log("DidPray. Speed goes up to: " + speed);
        }

        void DidDance()
        {
            speed--;
            Debug.Log("DidDance. Speed goes down to: " + speed);
        }
    }
}
