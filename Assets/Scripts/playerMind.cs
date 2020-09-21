using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMind : MonoBehaviour
{
    /// <summary>
    /// Source: https://www.youtube.com/watch?v=8oYUSep1qXo
    /// The video explained to me how to create essentaily a brain for the amount of players or objects that we can control at once.
    /// We first create a gameobject array that holds all our objects on scene then we add a public void that will help change the player in the player Swap script.
    /// </summary>

    public GameObject[] pedestrians;
    [SerializeField]

    GameObject currentPedestrian;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pedestrians.Length; i++)
        {
            pedestrians[i].GetComponent<Player>().enabled = false;
        }

        currentPedestrian = pedestrians[0];
    }

    public void ChangePlayer(GameObject pedestrian)
    {
        currentPedestrian.GetComponent<Player>().enabled = false;
        currentPedestrian = pedestrian;
    }
}
