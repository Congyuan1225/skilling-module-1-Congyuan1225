using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CA_Cube_Class_2 : MonoBehaviour {

    // Variables
    private int state = 0;
    private int futureState = 0;
    public bool computed = false;
        
    public int age = 0;
    public bool updateState = true;

    private Material material;

    public Color startColor;
    public Color endColor;
    public float colorDuration;

    void Start()
    {

        material = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update () {
        if(computed == false){
            state = futureState;
            DisplayCube();
        } else {
            DisplayCube();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ChangeColor(material));
        }
    }

    // Behaviours (Methods)

    IEnumerator ChangeColor(Material toChange)
    {
        float t = 0;

        while (t < colorDuration)
        {
            t += Time.deltaTime;
            toChange.color = Color.Lerp(startColor, endColor, t / colorDuration);
            yield return null;
        }
    }

    // Sets the cube as being computed 
    public void SetComputed(bool _computed){
        computed = _computed;
    }

    // Display behaviour
    void DisplayCube(){
        MaterialPropertyBlock props = new MaterialPropertyBlock();
        MeshRenderer renderer;
        // If the cell is dead do not show it
        if(state == 0){
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        } else {
            // Else show the cell
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            StartCoroutine(ChangeColor(material));
            //props.SetColor("_Color", Color.black);

            renderer = gameObject.GetComponent<MeshRenderer>();
            renderer.SetPropertyBlock(props);
        }
    }

    // Method to set the futureState variable
    public void SetFutureState(int _futureState){
        futureState = _futureState;
    }

    // Methods to set the current state variable
    public void SetState(int _state){
        state = _state;
    }

    // Help method to retreive what the current state is
    public int GetState(){
        return state;
    }

    public void DisplayAge(Color _cubeColor)
    {
        // Set the material property block to a colur assigned by the evaluator
        MaterialPropertyBlock props = new MaterialPropertyBlock();
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        props.SetColor("_Color", _cubeColor);

        // Update the colour of the mesh
        MeshRenderer renderer;
        renderer = gameObject.GetComponent<MeshRenderer>();
        renderer.SetPropertyBlock(props);
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int _age)
    {
        age = _age;
    }

    // Help method to retrive what will be the future state
    public int GetFutureState(){
        return futureState;
    }

    // Method to rotate the cube
    public void RotateCube(){
        gameObject.transform.Rotate(new Vector3(0, 45, 0));
    }

}
