using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Start()
    {
        DataManager.InitializeUnlockedObjects();
        Application.targetFrameRate = 30;
    }
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
