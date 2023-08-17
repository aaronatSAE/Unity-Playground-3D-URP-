using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISquadCoordinator : MonoBehaviour
{
    [SerializeField] private NavMeshAgent[] agentsInSquad;
    [SerializeField] private Transform[] agentPositions;

    void Update()
    {
        for (int i = 0; i < agentsInSquad.Length; i++)
        {
            if (agentsInSquad[i].GetComponent<AIBrain>().currentTactics == AIBrain.Tactics.SquadTactics)
            {
                agentsInSquad[i].SetDestination(agentPositions[i].position);
            }
        }
    }
}
