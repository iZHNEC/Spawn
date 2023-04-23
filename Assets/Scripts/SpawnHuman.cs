using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHuman : MonoBehaviour
{
    [SerializeField] private Enemy _enemyHuman;

    private int maxEnemy = 5;
    private float timeSpawn = 2f;
    private float distance = 3;
    private float timer;

    private void Start()
    {
        timer = timeSpawn;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeSpawn;
            if (transform.childCount < maxEnemy)
            {
                Instantiate(_enemyHuman, Random.insideUnitCircle * distance, Quaternion.identity, transform);
            }
        }
    }
}