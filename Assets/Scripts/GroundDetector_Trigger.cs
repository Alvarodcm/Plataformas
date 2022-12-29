using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector_Trigger : MonoBehaviour

{
    //Detecta si esta en el suelo
    public bool grounded;

    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded=false;

    }
}
