using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovimientoHorizontal : MonoBehaviour
{

    public Transform player;
    public GameObject kame;
    public GameObject mano;
    public static MovimientoHorizontal move;
    public float cannon = 0.0f;


    public float speed = 0.5f;
    GrownDetector_Raycast ground;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        ground = GetComponent<GrownDetector_Raycast>();
        anim = GetComponent<Animator>();
        player =GetComponent<Transform>();
        move = this;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(horizontal * Time.deltaTime * speed, 0);
        anim.SetBool("grounded", ground.grounded);
        anim.SetBool("moving", horizontal !=0);
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
         cannon = transform.localScale.x;
          

        //mirar el efector en el addcomponent
        PlayerShooting();
    }
    public void PlayerShooting() 
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject kamekameha = Instantiate(kame, mano.transform.position, transform.rotation);
            Destroy(kamekameha, 0.80f);
            anim.SetBool("Ataque", true);


        }
        else 
        {
            anim.SetBool("Ataque", false);
        }
    }

   

    
}

 