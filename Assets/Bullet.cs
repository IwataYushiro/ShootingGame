using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos=transform.position;

        //上に向かって真っすぐ飛ぶ
        pos.z += 0.05f;
        //弾の移動
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        //一定距離進んだら消滅する
        if (pos.z >= 20)
        {
            Destroy(this.gameObject);
        }
    }

    //当たり判定用関数
   void OnTriggerEnter(Collider other)
    {
        //もし当たったオブジェクトのタグがenemyだったら
        if(other.gameObject.tag == "Enemy")
        {
            //当たったオブジェクトのEnemyスクリプトを呼び出してDamage関数を実行させる
            other.GetComponent<Enemy>().Damage();
        }
    }
}
