using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    // Static class for saving current data from the Player;
    // Singleton pattern

    public static PlayerDataHandle Instance;

    public string PlayerName;

    public int Score;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
