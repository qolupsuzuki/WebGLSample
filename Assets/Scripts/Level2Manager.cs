using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Manager: MonoBehaviour
{
    public void PushNextButton(){
        SceneManager.LoadScene("Level02Scene");

    }
}