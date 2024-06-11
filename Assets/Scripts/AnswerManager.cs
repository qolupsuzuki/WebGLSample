using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnswerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PushAge70Button(){
        SceneManager.LoadScene("Q1ZannenScene");
    }

    public void PushAge75Button(){
        SceneManager.LoadScene("Q1ZannenScene");
    }

    public void PushAge65Button(){
        SceneManager.LoadScene("Q1SeikaiScene");
    }

    public void PushAgefriendButton(){
        SceneManager.LoadScene("");
    }

    public void PushAgepartnerButton(){
        SceneManager.LoadScene("");
    }

    public void PushAgecompanyButton(){
        SceneManager.LoadScene("");
    }
}

