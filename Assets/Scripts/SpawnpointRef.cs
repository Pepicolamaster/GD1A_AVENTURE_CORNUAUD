using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointRef : MonoBehaviour
{
    public int spawnPointRef;
    public PlayerController getIndex;
    public int sceneIndex;

    private void Awake()
    {
        getIndex = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        sceneIndex = getIndex.previousSceneIndex;
        if (sceneIndex == spawnPointRef)
        {
            GameObject.FindWithTag("Player").transform.position = transform.position;
        }
    }
}