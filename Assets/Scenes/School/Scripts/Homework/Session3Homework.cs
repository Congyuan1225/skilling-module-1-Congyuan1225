using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

/*
Session 3 homework:
Create a cube and move it across the screen
Create a cube and change its colour when key is pressed or mouse is pressed
Add a script to a game object
 */

public class Session3Homework : MonoBehaviour
{
    
    //Variables
    public GameObject cube;
    public int numberOfCubes = 5;
    public float spacing = 2.0f;
    private List<GameObject> cubeCopies = new List<GameObject>();
    private int frameCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        /*
        //Debugging
        //communicate between scripy and the editor
        Debug.Log("Message");
        Debug.Log(Time.deltaTime);
        try
        {
            cubeCopies[19].transform.Translate(1, 0, 0); 
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
            
        }*/

        
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 cubeCopyPosition = new Vector3(1 , 1 , i * spacing);
            Quaternion cubeCopyRotation = Quaternion.identity;
            GameObject cubeCopy = Instantiate(cube, cubeCopyPosition, cubeCopyRotation); 
            Color cubeCopyColor = new Color(Random.Range(0.00f, 1.00f), 0, 0);
            cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
            cubeCopies.Add(cubeCopy);
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cubeCopies .Count; i++)
        {
            GameObject cubeCopy = cubeCopies[i];
            Color cubeCopyColor = new Color(255, 0, 0);
            cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
        }
        /*
        // Time since game started
        Debug.Log("Frames since game started" + frameCount);
        frameCount++;

        Debug.Log("Unity counted frame" + Time.frameCount);

        Debug.Log("Unity draws a frame in" + Time.deltaTime + "seconds");

        //Moving things in unity space
        foreach (GameObject cubeCopy in cubeCopies )
        {
            //Translate
            Vector3 moveCopy = new Vector3(0, Random.Range(-1.5f, 1.5f), 0);
            cubeCopy.GetComponent<Transform>().Translate(moveCopy * Time.deltaTime);

            //Rotate
            Vector3 rotateCopy = new Vector3 (0, Random.Range(-90.0f, 90.0f), 0);
            cubeCopy.transform.Rotate(rotateCopy);

            //Scale
            float scaleAmount = Random.Range(0.5f, 2.0f);
            Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            cubeCopy.transform.localScale = scaleCopy;

        }*/
        //input
        //keyboard input
        //HOMEWORK: Create a cube and change its colour when key is pressed or mouse is pressed

        if (Input.GetKey(KeyCode.Space))

        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                Color cubeCopyColor = new Color(0, 255, 0);
                cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
                /*
                float scaleAmount = 2.0f;
                Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
                cubeCopy.transform.localScale = scaleCopy;
                */
            }
        }
        /*      
        //Mouse Input
        if (Input.GetMouseButtonDown(0)) 
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                Color redColor = new Color(1, 0, 0);
                cubeCopy.GetComponent<MeshRenderer>().material.color = redColor;

            }
        }*/
        
    }
}
