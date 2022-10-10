using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBox : Collidable
{
    private float depositCoolDown = 1.0f;
    private float lastDeposite;
    public int savedBoxes = 0;


    protected override void OnCollide(Collider2D coll)
    {
        
        if (coll.name != "Player")
            return;
        if (Time.time - lastDeposite > depositCoolDown)
        {
            lastDeposite = Time.time;
            Destroy(GameObject.FindGameObjectWithTag("Box"));
            savedBoxes += 1;
        }
    }
}
