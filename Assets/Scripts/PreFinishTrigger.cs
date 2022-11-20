using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBihaviour playerBihaviour = other.attachedRigidbody.GetComponent<PlayerBihaviour>();
        if(playerBihaviour)
        {
            playerBihaviour.StartPreFinishBehavior();   
        }
    }
}
