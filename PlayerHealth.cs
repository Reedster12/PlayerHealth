using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;
    public Material playerBeingHealed;
    public Material normalPlayerColor;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HealingArea")
        {
            GetComponent<Renderer>().material = playerBeingHealed;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "HealingArea")
        {
            playerHealth += 0.01f * Time.deltaTime;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "HealingArea")
        {
            GetComponent<Renderer>().material = normalPlayerColor;
        }
    }
}
