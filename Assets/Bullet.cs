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

        //ã‚ÉŒü‚©‚Á‚Ä^‚Á‚·‚®”ò‚Ô
        pos.z += 0.05f;
        //’e‚ÌˆÚ“®
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        //ˆê’è‹——£i‚ñ‚¾‚çÁ–Å‚·‚é
        if (pos.z >= 20)
        {
            Destroy(this.gameObject);
        }
    }
}
