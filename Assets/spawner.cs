using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{

    public float spawnRate = 1f;

    public GameObject squarePrefab;

    private float nextTimeToSpawn = 0f;
    // Start is called before the first frame update


    void Update()
    {
        if(Time.time >= nextTimeToSpawn) {
            Instantiate(squarePrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f/spawnRate;
        }
    }
}
