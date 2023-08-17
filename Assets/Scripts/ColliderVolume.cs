using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderVolume : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER");
    }
}
