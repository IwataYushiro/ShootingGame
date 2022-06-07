using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //“G‚Ì‘Ì—Í—p
    private int enemyHp;

   
    // Start is called before the first frame update
    void Start()
    {
        //¶¬‚É‘Ì—Í‚ğw’è
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //‚à‚µ‘Ì—Í‚ª0‚É‚È‚Á‚½‚ç
        if(enemyHp<=0)
        {
            //©•ª‚ÅÁ‚¦‚é
            Destroy(this.gameObject);
        }
    }
    //public‚Ì•t‚¯–Y‚ê‚É’ˆÓ
    public void Damage()
    {
        //“G‚Ì‘Ì—Í‚ğ1Œ¸‚ç‚·
        enemyHp = enemyHp - 1;
    }
}
