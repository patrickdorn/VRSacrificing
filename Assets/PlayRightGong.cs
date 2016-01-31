using UnityEngine;

public class PlayRightGong : MonoBehaviour
{
    
    private AudioSource audioSource;
    public static PlayRightGong instance;

    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    public void play()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
