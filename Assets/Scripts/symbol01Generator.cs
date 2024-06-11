using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class symbol01Generator : MonoBehaviour
{
    public GameObject symbol01Prefab;
    float span = 5.0f;
    float delta = 0;

    void Update()
    {
       this.delta += Time.deltaTime;
       if(this.delta > this.span) 
       {
        this.delta = 0;
        GameObject go = Instantiate(symbol01Prefab);
        int px = Random.Range(-6,7);
        go.transform.position = new Vector3(px,7,0);
       }
    }
}