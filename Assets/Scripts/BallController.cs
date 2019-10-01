using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // 重力の値を入れておく変数
    const float Gravity = 9.81f;
    // 重力の強さを変更するための変数
    public float gravityscale = 1.0f;
    // スコアを入れる変数
    public int Score = 0;

    void Update()
    {
        // 変数vectorを定義と初期化
        Vector3 vector = new Vector3();
        // vectorのxの値に左右の入力を代入
        vector.x = Input.GetAxis("Horizontal");
        // vectorのzの値に上下の入力を代入
        vector.z = Input.GetAxis("Vertical");
        // vecrorのyの値に-1.0を代入(重力が下向きのため)
        vector.y = -1.0f;

        // ゲーム内の重力の向きを入力の値によって変化させる
        Physics.gravity = Gravity * vector.normalized * gravityscale;
    }

    // このオブジェクトにオブジェクトが当たった時に実行(変数otherには当たったオブジェクトが代入される)
    private void OnTriggerEnter(Collider other)
    {
        // 当たったオブジェクトを消去する
        Destroy(other.gameObject);
        // スコアの値を100増やす
        Score += 100;
    }
}
