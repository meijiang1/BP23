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
                    if (gameObject == gm.correctRooms[0])
                    {
                        gm.isRoomCorrect[0] = true;
                    }
                    if (gm.playerPathRooms[0] == gm.correctRooms[0])
                    {
                        gm.isRoomCorrect[0] = true;
                    }
                    break;
                case "Kitchen":
                    gm.playerPathRooms[1] = gameObject;
                    if (gameObject == gm.correctRooms[1])
                    {
                        gm.isRoomCorrect[1] = true;
                    }
                    if (gm.playerPathRooms[1] == gm.correctRooms[1])
                    {
                        gm.isRoomCorrect[1] = true;
                    }
                    break;
                case "Living":
                    gm.playerPathRooms[2] = gameObject;
                    if (gameObject == gm.correctRooms[2])
                    {
                        gm.isRoomCorrect[2] = true;
                    }
                    if (gm.playerPathRooms[2] == gm.correctRooms[2])
                    {
                        gm.isRoomCorrect[2] = true;
                    }
                    break;
                case "Bathroom":
                    gm.playerPathRooms[3] = gameObject;
                    if (gameObject == gm.correctRooms[3])
                    {
                        gm.isRoomCorrect[3] = true;
                    }
                    if (gm.playerPathRooms[3] == gm.correctRooms[3])
                    {
                        gm.isRoomCorrect[3] = true;
                    }
                    break;
                case "Bedroom":
                    gm.playerPathRooms[4] = gameObject;
                    if (gameObject == gm.correctRooms[4])
                    {
                        gm.isRoomCorrect[4] = true;
                    }
                    if (gm.playerPathRooms[4] == gm.correctRooms[4])
                    {
                        gm.isRoomCorrect[4] = true;
                    }
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
