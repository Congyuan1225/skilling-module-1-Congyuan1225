using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Session 4 homework:
Create a cube prefab that has a script attached to it
Write a change colour coroutine
Create a cube array and change destroy them in play mode using raycasting
 */

public class Session4Homework : MonoBehaviour
{

    public GameObject cube;
    public int numberOfCubes = 5;
    public float spacing = 2.5f;
    private List<GameObject> cubeCopies = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 cubeCopyPosition = new Vector3(i * spacing-5, 1, 1);
            Quaternion cubeCopyRotation = Quaternion.identity;
            GameObject cubeCopy = Instantiate(cube, cubeCopyPosition, cubeCopyRotation);
            Color cubeCopyColor = new Color(255, 255, 255);
            cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
            cubeCopies.Add(cubeCopy);
        }
               

    }

    // Update is called once per frame
    void Update()
    {
        //HOMEWORK: Create a cube array and change destroy them in play mode using raycasting

        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);
        RaycastHit objectInFront;

        for (int i = 0; i < cubeCopies.Count; i++)
        {
            GameObject cubeCopy = cubeCopies[i];
            Color cubeCopyColor = new Color(255, 255, 255);
            cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
        }

               
        if (Input.GetMouseButtonDown(0))
        {
              
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                         
            if (Physics.Raycast(ray, out objectInFront))
            {
                Destroy(objectInFront.transform.gameObject);
                
            }
            

        }

        /* trying to solve the problem
        if (gameObject != null)
        {
            return gameObject[i];

        }
        Problem:
        MissingReferenceException: The object of type 'GameObject' has been destroyed 
        but you are still trying to access it.Your script should either check if it is 
        null or you should not destroy the object.
         */

    }

}
