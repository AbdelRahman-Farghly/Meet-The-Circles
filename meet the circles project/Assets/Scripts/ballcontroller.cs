using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag=="ball")
        {
            Debug.Log("you win");
        }
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag=="limits")
        {
            Debug.Log("you lose");
            Destroy(this.gameObject);
        }
    }
}
