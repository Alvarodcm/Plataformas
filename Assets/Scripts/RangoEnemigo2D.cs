using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemigo2D : MonoBehaviour
{
    public Animator ani;
    public Enemy enemigo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") ;
        {
            ani.SetBool("walk", false);
            //ani.SetBool("Run", false);
            ani.SetBool("hit", true);
            enemigo.atacando = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
