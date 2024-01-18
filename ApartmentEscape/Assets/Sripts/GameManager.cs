using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject portals;

    public GameObject currentRoom = null;
    public GameObject previousRoom = null;

    public GameObject[] playerPathRooms = new GameObject[5];

    public bool isInNormalRoom = true;
    public bool isTeleported = false;
    public bool isTeleporting = false;
    public int teleportCount = 0;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) { Debug.Log("Current room: " + currentRoom.name + currentRoom.tag); }
        if (Input.GetKeyDown(KeyCode.P)) { Debug.Log("Previous room: " + previousRoom.name + previousRoom.tag); }
        if (Input.GetKeyDown(KeyCode.R)) { Debug.Log("isTeleported = " + isTeleported); }
        if (Input.GetKeyDown(KeyCode.T)) { Debug.Log("isTeleporting = " + isTeleporting); }
        if (Input.GetKeyDown(KeyCode.Y)) { Debug.Log("teleportCount = " + teleportCount); }

        //if (teleportCount == 0)
        //{
        //    portals.SetActive(true);
        //}

        //if (!isTeleporting && teleportCount!= 0 && isTeleported)
        //{
        //    portals.SetActive(false);
        //}
        //else
        //{
        //    portals.SetActive(true);
        //}

        //if (isTeleported) { portals.SetActive(true); }else { portals.SetActive(false); }
        //if (isTeleporting) { isTeleported = false; }


        //if (isTeleporting) { portals.SetActive(false); } else { portals.SetActive(true); }

        //if (previousroom != null)
        //{
        //    if ((currentroom != previousroom) && !isteleporting)
        //    {
        //        isteleported = true;
        //    }
        //    else
        //    {
        //        isteleported = true;
        //    }
        //}
    }

    //player location
    //end room = win
}
