using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    [SerializeField] CapsuleController red = null;
    [SerializeField] CapsuleController blue = null;
    [SerializeField] CapsuleController yellow = null;
    [SerializeField] CapsuleController green = null;


    // Update is called once per frame
    void Update()
    {
        bool inputHorizontal = Input.GetButtonDown("Horizontal");
        

        if (Input.GetButtonDown("Horizontal"))
        {
            if(Input.GetAxis("Horizontal") > 0)
            {
                // Droit
                green.GetInput();
            }
            else
            {
                // Gauche
                red.GetInput();
            }
        }

        if (Input.GetButtonDown("Vertical"))
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                // Haut
                blue.GetInput();
            }
            else
            {
                // Bas
                yellow.GetInput();
            }
        }

    }
}
