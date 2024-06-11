using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButtonManager: MonoBehaviour
{
    public void PushNextButton(){
        SceneManager.LoadScene("LevelSelectScene02");
    }
}

