using UnityEngine;

public class BubbleManager : MonoBehaviour
{
    public float defaultSpeedX = 0.5f;
    public float defaultSpeedY = 1f;
    public float speedX;
    public float speedY;
    public float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 10f)
        {
            speedX += 0.5f;
            speedY += 0.5f;
            timer = 0f;
        }
    }

    public void ResetSpeed()
    {
        speedX = defaultSpeedX;
        speedY = defaultSpeedY;
        timer = 0f;
        Debug.Log("Is the button pressed?");
    }
}
