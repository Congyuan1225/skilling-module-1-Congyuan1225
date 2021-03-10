using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework_cube : MonoBehaviour
{
    /* HOMEWORK:
    Create a cube and move it across the screen
    Add a script to a game object
    */

        
    public float speed = 0.05f;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed);
    }
}
