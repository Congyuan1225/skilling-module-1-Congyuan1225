using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework_2 : MonoBehaviour
{

    private Material material;
      
    public Color startColor;
    public Color endColor;
    public float colorDuration; // duration in seconds
  
    // Start is called before the first frame update
    void Start()
    {

        material = GetComponent<Renderer>().material;

        

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ChangeColor(material));
        }
    }



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
    
}
        


