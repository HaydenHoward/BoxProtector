using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : Collidable
{

    public WinLoose winLooseScript;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name != "Player")
            return;
        if ()
        winLooseScript.WinLevel();
    }
    
}
