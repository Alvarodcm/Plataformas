using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrownDetector_Raycast : MonoBehaviour
{
    
    public bool grounded;
    public float lenght = 1;
    public LayerMask mask;

    public List<Vector3> originPoint;

    // Update is called once per frame
    void Update()
    {
        grounded = false;
        for (int i = 0; i < originPoint.Count; i++)
        {
            Debug.DrawRay(transform.position + originPoint[i], Vector3.down * lenght, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position + originPoint[i], Vector3.down, lenght, mask);
            if (hit.collider != null)


            {
                if (hit.collider.tag == "plataformaMovil")
                {
                    transform.parent = hit.transform;
                }

                Debug.DrawRay(transform.position + originPoint[i], Vector3.down * hit.distance, Color.green);
                grounded = true;
            }
            

        
        }
        if (!grounded)
        {
            transform.parent = null;
        }
        

       

    }   
   
}
