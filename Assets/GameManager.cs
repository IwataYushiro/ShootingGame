using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //敵の数を数える用の変数
    private GameObject[] enemy;

    //パネル登録
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        //パネルを隠す
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //シーンに存在しているEnemyタグを持っているオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        //シーンに1匹もEnemyがいなくなったら
        if(enemy.Length==0)
        {
            //パネルを表示
            panel.SetActive(true);
        }
    }
}
