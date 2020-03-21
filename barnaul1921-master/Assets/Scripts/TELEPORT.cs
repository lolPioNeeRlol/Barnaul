using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TELEPORT : MonoBehaviour
{
    public bool D19 = false;
    public bool D21 = false;


    public Camera Camera1;
    public Camera Camera2;

   
    void OnMouseDown ()
    {
        if (D19 )
        {
            Application.LoadLevel("1");
        }
        if (D21)
        {
            Camera1.enabled = false;
            Camera2.enabled = false;
        }
    }
  
}
