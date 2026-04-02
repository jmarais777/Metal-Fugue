using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rigBod;
    Vector2 movement;

    //Player Movement
    //Title: Top Down Movement In UNITY 6
    //Author: Unity Unlocked
    //Date: 02/04/2026
    //Availiability: https://www.youtube.com/watch?v=Rs8Wy9jH8iA
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

 
    private void FixedUpdate()
    {
        rigBod.MovePosition(rigBod.position + movement.normalized * movementSpeed * Time.deltaTime);
    }
}
