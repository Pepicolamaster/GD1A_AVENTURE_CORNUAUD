using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointRef : MonoBehaviour
{
    public int spawnPointRef;
    public PlayerController getIndex;
    public int PreviousSceneIndex;

    private void Awake()
    {
        getIndex = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        PreviousSceneIndex = getIndex.previousSceneIndex;
        if (PreviousSceneIndex == spawnPointRef)
        {
            GameObject.FindWithTag("Player").transform.position = transform.position;
        }
    }
}