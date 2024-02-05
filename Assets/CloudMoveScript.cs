using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float deadZone = -30;
    private float cloudSpeed;

    // Start is called before the first frame update
    void Start()
    {
        float randSize = Random.Range(0.5f, 2f);
        transform.localScale = new Vector3(randSize, randSize, 1f);
        cloudSpeed = Random.Range(2, 10);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * cloudSpeed * Time.deltaTime);

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
