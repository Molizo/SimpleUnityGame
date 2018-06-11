using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static int currentLevel;
    public static int unlockedLevel;
    public static int deaths;

    void setup()
    {
        currentLevel = 0;
        unlockedLevel = 0;
        deaths = 0;
    }

    public static void completedLevel()
    {
        currentLevel++;
        Application.LoadLevel(currentLevel);
    }
}
