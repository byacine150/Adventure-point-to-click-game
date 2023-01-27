using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Deplacement : MonoBehaviour
{
    public NavMeshAgent playerNavMeshAgent;
    public Camera playerCamera;
    public bool WalkForward;
    public Animator playerAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {

            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;

            if (Physics.Raycast(myRay, out myRaycastHit))
            {
                playerNavMeshAgent.SetDestination(myRaycastHit.point);

            }

        }
       

        if (playerNavMeshAgent.remainingDistance <= playerNavMeshAgent.stoppingDistance)
        {
            WalkForward = false;
        }
        else 
        {
            WalkForward = true;
        }
       
    }
}
