using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCheckpoint : MonoBehaviour
{
    private CheckpointController _checkpointController;

    private void OnTriggerEnter(Collider other)
    {
        //checking if the player object triggers the checkpoint collider.
        if (other.CompareTag("Player"))
        {
            //The last checkpoint position is changed to where that collided checkpoint position is.
            CheckpointController.instance.lastCheckPointPos = transform.position;
        }
    }
}
