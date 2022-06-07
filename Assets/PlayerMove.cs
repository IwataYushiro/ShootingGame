using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //�J�������猩����ʍ����̍��W������ϐ�
    Vector3 LeftBottom;
    //�J�������猩����ʉE��̍��W������ϐ�
    Vector3 RightTop;

    //�q�I�u�W�F�N�g�̃T�C�Y�����邽�߂ɕK�v
    private float Left_, Right_, Top_, Bottom_;

    // Start is called before the first frame update
    void Start()
    {
        //�J�����ƃv���C���[�̋����𑪂�(�\����ʂ̐�����ݒ肷�邽�߂ɕK�v)
       var distance=Vector3.Distance(Camera.main.transform.position, transform.position);

        //�X�N���[����ʍ����̈ʒu���Œ�
        LeftBottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));

        //�X�N���[����ʉE��̈ʒu���Œ�
        RightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));
 
    //�I�u�W�F�N�g�̐��������[�v����
    foreach(Transform child in gameObject.transform)
        {
            //�q�I�u�W�F�N�g�̒��ň�ԉE�̈ʒu�ɂ����Ȃ�
            if(child.localPosition.x>=Right_)
            {
                //�q�I�u�W�F�N�g�̃��[�J��X���W���E�[�p�̕ϐ��ɑ������
                Right_=child.transform.localPosition.x;
            }
            //�q�I�u�W�F�N�g�̒��ň�ԍ��̈ʒu�ɂ����Ȃ�
            if (child.localPosition.x <= Left_)
            {
                //�q�I�u�W�F�N�g�̃��[�J��X���W�����[�p�̕ϐ��ɑ������
                Left_ = child.transform.localPosition.x;
            }
            //�q�I�u�W�F�N�g�̒��ň�ԏ�̈ʒu�ɂ����Ȃ�
            if (child.localPosition.z >= Top_)
            {
                //�q�I�u�W�F�N�g�̃��[�J��Z���W����[�p�̕ϐ��ɑ������
                Top_ = child.transform.localPosition.z;
            }
            //�q�I�u�W�F�N�g�̒��ň�ԉ��̈ʒu�ɂ����Ȃ�
            if (child.localPosition.z <= Bottom_)
            {
                //�q�I�u�W�F�N�g�̃��[�J��Z���W�����[�p�̕ϐ��ɑ������
                Bottom_ = child.transform.localPosition.z;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
         //�v���C���[�̃��[���h���W���擾
        Vector3 pos=transform.position;

        //�E���L�[�����͂��ꂽ�Ƃ�
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //�E������0.03����
            pos.x += 0.03f;
        }

        //�����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //��������0.03����
            pos.x -= 0.03f;
        }

        //����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //�������0.03����
            pos.z += 0.03f;
        }

        //�����L�[�����͂��ꂽ�Ƃ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //��������0.03����
            pos.z -= 0.03f;
        }
        transform.position = new Vector3
            (Mathf.Clamp(pos.x, LeftBottom.x + transform.localScale.x - Left_, RightTop.x - transform.localScale.x - Right_),
            pos.y,
            Mathf.Clamp(pos.z, LeftBottom.z + transform.localScale.z - Bottom_, RightTop.z - transform.localScale.z - Top_));
    }
}
