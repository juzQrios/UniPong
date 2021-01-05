﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;

    public GUISkin layout;

    GameObject theBall;
    // Start is called before the first frame update
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Score(string wallID)
    {
        if(wallID == "RightWall")
        {
            PlayerScore1++;
        } else
        {
            PlayerScore2++;
        }
    }

    private void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150, 20, 150, 150), "" + PlayerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150, 20, 150, 150), "" + PlayerScore2);

    }
}
