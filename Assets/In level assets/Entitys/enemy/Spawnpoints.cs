using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoints : MonoBehaviour
{
    public Transform centrePoint;
    public GameObject EnemyPrefab;
    private int inCycle;
    Vector2 SpawnPosition1 = new Vector2(4, 4);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inCycle == 0)
        {
            StartCoroutine(TimeTillSpawnTime());
        }
    }

    public IEnumerator TimeTillSpawnTime()
    {
        int SpawnTime = Random.Range(1, 10);
        inCycle = 1;
        yield return new WaitForSeconds(SpawnTime);
        Instantiate(EnemyPrefab, SpawnPosition1, centrePoint.rotation);
        inCycle = 0;
    }
}
