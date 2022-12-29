using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
    
{
    public int fase = 1;
    public void LoadScene(string fase)
    {
        SceneManager.LoadScene("controles");
    }
    public void ExitGame()
    {
        Debug.Log("Estoy Saliendo");
        Application.Quit();
    
    
    }
   
}
