using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballcontroller : MonoBehaviour
{
    [SerializeField] private string newLevel;
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
            SceneManager.LoadScene(newLevel);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag=="limits")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(this.gameObject);
        }
    }
}
