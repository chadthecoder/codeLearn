using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobScript : MonoBehaviour
{  
    public Rigidbody2D bobRidgidbody;
    public float bounceStrength = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bobRidgidbody.velocity = Vector2.up * bounceStrength;
        }
    }
}
