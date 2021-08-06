using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject obj;

    public float spawnTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while(true) 
        {
            float x = Random.Range(-5f, 5f);
            float z = 10f;
            Vector3 pos = new Vector3(x, 5, z);
            Instantiate(obj, pos, Quaternion.Euler(-90, 0, 0));
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
