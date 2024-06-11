using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBallGenerator : MonoBehaviour
{
    public GameObject PurpleBallPrefab;
    float span = 6.0f;
    float delta = 0;

    void Update()
    {
       this.delta += Time.deltaTime;
       if(this.delta > this.span) 
       {
        this.delta = 0;
        GameObject go = Instantiate(PurpleBallPrefab);
        float px = Random.Range(-6.0f,7.0f);
        go.transform.position = new Vector3(px,7,0);
       Debug.Log(px);
       
       }
    }
}