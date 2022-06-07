using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //カメラから見た画面左下の座標を入れる変数
    Vector3 LeftBottom;
    //カメラから見た画面右上の座標を入れる変数
    Vector3 RightTop;

    //子オブジェクトのサイズを入れるために必要
    private float Left_, Right_, Top_, Bottom_;

    // Start is called before the first frame update
    void Start()
    {
        //カメラとプレイヤーの距離を測る(表示画面の西隅を設定するために必要)
       var distance=Vector3.Distance(Camera.main.transform.position, transform.position);

        //スクリーン画面左下の位置を固定
        LeftBottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));

        //スクリーン画面右上の位置を固定
        RightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));
 
    //オブジェクトの数だけループ処理
    foreach(Transform child in gameObject.transform)
        {
            //子オブジェクトの中で一番右の位置にいたなら
            if(child.localPosition.x>=Right_)
            {
                //子オブジェクトのローカルX座標を右端用の変数に代入する
                Right_=child.transform.localPosition.x;
            }
            //子オブジェクトの中で一番左の位置にいたなら
            if (child.localPosition.x <= Left_)
            {
                //子オブジェクトのローカルX座標を左端用の変数に代入する
                Left_ = child.transform.localPosition.x;
            }
            //子オブジェクトの中で一番上の位置にいたなら
            if (child.localPosition.z >= Top_)
            {
                //子オブジェクトのローカルZ座標を上端用の変数に代入する
                Top_ = child.transform.localPosition.z;
            }
            //子オブジェクトの中で一番下の位置にいたなら
            if (child.localPosition.z <= Bottom_)
            {
                //子オブジェクトのローカルZ座標を下端用の変数に代入する
                Bottom_ = child.transform.localPosition.z;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
         //プレイヤーのワールド座標を取得
        Vector3 pos=transform.position;

        //右矢印キーが入力されたとき
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //右方向に0.03動く
            pos.x += 0.03f;
        }

        //左矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //左方向に0.03動く
            pos.x -= 0.03f;
        }

        //上矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //上方向に0.03動く
            pos.z += 0.03f;
        }

        //下矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //下方向に0.03動く
            pos.z -= 0.03f;
        }
        transform.position = new Vector3
            (Mathf.Clamp(pos.x, LeftBottom.x + transform.localScale.x - Left_, RightTop.x - transform.localScale.x - Right_),
            pos.y,
            Mathf.Clamp(pos.z, LeftBottom.z + transform.localScale.z - Bottom_, RightTop.z - transform.localScale.z - Top_));
    }
}
