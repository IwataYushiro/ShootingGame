using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //�Q�[���I�u�W�F�N�g���C���X�y�N�^�[����Q�Ƃ��邽�߂̕ϐ�
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
        //GetKey=�A�ˁ@GetKeyDown=�P�� 
        if(Input.GetKey(KeyCode.Space)&&shotInterval>=0.2f)
        {
            //�e�𐶐�����
            Instantiate(Bullet, transform.position, Quaternion.identity);
            shotInterval=0;
        }
    }
}
