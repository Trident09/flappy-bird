using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5;
    public float minSpawnRate = 1;
    private float spawnTimer = 0;
    public float heightOffset = 5;
    public float changeModifier = 0.9f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < spawnRate)
        {
            spawnTimer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnTimer = 0;
            if (spawnRate > minSpawnRate)
            {
                spawnRate *= changeModifier;
            }
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
