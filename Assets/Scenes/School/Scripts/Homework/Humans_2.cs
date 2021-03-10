using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC9_2;


public class Humans_2 : MonoBehaviour
{
    // Variables
    Human_class2 octavian, tyson, phil;
    Cyborg octavianCyborg;
    // Start is called before the first frame update
    void Start()
    {
        octavian = new Human_class2("Octavian Gheorghiu", 1.74f);
        tyson = new Human_class2("Tyson Hosmer", 1.82f);
        phil = new Human_class2("Phil", 1.75f);
        octavianCyborg = new Cyborg("CyOc", 1.74f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(octavian.GetName());
        octavian.Walking();
        octavian.WorkOut();
        octavianCyborg.Scan();
    }
}
