using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    void Update()
    {
        //Checking if player inputs the "L" key. This is just to test the checkpoint system.
        //It should really only send the player to the checkpoint when the player dies.
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Transforming the game object that this script is attached to, to the position of the last check point position.
            transform.position = CheckpointController.instance.lastCheckPointPos;
        }
    }
}
