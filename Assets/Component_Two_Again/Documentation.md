# Component Package Two - Checkpoint System

## Behaviours
CheckpointController

PlayerPos

RespawnCheckpoint

## CheckpointController
This script is the main controller for the checkpoint system. This should be attached to a "GameManager" object.

Using Awake, the script checks if any game objects that have the "CheckpointController" script have not set the instance variable at the start. If any have not, then they are set here and are set to not destroy on load. This means that when there is another scene to load, it will transfer over the same, and will not destroy. If the instance is set at the start already, it will destroy itself.

## PlayerPos
This script is what transforms the player position to the last checkpoint. This is done by referencing the "CheckpointController" instance. This should be attached to the player object.

This script also checks if player inputs the L key. This is just to test the checkpoint system. It should really only send the player to the checkpoint when the player dies.

## RespawnCheckpoint
This script is checking if the player object has triggered a checkpoint collider. If it has, then the last checkpoint position is changed to where that collided checkpoint position is. This should be attached to the the checkpoint objects.


There are no edit-able variables in this entire component. However, more checkpoints can be created by dragging in the checkpoint prefab into the scene.