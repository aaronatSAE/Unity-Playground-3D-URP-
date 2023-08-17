using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBrain : MonoBehaviour
{
    public enum Tactics { Undefined, ChasePlayer, FleeFromPlayer, SquadTactics }
    public Tactics currentTactics = Tactics.Undefined;

    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Vector3 lastRememberedPlayerLocation;

    void Update()
    {
        switch (currentTactics)
        {
            case Tactics.Undefined:
                break;
            case Tactics.ChasePlayer:
                break;
            case Tactics.FleeFromPlayer:
                break;
            default:
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            agent.SetDestination(other.transform.position);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        lastRememberedPlayerLocation = other.transform.position;

        if (other.CompareTag("Player"))
        {
            agent.SetDestination(lastRememberedPlayerLocation);
        }
    }
}
