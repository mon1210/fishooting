using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = -4.0f * Time.deltaTime;
        transform.Translate(speed, 0.0f, 0.0f);

        //�G�̈ʒu��-5�ȉ��ɂȂ�����폜 
        if (transform.position.x <= -5.0f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullet" || collision.tag == "Player")
        {

            Destroy(gameObject);
        }


    }
}
