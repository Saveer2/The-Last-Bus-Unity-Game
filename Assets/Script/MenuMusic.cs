using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    private static MenuMusic instance;
    private AudioSource audioSource;

    void Awake()
    {
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

    public void StopMusic()   // ← THIS METHOD MUST EXIST
    {
        audioSource.Stop();
        Destroy(gameObject);
    }
}
