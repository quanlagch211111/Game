using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandling : MonoBehaviour
{
    public Canvas myCanvas;
    // Start is called before the first frame update
    void Start()
    {
        myCanvas.enabled = false; // Hide the canvas at the start

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Piano")
        {
            myCanvas.enabled = true; // Show the canvas
        }
    }
}
