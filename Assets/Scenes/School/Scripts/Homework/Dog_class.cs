using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace dogClassOne
{
    //Class
    class basicInformation
    {
        
        string name;
        float height;       
             
        public basicInformation(string _name, float _height)
        {
            name = _name;
            height = _height;
        }
        public string GetName()
        {
            return name;
        }
        public float GetHeight()
        {
            return height;
        }
        public void Walking()
        {
            // Action here
        }
        public void Running()
        {
            // Action here
        }
        public void Jumping()
        {
            // Action here
        }
    }



}

