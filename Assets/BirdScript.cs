using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public LogicManagerScript logic;
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public bool BirdIsAlive = true;
    private float clock = 0;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdIsAlive && clock < 0.1)
        {
            clock += Time.deltaTime;
        }
        else if (BirdIsAlive)
        {
            logic.wingAnimation();
            clock = 0;
        }


        if (Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BirdIsAlive = false;
        logic.gameOver();
    }
}
