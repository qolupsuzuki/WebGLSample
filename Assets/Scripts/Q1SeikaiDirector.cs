using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//LoadSceneを使うために必要！！

public class Q1SeikaiDirector : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Level02_Q2_Scene");
        }

    }
}
