using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    //makes one instance in our scene once
    private int currentScore;
    public static MainGameManager instance;

    //accesible from other scripts
    void Awake()
    {
        instance = this;

    }

    //functionality - singleton // parameters a number
    public void AdjustScore (int num)
    {
        currentScore = currentScore + num;

    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), "Score = " + currentScore);
    }
}
