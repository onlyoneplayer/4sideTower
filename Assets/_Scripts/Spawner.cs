using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject wall;

    public float maxTime = 8;
    public float minTime = 1;

    private float time;

    private float spawnTime;

    private void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    private void FixedUpdate()
    {
        time += Time.fixedDeltaTime;

        if(time>= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }
    }

    private void SpawnObject()
    {
        time = 0;
        Instantiate(wall, transform.position, transform.rotation);
    }

    private void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
