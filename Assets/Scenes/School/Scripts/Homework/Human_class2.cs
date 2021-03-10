// LIBRARIES
using System;

// NAMESPACE
namespace RC9_2
{
    // CLASS
    class Cyborg
    {
        // VARIABLES
        string name;
        float height;

        // CONSTRUCTOR
        public Cyborg(string _name, float _height)
        {
            name = _name;
            height = _height;
        }

        // BEHAVIOURS
        public void Roll()
        {
            // Action here
        }

        public void Scan()
        {
            // Action here
        }
    }
    public class Human_class2
    {
        // VARIABLES
        string name;
        float height;
        string countryOfOrigin;

        // CONSTRUCTOR
        public Human_class2(string _name, float _height)
        {
            name = _name;
            height = _height;
            SetClothing();
        }

        // BEHAVIOURS (Functions)
        public string GetName()
        {
            return name;
        }

        public float GetHeight()
        {
            return height;
        }

        public void SetCountryOfOrigin(string _countryOfOrigin)
        {
            countryOfOrigin = _countryOfOrigin;
        }

        private void Sleep()
        {
            // Actions
            // Brush the teeth
            // Change into PJs
            // Make bed
        }

        public void Walking()
        {
            // Action here
        }

        public void WorkOut()
        {
            // Actions here
        }

        private void SetClothing()
        {
            // Set some cloths for the human
        }
        
    }
}
