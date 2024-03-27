using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //movement directionnel
    private float horizontalInput;
    private float verticalInput;
    public float speed;
    
    public int coinCount = 0;
    public bool hasKey = false;

    public int previousSceneIndex;
    //références

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);
        verticalInput = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);
        /*transform.Translate = bouger les coordonnées du joueur sans physique, donc sans RB2D.
        Time.deltaTime permet de cnvertir la vitesse en temps réel*/
    }
    public void AddCoin()
    {
        coinCount += 1;
    }

    public void GetKey()
    {
        hasKey = true;
    }

    public void UseKey()
    {
        hasKey = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SceneChange"))
        {
            previousSceneIndex = SceneManager.GetActiveScene().buildIndex;

        }
    }
}
