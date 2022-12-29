using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int lifes_current;
    public int lifes_max;
    public float invencible_time;
    bool invencible;


    public enum DeathMode {Teleport, ReloadScene, Destroy }
    public DeathMode death_mode;
    public Transform respawn;
    Rigidbody2D rb;
    // Animator anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lifes_current = lifes_max; 
    }

    //Ignorar la invencibilidad
    public void Damage(int damage = 1, bool ignoreInvencible = false) 

        
    {
        if (!invencible || ignoreInvencible) // if (invencible == false || ignoreInbencible == true)
        {
            lifes_current -= damage;
            StartCoroutine(invencible_Corutine());
            if (lifes_current <= 0) 
            {
                Death();
            }
        }
    }
    public void vidaExtra(int damage = 1)
    {
        lifes_current += damage;
    }

    public void Death() 
    {

        Debug.Log("He muerto");

        //anim.SetBool("Muerte", true);

        switch (death_mode)
        {
            case DeathMode.Teleport:
                rb.velocity = new Vector2(0, 0);
                transform.position = respawn.position;
                lifes_current = lifes_max;

                break;
            case DeathMode.ReloadScene:

                break;
            case DeathMode.Destroy:
                Destroy(gameObject);
                break;
            default:
                break;
        }


    }
    IEnumerator invencible_Corutine()  
    {
        invencible = true;
        yield return new WaitForSeconds(invencible_time);
        invencible = false;
    }

        

}
