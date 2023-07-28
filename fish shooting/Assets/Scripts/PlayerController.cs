using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject PlayerBulletPrefab = null;
    float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PMove();

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(PlayerBulletPrefab, transform.position, Quaternion.identity);
        }
    }

   private void PMove() 
    {
        Vector3 vec = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            vec.x = -1.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            vec.y = 1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vec.x = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vec.y = -1.0f;
        }

        Vector3 new_pos = transform.position + (vec.normalized * speed * Time.deltaTime);

        new_pos.x = Mathf.Clamp(new_pos.x, -6.4f, 6.4f);
        new_pos.y = Mathf.Clamp(new_pos.y, -4.0f, 2.5f);

        transform.position = new_pos;

    }
}
