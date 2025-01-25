using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    float speedX = 0.5f;
    float speedY = 1f;
    float directionX, directionY;

    Vector2 movementY = Vector2.up;
    Vector2 movementX = Vector2.right;

    void Start()
    {
        // Start at the bottom of the screen, centered horizontally
        transform.position = new Vector3(0f, -Camera.main.orthographicSize, 0f);

        directionX = Random.Range(0, 2) * 2 - 1;
        directionY = Random.Range(0, 2) * 2 - 1;
    }

    void Update()
    {
        transform.Translate(movementX * directionX * speedX * Time.deltaTime);
        
        transform.Translate(movementY * directionY * speedY * Time.deltaTime);

        if (transform.position.y > Camera.main.orthographicSize) 
        {
            directionY = -1;
        }
        else if (transform.position.y < -Camera.main.orthographicSize) 
        {
            directionY = 1;
        }

        if (transform.position.x > Camera.main.orthographicSize * Camera.main.aspect) 
        {
            directionX = -1;
        }
        else if (transform.position.x < -Camera.main.orthographicSize * Camera.main.aspect) 
        {
            directionX = 1;
        }

        if (Random.Range(0, 100) < 1) // 1% chance to reverse direction for random behavior
        {
            directionX *= -1; // Reverse horizontal direction
        }
    }
}
