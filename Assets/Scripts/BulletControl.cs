using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class BulletControl : MonoBehaviour
{


    Rigidbody2D bulletRB;
    public float bulletSpeed = 10f;
    public float bulletlife = 1.0f;
   
    public float posicion = 0.0f;
    //public GameObject particulaEnemigo;

    void Start()
    {
        
        posicion = MovimientoHorizontal.move.cannon;
        bulletRB = GetComponent<Rigidbody2D>();
        
        if (posicion == 1.0f) 
        {
            Vector2 fuerza = new Vector2(1.0f, 0.0f);
            bulletRB.AddForce(fuerza * bulletSpeed);
        
        }
        else
        {
            Vector2 fuerza = new Vector2(-1.0f, 0.0f);
            bulletRB.AddForce(fuerza * bulletSpeed);
        }
        
       

    }


    //public void destroyBullet()
    //{ 
    //    GameObject particulaEnemigos = Instantiate(particulaEnemigo, transform.position, transform.rotation);
    //    Destroy(particulaEnemigos);
    //    Destroy(gameObject);

    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            
            Destroy(gameObject);

        }




    }
}
