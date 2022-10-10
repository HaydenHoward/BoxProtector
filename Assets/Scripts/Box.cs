using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : Mover
{
    // Logic
    public float startLength = 3;
    public float stopLength = 1;
    private bool chasing;
    private bool collidingWithPlayer;
    // private Transform playerTransform;
    // private Vector3 startingPosition;
    private Transform target;

    // Hitbox
    // public ContactFilter2D filter;
    // private BoxCollider2D hitbox;
    // private Collider2D[] hits = new Collider2D[10];

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        // playerTransform = gameManager.instance.player.transform;
        // startingPosition = transform.position;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        // hitbox = transform.GetChild(0).GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // Is the player in range?
        if (Vector3.Distance(transform.position, target.position) < startLength)
        {
            chasing = true;
            gameObject.tag = "Box";
        }
        if (chasing)
        {
            if (Vector3.Distance(transform.position, target.position) > stopLength)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, xSpeed * Time.deltaTime);
            }        
        }
    }
}
