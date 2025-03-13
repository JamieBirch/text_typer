using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public AudioManager audioManager;
    
    public float interval;
    private float timeout = 0;

    public string text = "new text";
    public Text textObject;
    
    private int currentIndex = 0;
    
    // Update is called once per frame
    void Update()
    {
        if (timeout <= 0 && currentIndex < text.Length)
        {
            textObject.text += text[currentIndex]; // Add the next letter
            currentIndex++;
            
            // Play typing sound
            if (audioManager != null)
            {
                audioManager.PlayTypingSound();
            }
            
            // Randomize interval by ±50%
            timeout = interval * Random.Range(0.5f, 1.5f);
        }
        timeout -= Time.deltaTime;
    }
}
