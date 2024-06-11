using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   

    void Start()
    {
    Application.targetFrameRate = 60; //フレームレートを60に固定する  
    }

    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    }

   
}