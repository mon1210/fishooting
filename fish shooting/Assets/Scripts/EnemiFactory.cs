using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiFactory : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public int defeatCount = -1;
    int defeatCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Create()
    {
        float intervl_time = 2.0f;

        //ˆê’è”‚Ì“G‚ğ“|‚·‚Ü‚Åƒ‹[ƒv
        while (defeatCounter < defeatCount)
        {

            Vector3 pos = transform.position;
            pos.y = Random.Range(-3.0f, 3.0f);

            Instantiate(EnemyPrefab, pos, Quaternion.identity);
            yield return new WaitForSeconds(intervl_time);
        }

    }
}
