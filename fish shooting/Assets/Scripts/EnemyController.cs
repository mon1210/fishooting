using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame updat
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = -4.0f * Time.deltaTime;
        transform.Translate(speed, 0.0f, 0.0f);

        //敵の位置が-5以下になったら削除 
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
