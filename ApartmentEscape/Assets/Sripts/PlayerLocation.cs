using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    public GameManager gm;

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
            //gm.isTeleporting = false;
            //Debug.Log("isTeleporting = " + gm.isTeleporting);
        }
    }
}
