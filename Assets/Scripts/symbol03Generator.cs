using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class symbol03Generator : MonoBehaviour
{
    public GameObject symbol03Prefab;
    float span = 6.0f;
    float delta = 0;

    void Update()
    {
       this.delta += Time.deltaTime;
       if(this.delta > this.span) 
       {
        this.delta = 0;
        GameObject go = Instantiate(symbol03Prefab);
        float px = Random.Range(-6.0f,7.0f);
        go.transform.position = new Vector3(px,7,0);
       }
    }
}
