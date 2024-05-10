using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Prueba : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject[] targets;

    private int targetIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(targets[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        

        Debug.Log(targetIndex);
        Debug.Log(agent.remainingDistance);
        if (agent.remainingDistance == 0)
        {
            if (targetIndex < targets.Length-1)
            {
                targetIndex++;
            } else
            {
                targetIndex = 0;
            }
            agent.SetDestination(targets[targetIndex].transform.position);

        }
        
    }
}
