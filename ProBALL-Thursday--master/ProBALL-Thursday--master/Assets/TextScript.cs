using UnityEngine;
using System.Collections;

public class TextScript : MonoBehaviour 
    {
        public string text = " ";
       
        bool display = false;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter(Collider iCollide)
        {
        if (iCollide.transform.name == "RollerBall")
        {
            display = true;

        }
    


        }
        void OnTriggerExit(Collider uCollide)
        {
            if (uCollide.transform.name == "RollerBall")
            {
                display = false;

            }

        }
        void OnGUI()
        {
            if (display == true)
            {
                GUI.Box(new Rect(0, 50, Screen.width, Screen.height - 250), text + "Be careful of FIRE!");
            }
          
        }
    }

