using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    /// Source: https://www.youtube.com/watch?time_continue=132&v=KU2CKBlCAxQ&feature=emb_title
    /// This code was off a tutorial from BlackThornPod. 
    /// It was an easy click to mouse position in 3D that involved creating a Nav Mesh and ground layers for the entire ground.
    /// Then coding a raycast to position for the player to move directly to that specfic position.
    /// For the street Texture: https://cdn.cgbookcase.cloud/file/cgbookcase/textures/downloads/Single_lane_road_clean_01/Single_lane_road_clean_01_4K_Mask.png

    public LayerMask whatCanBeClickedOn;
    private NavMeshAgent myAgent;
    public GameObject loseScreen;
    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        loseScreen.SetActive(false);
        myAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;


            if (Physics.Raycast (myRay, out hitInfo, 100, whatCanBeClickedOn))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            Destroy(this.gameObject);
            loseScreen.SetActive(true);
            manager.SetActive(false);
        }
    }
}
