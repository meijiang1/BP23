using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameManager gm;
    public Destinations d;
    public Transform randomDestination;
    public Transform destinationBack;
    

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        //if (gm.isTeleporting == false)
        {
            if (other.CompareTag("Player") && other.TryGetComponent<PlayerController>(out var player))
            {
                if (gm.currentRoom != null)
                {
                    if (gameObject.CompareTag(gm.currentRoom.tag)) //if tag portal == tag room where player at
                    {
                        RandomDestination();
                        player.Teleport(randomDestination.position);
                        Debug.Log("Go to next random room");
                    }
                    else
                    {
                        if (gm.previousRoom != null)
                        {
                            DestinationBack();
                            player.Teleport(destinationBack.position);
                            Debug.Log("Go to previous room");
                        }
                    }
                    gm.previousRoom = gm.currentRoom;
                    //gm.isTeleporting = true;
                    gm.teleportCount++;
                    Debug.Log(gm.teleportCount);
                }
            }
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player") && other.TryGetComponent<PlayerController>(out var player))
    //    {
    //        gm.isTeleporting = false;
    //        Debug.Log("!!!!!!!!!!!!!!!!!!!!!!!!!!");
    //    }
    //}

    Transform RandomDestination()
    {
        if (gm.isInNormalRoom)
        {
            switch (gm.currentRoom.tag)
            {
                case "Entrance":
                    randomDestination = d.DestinationsKitchen[Random.Range(0, d.DestinationsKitchen.Length)];
                    Debug.Log("case entrance, random kitchen");
                    break;
                case "Kitchen":
                    randomDestination = d.DestinationsLiving[Random.Range(0, d.DestinationsLiving.Length)];
                    Debug.Log("case kitchen, random living");
                    break;
                case "Living":
                    randomDestination = d.DestinationsBathroom[Random.Range(0, d.DestinationsBathroom.Length)];
                    Debug.Log("case living, random bathroom");
                    break;
                case "Bathroom":
                    randomDestination = d.DestinationsBedroom[Random.Range(0, d.DestinationsBedroom.Length)];
                    Debug.Log("case bathroom, random bedroom");
                    break;
                case "Bedroom":
                    randomDestination = d.EntranceDestination;
                    Debug.Log("case bedroom, entrance");
                    break;
                default:
                    Debug.Log("case default, entrance");
                    return d.DefaultDestination;   
            }
        }
        else
        {
            switch (gm.currentRoom.tag)
            {
                case "Entrance":
                    randomDestination = d.DestinationsKitchen[Random.Range(1, d.DestinationsKitchen.Length)];
                    break;
                case "Kitchen":
                    randomDestination = d.DestinationsLiving[Random.Range(1, d.DestinationsLiving.Length)];
                    break;
                case "Living":
                    randomDestination = d.DestinationsBathroom[Random.Range(1, d.DestinationsBathroom.Length)];
                    break;
                case "Bathroom":
                    randomDestination = d.DestinationsBedroom[Random.Range(1, d.DestinationsBedroom.Length)];
                    break;
                case "Bedroom":
                    randomDestination = d.EntranceDestination;
                    break;
                default:
                    return d.DefaultDestination;
            }
        }
        return randomDestination;
    }

    Transform DestinationBack()
    {
        if (gm.isInNormalRoom)
        {
            switch (gm.currentRoom.tag)
            {
                case "Kitchen":
                    if (gm.playerPathRooms[0] != null)
                    {
                        destinationBack = gm.playerPathRooms[0].transform.GetChild(0).transform;
                    }
                    Debug.Log(destinationBack);
                    Debug.Log("case kitchen, back to entrance");
                    break;
                case "Living":
                    if (gm.playerPathRooms[1] != null)
                    {
                        destinationBack = gm.playerPathRooms[1].transform.GetChild(0).transform;
                    }
                    Debug.Log("case living, back to kitchen");
                    break;
                case "Bathroom":
                    if (gm.playerPathRooms[2] != null)
                    {
                        destinationBack = gm.playerPathRooms[2].transform.GetChild(0).transform;
                    }
                    Debug.Log("case bathroom, back to living");
                    break;
                case "Bedroom":
                    if (gm.playerPathRooms[3] != null)
                    {
                        destinationBack = gm.playerPathRooms[3].transform.GetChild(0).transform;
                    }
                    Debug.Log("case bedroom, back to bathroom");
                    break;
                case "Entrance":
                    if (gm.playerPathRooms[4] != null)
                    {
                        destinationBack = gm.playerPathRooms[4].transform.GetChild(0).transform;
                    }
                    Debug.Log("case entrance, back to bedroom");
                    break;
                default:
                    Debug.Log("case default, entrance");
                    return d.DefaultDestination;
            }
        }
        else
        {
            switch (gm.currentRoom.tag)
            {
                case "Kitchen":
                    destinationBack = gm.previousRoom.transform.GetChild(0).transform;
                    Debug.Log(destinationBack);
                    Debug.Log("case kitchen, back to entrance");
                    break;
                case "Living":
                    destinationBack = gm.previousRoom.transform.GetChild(0).transform;
                    Debug.Log("case living, back to kitchen");
                    break;
                case "Bathroom":
                    destinationBack = gm.previousRoom.transform.GetChild(0).transform;
                    Debug.Log("case bathroom, back to living");
                    break;
                case "Bedroom":
                    destinationBack = gm.previousRoom.transform.GetChild(0).transform;
                    Debug.Log("case bedroom, back to bathroom");
                    break;
                case "Entrance":
                    destinationBack = gm.previousRoom.transform.GetChild(0).transform;
                    Debug.Log("case entrance, back to bedroom");
                    break;
                default:
                    Debug.Log("case default, entrance");
                    return d.DefaultDestination;
            }
        }
        return destinationBack;
    }

}
