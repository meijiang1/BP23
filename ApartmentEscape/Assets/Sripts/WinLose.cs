using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public GameManager gm;
    public Destinations d;

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
            if (IsAllRoomCorrect())
            {
                SceneManager.LoadScene(2);
                Debug.Log("Player Win!");
            }
            else
            {
                Debug.Log("Player Lose, try again...");
                player.Teleport(d.DefaultDestination.position);
            }
        }
    }

    private bool IsAllRoomCorrect()
    {
        for (int i = 0; i < gm.isRoomCorrect.Length; i++)
        {
            if (gm.isRoomCorrect[i] == false)
            {
                return false;
            }
        }
        return true;
    }

}
