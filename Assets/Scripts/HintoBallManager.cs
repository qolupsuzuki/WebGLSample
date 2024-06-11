using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//LoadSceneを使うために必要

public class HintoBallManager : MonoBehaviour
{
    private GameObject player; // playerフィールドを定義

    // Start is called before the first frame update
    void Start()
    {
    this.player=GameObject.Find("akitadog");  
    }

    // Update is called once per frame
    void Update()
    {
        //当たり判定
        Vector2 p1=transform.position; //ヒントの中心座標
        Vector2 p2=this.player.transform.position; //プレイヤの中心座標
        Vector2 dir=p1-p2;
        float d=dir.magnitude;
        float r1=0.5f; //ヒントの半径
        float r2=1.0f; //プレイヤの半径

        if(d<r1+r2)
        {
            //ヒント画面に遷移
            SceneManager.LoadScene("HintQ1Scene");

        }
    }
    //ボールが何かのコリジョンに衝突
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == "OutArea"){ 
            //「アウトエリア」に衝突,
            //ゲームマネージャーを取得
            GameObject gameManager = GameObject.Find("GameManager");
            //リトライ
            gameManager.GetComponent<GameManager>().PushRetryButton();
        }
    }
    //ボールが何かのトリガーに衝突
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "ClearArea"){ 
            //「クリアーエリア」に入った
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().StageClear();
        }
    }


} 