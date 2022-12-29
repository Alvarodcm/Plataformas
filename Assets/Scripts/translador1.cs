using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class translador1 : MonoBehaviour
{
    public int fase = 2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
           
            SceneManager.LoadScene(fase);

            
                
           
        }
    }
}
