using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowers : MonoBehaviour
{
    public GameObject fireSpellPrefab;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(fireSpellPrefab, new Vector2(0, 0), Quaternion.identity);
        }
    }
}
