using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //set in scene
    public GameObject block;
    public GameObject portals;
    public GameObject[] correctRooms = new GameObject[5];
    //adjust with code
    public bool[] isRoomCorrect = new bool[5] {false, false, false, false, false};
    public int correctRoomCount = 0;

    public GameObject currentRoom = null;
    public GameObject previousRoom = null;

    public GameObject[] playerPathRooms = new GameObject[5];

    //not in use
    public bool isInNormalRoom = true;
    public bool isTeleported = false;
    public bool isTeleporting = false;
    public int teleportCount = 0;

    void Start()
    {
        block.SetActive(true);
    }

    void Update()
    {
        if (playerPathRooms[4] != null) { block.SetActive(false); }
        if (Input.GetKeyDown(KeyCode.C)) { Debug.Log("Current room: " + currentRoom.name + currentRoom.tag); }
        if (Input.GetKeyDown(KeyCode.P)) { Debug.Log("Previous room: " + previousRoom.name + previousRoom.tag); }
        if (Input.GetKeyDown(KeyCode.Y)) { Debug.Log("teleportCount = " + teleportCount); }
    }
}
