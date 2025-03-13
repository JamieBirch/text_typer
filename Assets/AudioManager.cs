using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] typingSounds;

    public void PlayTypingSound()
    {
        if (typingSounds.Length > 0)
        {
            AudioClip clip = typingSounds[Random.Range(0, typingSounds.Length)];
            audioSource.PlayOneShot(clip);
        }
    }
}
