using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Manager: MonoBehaviour
{
    public void PushNextButton(){
        SceneManager.LoadScene("Level01Scene");

    }
}
