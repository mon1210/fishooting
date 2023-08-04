using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5.0f*Time.deltaTime;
        transform.Translate(speed, 0.0f, 0.0f);

    }

    //��ʊO�ɏo���������
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //Enemytag�������Ă���I�u�W�F�N�g���폜
            Destroy(gameObject);
        }

    }
}
