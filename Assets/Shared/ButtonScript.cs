﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public Sprite O_image;
    public Sprite X_image;
    public Sprite Null_image;

    GameLogic gameLogic;

    public bool hasBeenPlayed = false;
    public char buttonVal { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.Find("GameLogic").GetComponent<GameLogic>();
        this.GetComponent<Image>().sprite = Null_image;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnUserClick()
    {
        if(hasBeenPlayed == false && gameLogic.isPlayerPlaying == true)
        {
            hasBeenPlayed = true;
            this.GetComponent<Image>().sprite = X_image;
            buttonVal = 'X';
            gameLogic.isPlayerPlaying = false;
        }
    }

    public void OnMachineClick()
    {
        if (hasBeenPlayed == false)
        {
            hasBeenPlayed = true;
            this.GetComponent<Image>().sprite = O_image;
            buttonVal = 'O';
            gameLogic.isPlayerPlaying = true;
        }
    }
}
