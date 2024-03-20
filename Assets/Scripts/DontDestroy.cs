using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
