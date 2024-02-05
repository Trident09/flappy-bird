using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public LogicManagerScript logic;
    public float deadZone = -30;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        logic.increaseSpeed();
        float moveSpeed = logic.moveSpeed;
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
