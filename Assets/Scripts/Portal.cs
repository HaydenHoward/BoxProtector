using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    public WinLoose winLooseScript;
    private bool collectedBoxes;

    // void Start()
    // {
    //     GameObject[] boxes;
    //     boxes = GameObject.FindGameObjectsWithTag("Box");
    //     if(boxes.Length == 0)
    //     {
    //         collectedBoxes = true;   
    //     }
    // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject[] boxes;
        boxes = GameObject.FindGameObjectsWithTag("Box");
        GameObject[] boxesLost;
        boxesLost = GameObject.FindGameObjectsWithTag("Lost Box");
        if(boxes.Length == 0 & boxesLost.Length == 0)
        {
            collectedBoxes = true;   
        }
        if (collectedBoxes)
        {
            winLooseScript.WinLevel();
        }
    }
    
}
