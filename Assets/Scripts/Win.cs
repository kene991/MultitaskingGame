using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

    public int totalPedestrians;

    void Start()
    {
        totalPedestrians = 0; 
    }

    void Update()
    {
        if (totalPedestrians == 6)
        {
            Debug.Log("You Win!");
            SceneManager.LoadScene("WinScreen");
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "white")
        {
            totalPedestrians += 1;
        }

        if (other.gameObject.tag == "blue")
        {
            totalPedestrians += 1;
        }

        if (other.gameObject.tag == "green")
        {
            totalPedestrians += 1;
        }

        if (other.gameObject.tag == "red")
        {
            totalPedestrians += 1;
        }

        if (other.gameObject.tag == "yellow")
        {
            totalPedestrians += 1;
        }

        if (other.gameObject.tag == "purple")
        {
            totalPedestrians += 1;
        }
    }
}
