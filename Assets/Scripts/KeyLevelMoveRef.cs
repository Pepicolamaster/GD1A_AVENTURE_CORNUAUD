using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyLevelMoveRef : MonoBehaviour
{
    public int sceneBuildIndex;
    public PlayerController getKey;
    public bool playerHasKey;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            getKey = GameObject.FindObjectOfType<PlayerController>();
            playerHasKey = getKey.hasKey;

            if (playerHasKey == true)
            {
                SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
            }
        }
    }
}