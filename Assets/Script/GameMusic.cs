using UnityEngine;

public class GameMusic : MonoBehaviour
{
    private static GameMusic instance;
    private AudioSource audioSource;

    void Awake()
    {
        // Prevent duplicates when scenes change
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.Play();
    }

    // Optional: stop at credits/end
    public void StopMusic()
    {
        audioSource.Stop();
        Destroy(gameObject);
    }
}
