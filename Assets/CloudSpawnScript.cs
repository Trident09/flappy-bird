using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject Clouds;
    public float spawnCloudRate = 5;
    private float spawnCloud = 0;
    public float cloudHeightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCloud < spawnCloudRate)
        {
            spawnCloud += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnCloud = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - cloudHeightOffset;
        float highestPoint = transform.position.y + cloudHeightOffset;
        Instantiate(Clouds, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), Random.Range(1, 10)), transform.rotation);
    }
}