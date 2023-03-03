using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnRate;
    private float timer;
    private GameObject enemyInstance;
    Vector2 spawnPosition;
    [SerializeField] private float spawnCircleSize;
   // Start is called before the first frame update
   void Start()
    {
        timer = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            spawnPosition = transform.position = Random.insideUnitCircle.normalized * spawnCircleSize;
            enemyInstance = Instantiate(enemyPrefab,spawnPosition,Quaternion.identity);
            timer = spawnRate;
        }
    }
}
