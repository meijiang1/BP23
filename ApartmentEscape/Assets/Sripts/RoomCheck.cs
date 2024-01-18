using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCheck : MonoBehaviour
{
    public GameManager gm;
    public GameObject[] correctRoom = new GameObject[4];
    public bool[] isRoomCorrect = new bool[4];
    public int correctRoomCount = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    //code in progress, nog niet in scene gezet
    void OnTriggerEnter(Collider other)
    {
        switch (gameObject.tag)
        {
            case "Kitchen":
                isRoomCorrect[0] = true;
                break;
            case "Living":
                isRoomCorrect[1] = true;
                break;
            case "Bathroom":
                isRoomCorrect[2] = true;
                break;
            case "Bedroom":
                isRoomCorrect[3] = true;
                break;
            default:
                Debug.Log("case default, entrance");
                break;
        }
    }

    void CheckRoom()
    {
        
    }
}
