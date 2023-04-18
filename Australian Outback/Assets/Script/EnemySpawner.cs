using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(75, -76);
            zPos = Random.Range(-5, 130);

            Instantiate(enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);

            yield return new WaitForSeconds(3);

            enemyCount += 1;
        }
    }
}
