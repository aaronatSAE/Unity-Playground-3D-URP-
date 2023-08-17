using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAISquadCoordinator : MonoBehaviour
{
    // Handles AI squad movement
    // If the AI is moving as a squad,
    // set destinations to each squad position

    [SerializeField] private List<SimpleAIBrain> squadMembers;
    [SerializeField] private Transform[] squadPositions;

    void Update()
    {
        // Cycle through all squad members
        // and make them move to squad positions!
        for (int i = 0; i < squadMembers.Count; i++)
        {
            Debug.Log("SQUAD 1111111111 ");
            if (squadMembers[i].currentTactics == SimpleAIBrain.Tactics.SquadPattern)
            {
                Debug.Log("SQUAD 2");
                squadMembers[i].agent.SetDestination(squadPositions[i].position);
            }
        }
    }
}
