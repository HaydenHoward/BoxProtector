using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public float gameTime = 30;
    public float timeDecrease = 1f;
    // public float resetTime;
    public WinLoose winLooseScript;
    // Update is called once per frame
    void Update()
    {
        if( gameTime > 0)
        {
            gameTime -= Time.deltaTime * timeDecrease;
            
        }
        else 
        {
            winLooseScript.LooseLevel();
        }
    }
}
