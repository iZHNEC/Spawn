using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHuman : MonoBehaviour
{
    [SerializeField] private Enemy _enemyHuman;

    private int _maxEnemy = 5;
    private float _timeSpawn = 2f;
    private float _distance = 3;
    private float _timer;

    private void Start()
    {
        _timer = _timeSpawn;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0)
        {
            _timer = _timeSpawn;
            if (transform.childCount < _maxEnemy)
            {
                Instantiate(_enemyHuman, Random.insideUnitCircle * _distance, Quaternion.identity, transform);
            }
        }
    }
}