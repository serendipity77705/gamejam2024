using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    float speedX, speedY;
    public BubbleManager bubbleManager;
    // public float defaultSpeedX = 0.5f;
    // public float defaultSpeedY = 1f;
    // public float speedX;
    // public float speedY;
    public float directionX, directionY;
    // public float timer = 0f;

    Vector2 movementY = Vector2.up;
    Vector2 movementX = Vector2.right;

    private Rigidbody2D bubbleBody;

    void Start()
    {
        bubbleManager = FindObjectOfType<BubbleManager>();

        speedX = bubbleManager.defaultSpeedX;
        speedY = bubbleManager.defaultSpeedY;

        bubbleBody = GetComponent<Rigidbody2D>();

        // Start at the top of the screen, centered horizontally
        transform.position = new Vector3(0f, Camera.main.orthographicSize, 0f);
        if (bubbleManager.timer % 60 == 0){
            // if (Random.Range(0f, 1f) > 0.5){
                transform.position = new Vector3(
                Random.Range(
                    -Camera.main.orthographicSize * Camera.main.aspect, 
                    Camera.main.orthographicSize * Camera.main.aspect), 
                Camera.main.orthographicSize);


                directionX = Random.Range(0, 2) * 2 - 1;
                directionY = Random.Range(0, 2) * 2 - 1;
            // }
        }
        
    }

    void Update()
    {
        bubbleManager.timer += Time.deltaTime;

        if (Time.deltaTime % 60 == 30)
        {

            // transform.position = new Vector3(
            //     Random.Range(
            //         -Camera.main.orthographicSize * Camera.main.aspect, 
            //         Camera.main.orthographicSize * Camera.main.aspect),
            //     Camera.main.orthographicSize);

            // Set random directions for the bubble
            directionX = Random.Range(0, 2) * 2 - 1;  // Randomly choose -1 or 1
            directionY = 1;  // Always move upwards initially
        }

        transform.Translate(movementX * directionX * bubbleManager.speedX * Time.deltaTime);
        transform.Translate(movementY * directionY * bubbleManager.speedY * Time.deltaTime);

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

        // if (Random.Range(0f, 1f) > 0.1) // 1% chance to reverse direction for random behavior
        // {
        //     directionX *= -1; // Reverse horizontal direction
        // }


        // if (bubbleManager.timer >= 2f)
        // {
        //     speedX += 5;
        //     speedY += 5f;
        //     bubbleManager.timer = 0f;
        // }
        
        // if (Random.Range(0f, 1f) > 0.999) // 1% chance to reverse direction for random behavior
        //     {
        //         directionX *= -1; // Reverse horizontal direction
        //         directionY *= -1;
        //     }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        directionX *= -1;
        directionY *= -1;
    }

    
}

