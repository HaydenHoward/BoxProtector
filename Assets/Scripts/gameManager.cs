using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    public static gameManager instance;

    void Awake() {
        instance = this;
        // SceneManager.sceneLoaded += LoadState;
        // SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Resources
    public List<Sprite> playerSprites;

    // Refrences
    public Player player;

    // Logic

}

