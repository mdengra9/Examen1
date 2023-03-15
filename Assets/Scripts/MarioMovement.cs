using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{
public float playerSpeed = 5.5f;
public float jumpforce = 7f;

private SpriteRenderer spriteRenderer;
private Rigidbody2D rBody;
private GroundSensor sensor;

float horizontal;

    // Start is called before the first frame update
    void Start()
    {
      sensor = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
      rBody = GetComponent<Rigidbody2D>();
      spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         horizontal = Input.GetAxis ("Horizontal");
        
        if (horizontal < 0)
        {
            spriteRenderer.flipX = true;
        }

        else if (horizontal > 0)
        {
            spriteRenderer.flipX = false;
        }

        if (Input.GetButtonDown ("Jump") && sensor.Grounded)
        {
            rBody.AddForce (Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate() 
    {
       rBody.velocity = new Vector2 (horizontal * playerSpeed, rBody.velocity.y); 
    }
}
