using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GridSpace : MonoBehaviour
{
    [Header("Button")]
    [Tooltip("insert button in here for player can click.")] public Button button;
    [Tooltip("insert Text button.")] public Text buttonText;


    private GameController gameController;

    public void SetGameOnController(GameController controller)
    {
        gameController = controller;
    }

    public void SetSpace()
    {
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
    }

}
