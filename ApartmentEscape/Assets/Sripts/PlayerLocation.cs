using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    public GameManager gm;
    public RoomCheck rc;

    void Start()
    {
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent<PlayerController>(out var player))
        {
            gm.currentRoom = gameObject;
            switch (gameObject.tag)
            {
                case "Entrance":
                    gm.playerPathRooms[0] = gameObject;
                    break;
                case "Kitchen":
                    gm.playerPathRooms[1] = gameObject;
                    break;
                case "Living":
                    gm.playerPathRooms[2] = gameObject;
                    break;
                case "Bathroom":
                    gm.playerPathRooms[3] = gameObject;
                    break;
                case "Bedroom":
                    gm.playerPathRooms[4] = gameObject;
                    break;
                default:
                    Debug.Log("case default");
                    return;
            }
            //gm.isTeleporting = false;
            //Debug.Log("isTeleporting = " + gm.isTeleporting);
        }
    }
}
