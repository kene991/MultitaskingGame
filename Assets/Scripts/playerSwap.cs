using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerSwap : MonoBehaviour
{
    /// <summary>
    /// Sources: https://www.youtube.com/watch?v=8oYUSep1qXo
    /// In this script you are essentially disabling the movement script from one player to another when you click on them. 
    /// You can click on as many players you would like too. (Make sure they all have kinamatic rigidbodies for OnMouseDown()
    /// </summary>
    /// 
    public playerMind mind;

    // Update is called once per frame
    void OnMouseDown()
    {
            mind.ChangePlayer(this.gameObject);
            GetComponent<Player>().enabled = true;
            Debug.Log("Name"); 
    }
}
