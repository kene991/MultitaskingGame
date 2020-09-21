using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{

    /// <summary>
    /// Source: http://mywebspace.quinnipiac.edu/jbwarren/410/resource-06-car-demo.html
    /// </summary>
    /// 
    public float speed;
    public Vector3 direction;
    public bool fast;

    void FixedUpdate()
    {
        // face direction
        transform.rotation = Quaternion.LookRotation(direction);

        // set speed
        GetComponent<Rigidbody>().velocity = direction.normalized * speed * Time.deltaTime;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection;
    }

     public void OnMouseDown()
     {
         Debug.Log("Car Click!");
        fast = !fast;
         if (fast)
      {
          SetSpeed(300f);
     }
     else
     {
          SetSpeed(100f);
      }
    }

    void OnBecameInvisible()
    {
       Destroy(gameObject);
     }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "destroy")
        {
            Destroy(gameObject);
        }
    }
}
