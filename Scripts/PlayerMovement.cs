using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Joystick joystick;
    public CharacterController controller;
    Vector3 velocity;

    void Update()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        Vector3 move = new Vector3(x, 0, z);
        controller.Move(move * speed * Time.deltaTime);

        // Gravity
        if (!controller.isGrounded)
            velocity.y += -9.8f * Time.deltaTime;
        else 
            velocity.y = -2f;

        controller.Move(velocity * Time.deltaTime);
    }
}
