using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    // ゲームオブジェクトのコインを入れる変数
    public GameObject coin;
    // クリア表示をするためのテキストを入れる変数
    public Text text;

    // このスクリプトがアタッチされているオブジェクトが現れると同時に実行される関数
    void Start()
    {
        // 2~6(6は含まない)の間の整数を変数numに代入
        int num = Random.Range(2, 6);

        // ゲームオブジェクトを入れる並列変数を定義と初期化
        GameObject[] g = new GameObject[num];

        //numの回数だけ{}内の処理を実行
        for (int i = 0; i < num; i++)
        {
            // コインをVector3(Random.Range(-4f, 4f), 0.6f, Random.Range(-4f, 4f)にインスタンスする
            g[i] = (GameObject)Instantiate(coin, new Vector3(Random.Range(-4f, 4f), 0.6f, Random.Range(-4f, 4f)), Quaternion.identity);
            g[i].transform.parent = transform;
        }
    }

    // 毎フレーム呼び出される関数
    void Update()
    {
        // このスクリプトがアタッチされているオブジェクトの子の個数が0であるとき実行
        if (this.transform.childCount == 0)
        {
            // テキストを表示
            text.enabled = true;
            // ゲームの時間を止めてポーズする
            Time.timeScale = 0;
        }
        // スペースキーを押したときに実行
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ゲームを再開させる
            Time.timeScale = 1;
            // シーンの初期化
            SceneManager.LoadScene("Main");
        }
    }
}
