using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rigBod;
    Vector2 movement;
    
    //player movement
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rigBod.MovePosition(rigBod.position + movement.normalized * movementSpeed * Time.deltaTime);
    }

    //dodge
}
