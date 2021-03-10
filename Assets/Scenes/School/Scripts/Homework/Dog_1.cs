using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using dogClassOne;


public class Dog_1 : MonoBehaviour
{
    basicInformation beibei, fluffy, niuniu;
    
    // Start is called before the first frame update
    void Start()
    {
        beibei = new basicInformation("Beibei Wang", 0.50f);
        fluffy = new basicInformation("fluffy Cool", 0.74f);
        niuniu = new basicInformation("niuniu Lu", 0.35f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(beibei.GetHeight());
        fluffy.GetName();
        niuniu.GetHeight();
        fluffy.Walking();
    }
}
