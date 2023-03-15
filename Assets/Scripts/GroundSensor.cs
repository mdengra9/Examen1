using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool Grounded;
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            Grounded = true;    
        }
    }

    // Update is called once per frame
    void OnTriggerStay2D (Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            Grounded = true;    
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            Grounded = false;    
        }
    }
}
