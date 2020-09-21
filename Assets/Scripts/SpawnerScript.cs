using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    /// <summary>
    /// Source: http://mywebspace.quinnipiac.edu/jbwarren/410/resource-06-car-demo.html
    /// </summary>
    /// 

    public GameObject carPrefab;

    void Start()
    {
        CreateNewObject();
    }

    void CreateNewObject()
    {
        int whichObject = Random.Range(0, 1);

        if (whichObject == 0)
        {
            GameObject newCar = (GameObject)Instantiate(carPrefab);
            newCar.transform.position = transform.position;
            newCar.GetComponent<CarScript>().SetDirection(transform.forward);
        }

        float randomTime = Random.Range(2f, 4f);
        Invoke("CreateNewObject", randomTime);
    }
}
