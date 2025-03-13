using UnityEngine;

public class Flicker : MonoBehaviour
{
    public GameObject cursor;
    public float interval;
    private float timeout = 0;

    // Update is called once per frame
    void Update()
    {
        if (timeout <= 0)
        {
            //flicker
            Switch();
            timeout = interval;
        }

        timeout -= Time.deltaTime;
    }

    private void Switch()
    {
        if (cursor.activeSelf)
        {
            cursor.SetActive(false);
        }
        else
        {
            cursor.SetActive(true);
        }
    }
}
