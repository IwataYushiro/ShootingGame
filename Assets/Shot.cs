using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //ゲームオブジェクトをインスペクターから参照するための変数
    public GameObject Bullet;
    private float shotInterval = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shotInterval+=Time.deltaTime;
        //GetKey=連射　GetKeyDown=単発 
        if(Input.GetKey(KeyCode.Space)&&shotInterval>=0.2f)
        {
            //弾を生成する
            Instantiate(Bullet, transform.position, Quaternion.identity);
            shotInterval=0;
        }
    }
}
