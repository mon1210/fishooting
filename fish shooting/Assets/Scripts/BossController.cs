using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BossController : MonoBehaviour
{
    public GameObject explosionPrefab = null;
    public GameObject BulletPrefab = null;
    private Vector3 initialPosition;
    private Vector2 pos;
    public int num = 1;

    public enum ActionPart
    {
        Appearance, //出現パート
        Battle,     //戦闘パート
        Defeat,     //撃退パート

    }

    Rigidbody2D rigidbody2D;
    ActionPart currentPatt = ActionPart.Appearance;
    int HitPoint = 5;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(-2.0f, 0.0f);

        StartCoroutine(Apper());
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentPatt)
        {
            case ActionPart.Appearance:
            
        
            break;

            case ActionPart.Battle:

              
                break;
            case ActionPart.Defeat:
               

                break;
                
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        HitPoint--;
        if (collision.tag == "PlayerBullet" && currentPatt == ActionPart.Battle)
        {
            HitPoint--;
            if (HitPoint <= 0)
            {
                currentPatt = ActionPart.Defeat;
                rigidbody2D.gravityScale = 0.5f;
            }

        }
    }
    IEnumerator Apper()
    {
        while (transform.position.x > 4.5f)
        {
            yield return null;
        }

        rigidbody2D.velocity = Vector2.zero;
        //出現処理が終わったので戦闘へ移項
        currentPatt = ActionPart.Battle;
    }
}

