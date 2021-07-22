using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GridSpace : MonoBehaviour
{
    //public Button button;
    //public Text buttonText;
    //public string playerSide;
    //private GameController gameController;
    //public void SetGameOnController(GameController controller)
    //{
    //    gameController = controller;
    //}

    //public void SetSpace()
    //{
    //    buttonText.text = gameController.GetPlayerSide();
    //    button.interactable = false;
    //    gameController.EndTurn();
    //}
    public Button button;
    public Text buttonText;

    private GameController gameController;

    public void SetGameControllerReference(GameController controller)
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
