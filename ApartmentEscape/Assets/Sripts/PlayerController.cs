using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gm;
    public CharacterController controller;

    public float speed = 5f;
    public float gravity = -30f;

    private float f = 1f;

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
    public void TeleportY(Vector3 position)
    {
        
        transform.position = new Vector3(transform.position.x + f, position.y, transform.position.z);
        Physics.SyncTransforms();
        velocity = Vector3.zero;
        //gm.isTeleported = true;
        //Debug.Log("isTeleported = " + gm.isTeleported);
    }
}
