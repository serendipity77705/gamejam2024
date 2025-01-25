using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector2 pos = new Vector2(10,2);
    Transform obj;
    void Start()
    {
        Debug.Log("Hello people");
        Debug.Log("What's uppppp");

        transform.position = pos;
    }

    void Update()
    {
        pos.x += Input.GetAxis("Horizontal");
        transform.position = pos;
    }
}


// using UnityEngine;

// public class NewBehaviourScript : MonoBehaviour
// {
//     public float moveSpeed = 5f;  // Speed of movement

//     // Update is called once per frame
//     void Update()
//     {
//         // Get horizontal (left/right) and vertical (up/down) input
//         float horizontal = Input.GetAxis("Horizontal");
//         float vertical = Input.GetAxis("Vertical");

//         // Create a movement vector based on the input
//         Vector2 moveDirection = new Vector2(horizontal, vertical);

//         // Move the sprite by applying the movement vector, adjusting for time
//         transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
//     }
// }
