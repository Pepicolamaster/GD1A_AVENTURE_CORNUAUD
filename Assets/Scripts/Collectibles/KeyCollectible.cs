using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollectible : MonoBehaviour
{
    public PlayerController getKey;
    public bool playerHasKey;

    private void Awake()
    {
        getKey = GameObject.FindObjectOfType<PlayerController>();
        playerHasKey = getKey.hasKey;

        if (playerHasKey == true)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<PlayerController>().GetKey();
                Destroy(this.gameObject);
            }
    }
}
