using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoshtNavigate : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject[] targets;

    private int targetIndex = 0;

    private bool increasing = true;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(targets[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
    }

    private void Patrol()
    {
        if (agent.remainingDistance == 0)
        {
            if (targetIndex == targets.Length - 1)
            {
                increasing = false;
            }
            if (targetIndex == 0)
            {
                increasing = true;
            }
            if (increasing)
            {
                targetIndex++;
            }
            else
            {
                targetIndex--;
            }
            agent.SetDestination(targets[targetIndex].transform.position);

        }
    }
}
