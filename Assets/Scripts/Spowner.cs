using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spowner : MonoBehaviour
{

    public Transform spawnPos;

    [SerializeField] Vector2 Range;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject point;
 

    void Start()
    {
        StartCoroutine(SpawnerBrick());
        StartCoroutine(SpawnerPoint());              
    }



    IEnumerator SpawnerBrick() 
    {
        while (true)
        {
            yield return new WaitForSeconds(1.3f);
            Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-Range.y, Range.y));
            Instantiate(enemy, pos, Quaternion.identity);
        }
    }

    IEnumerator SpawnerPoint()
    {
        while (true)
        {
            if(ManagerElement.isMore)
                yield return new WaitForSeconds(0.8f);
            else
                yield return new WaitForSeconds(1.4f);
            Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-Range.y, Range.y));
            Instantiate(point, pos, Quaternion.identity);
        }
    }

   
            

}
