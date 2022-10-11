using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public float gameTime = 10.0f;
    public WinLoose winLooseScript;
    // Update is called once per frame
    void Update()
    {
        if(Time.time > gameTime)
        {
            winLooseScript.LooseLevel();
        }
    }
}
