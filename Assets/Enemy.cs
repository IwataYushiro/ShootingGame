using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //�G�̗̑͗p
    private int enemyHp;

   
    // Start is called before the first frame update
    void Start()
    {
        //�������ɑ̗͂��w��
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //�����̗͂�0�ɂȂ�����
        if(enemyHp<=0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
        }
    }
    //public�̕t���Y��ɒ���
    public void Damage()
    {
        //�G�̗̑͂�1���炷
        enemyHp = enemyHp - 1;
    }
}
