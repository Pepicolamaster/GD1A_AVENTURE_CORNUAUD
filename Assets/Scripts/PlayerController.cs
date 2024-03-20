using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //movement directionnel
    private float horizontalInput;
    private float verticalInput;
    public float speed;
    public int coinCount = 0;

    //r�f�rences

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);
        verticalInput = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);
        /*transform.Transform = bouger les coordonn�es du joueur sans physique, donc sans RB2D.
        Time.deltaTime permet de cnvertir la vitesse en temps r�el*/
    }

    public void AddCoin()
    {
        coinCount += 1;
    }
}
