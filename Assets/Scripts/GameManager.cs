using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int StageNo;            //ステージナンバー

    public bool isBallMoving;      //ボール移動中か否か

    public GameObject ballPrefab;  //ボールプレハブ
    public GameObject ball;        //ボールオブジェクト
    
    public GameObject goButton;    //ボタン：ゲーム開始
    public GameObject retryButton; //ボタン：リトライ
    public GameObject clearText;   //ボタン：クリア

    public AudioClip clearSE;       //効果音：クリア
    private AudioSource audioSource;//オーディオソース
    

    // Start is called before the first frame update
    void Start()
    {
       
        retryButton.SetActive(false); //リトライボタンを非表示
        isBallMoving = false;         //ボールは「移動中ではない」

        //オーディオソースを取得
        audioSource = gameObject.GetComponent<AudioSource>();

    }
    
    //ステージクリア処理
    public void StageClear(){
        audioSource.PlayOneShot(clearSE); //クリア音再生
        clearText.SetActive(true);        //クリア表示
        retryButton.SetActive(false);     //リトライボタン非表示
    }



    // Update is called once per frame
    void Update()
    {
         
    }
    //GOボタンを押した
    public void PushGoButton(){

    // ランダムな開始位置の範囲を定義
    float randomX = Random.Range(-5.0f, 5.0f); // 必要に応じて範囲を調整

    // ボールの位置をランダムな値に設定
    ball.transform.position = new Vector3(randomX, ball.transform.position.y, ball.transform.position.z);

        //ボールの重力を有効化
        Rigidbody2D rd = ball.GetComponent<Rigidbody2D>();
        rd.isKinematic = false;

        retryButton.SetActive(true);    //リトライボタンを表示
        goButton.SetActive(false);      //GOボタンを非表示
        isBallMoving = true;            //ボールは「移動中」

     

    }

    //リトライボタンを押した
    public void PushRetryButton(){
        Destroy(ball);                  //ボールオブジェクトを削除

        //プレハブより新しいボールオブジェクトを作成
        ball = (GameObject)Instantiate(ballPrefab);

        retryButton.SetActive(false);   //リトライボタンを非表示
        goButton.SetActive(true);       //GOボタンを表示
        isBallMoving = false;           //ボールは「移動中ではない」
    }

    //バックボタンを押した
    public void PushBackButton(){
    }
}