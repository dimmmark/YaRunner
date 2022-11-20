using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBihaviour playerBihaviour = other.attachedRigidbody.GetComponent<PlayerBihaviour>();
        if (playerBihaviour)
        {
            playerBihaviour.StartFinishBehavior();
        }
    }
}
