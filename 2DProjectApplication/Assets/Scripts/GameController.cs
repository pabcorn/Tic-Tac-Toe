using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Text[] buttonList;
    public string playerSide;
    void Awake()
    {
        SetGameControllerReferenceOnButtons();
        playerSide = "X";
        
    }
    void SetGameControllerReferenceOnButtons()
    {
        for (int i=0; i<buttonList.Length; i++)
        {
            buttonList[i].GetComponent<GridSpace>().SetGameOnController(this);
        }
    }
    public string GetPlayerSide()
    {
        return playerSide;
    }
    public void EndTurn()
    {
        if(buttonList [0] .text == playerSide && buttonList [1] .text == playerSide && buttonList [2].text == playerSide)
        {

        }
    }
}
