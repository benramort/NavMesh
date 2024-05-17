using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavigate : MonoBehaviour
{
    Camera cam;

    [SerializeField] private string nombreSuelo;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == nombreSuelo || hit.collider.gameObject.name == "Platform" || hit.collider.gameObject.name == "Ring")
                {
                    Debug.Log("Hola");
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}
