using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAction : MonoBehaviour
{
    public Doors dr;
    public bool open;
    public Transform Player;

    void Start()
    {
        open = false;
    }

    void OnMouseOver()
    {
        {
            if (Player)
            {
                CheckOpen();
                float dist = Vector3.Distance(Player.position, transform.position);
                if (dist < 15)
                {
                    if (open == false)
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            StartCoroutine(opening());
                        }
                    }
                    else
                    {
                        if (open == true)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                StartCoroutine(closing());
                            }
                        }

                    }

                }
            }

        }

    }

    void CheckOpen()
    {
        switch (gameObject.tag)
        {
            case "Entrance":
                if (dr.isDEKOpen) { open = true; } else { open = false;  }
                break;
            case "Kitchen":
                if (dr.isDKLOpen) { open = true; } else { open = false; }
                break;
            case "Living":
                if (dr.isDLBOpen) { open = true; } else { open = false; }
                break;
            case "Bathroom":
                if (dr.isDBBdOpen) { open = true; } else { open = false; }
                break;
            case "Bedroom":
                if (dr.isDBdLOpen) { open = true; } else { open = false; }
                break;
            default:
                Debug.Log("check tag doors default case");
                break;
        }
    }

    IEnumerator opening()
    {
        print("you are opening the door");
        switch (gameObject.tag)
        {
            case "Entrance":
                foreach (GameObject go in dr.DoorsEK)
                {
                    go.GetComponent<Animator>().Play("Opening");
                }
                dr.isDEKOpen = true;
                break;
            case "Kitchen":
                foreach (GameObject go in dr.DoorsKL)
                {
                    go.GetComponent<Animator>().Play("Opening");
                }
                dr.isDKLOpen = true;
                break;
            case "Living":
                foreach (GameObject go in dr.DoorsLB)
                {
                    go.GetComponent<Animator>().Play("Opening");
                }
                dr.isDLBOpen = true;
                break;
            case "Bathroom":
                foreach (GameObject go in dr.DoorsBBd)
                {
                    go.GetComponent<Animator>().Play("Opening");
                }
                dr.isDBBdOpen = true;
                break;
            case "Bedroom":
                foreach (GameObject go in dr.DoorsBdL)
                {
                    go.GetComponent<Animator>().Play("Opening");
                }
                dr.isDBdLOpen = true;
                break;
            default:
                Debug.Log("check tag doors default case");
                break;
        }
        yield return new WaitForSeconds(.5f);
    }

    IEnumerator closing()
    {
        print("you are closing the door");
        switch (gameObject.tag)
        {
            case "Entrance":
                foreach (GameObject go in dr.DoorsEK)
                {
                    go.GetComponent<Animator>().Play("Closing");
                }
                dr.isDEKOpen = false;
                break;
            case "Kitchen":
                foreach (GameObject go in dr.DoorsKL)
                {
                    go.GetComponent<Animator>().Play("Closing");
                }
                dr.isDKLOpen = false;
                break;
            case "Living":
                foreach (GameObject go in dr.DoorsLB)
                {
                    go.GetComponent<Animator>().Play("Closing");
                }
                dr.isDLBOpen = false;
                break;
            case "Bathroom":
                foreach (GameObject go in dr.DoorsBBd)
                {
                    go.GetComponent<Animator>().Play("Closing");
                }
                dr.isDBBdOpen = false;
                break;
            case "Bedroom":
                foreach (GameObject go in dr.DoorsBdL)
                {
                    go.GetComponent<Animator>().Play("Closing");
                }
                dr.isDBdLOpen = false;
                break;
            default:
                Debug.Log("check tag doors default case");
                break;
        }
        yield return new WaitForSeconds(.5f);
    }


}
