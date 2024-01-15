using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Transform destination;
    public GameObject[] Triggers = new GameObject[5];
    public Transform[] Destinations = new Transform[5];
    //public List<GameObject> Triggers = new List<GameObject>();

    //void ondrawgizmos()
    //{
    //    gizmos.color = color.white;
    //    gizmos.drawwiresphere(destination.position, 0.4f);
    //    var direction = destination.transformdirection(vector3.forward);
    //    gizmos.drawray(destination.position, direction);
    //}

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
            player.Teleport(destination.position);
        }
    }

    void RandomTeleport()
    {

    }
    
}
