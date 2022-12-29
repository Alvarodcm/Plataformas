using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    int numeroBola = 0;
    public int namecnoche = 2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ball") 
        {
            Debug.Log("Bola recogida");
            collision.gameObject.SetActive(false);
            numeroBola++;
            Debug.Log(numeroBola);
            


            if (numeroBola == 7)
            {
                Debug.Log("logrodesbloqueado");
                SceneManager.LoadScene(namecnoche);
            }
                
        }
    }

}
