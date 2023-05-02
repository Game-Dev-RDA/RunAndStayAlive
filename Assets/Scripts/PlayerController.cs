using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // player movement speed

    // Update is called once per frame
    void Update()
    {
        // get input from keyboard arrows
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // calculate movement vector
        Vector3 movement = new Vector3(horizontal, vertical, 0f) * speed * Time.deltaTime;

        // move the player
        transform.position += movement;
    }
}