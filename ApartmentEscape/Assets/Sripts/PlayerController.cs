using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 5f;
    public float gravity = -30f;

    Vector3 velocity;

    bool isGrounded;

    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }

    public void Teleport(Vector3 position)
    {
        transform.position = position;
        Physics.SyncTransforms();
        velocity = Vector3.zero;
    }
}
