using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    //"static" means it can be accessed anywhere.
    public static CheckpointController instance; 
    public Vector3 lastCheckPointPos;

    //"Awake()" is called before "Start()".
    //It is used to do things before the game starts.
    private void Awake()
    {
        //Checking if any game objects that have the "CheckpointController" script has not set the instance variable at the start.
        if (instance == null)
        {
            //If any have not, then it sets it here.
            instance = this;

            //This means that when there is another scene, it will transfer over the same, and will not destroy.
            DontDestroyOnLoad(instance);
        }
        else
        {
            //If the instance is set at the start already, it will destroy itself.
            Destroy(gameObject);
        }
    }
}
