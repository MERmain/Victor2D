using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHelper
{
    public Player GetPlayer()
    {
        var playerComponent = GameObject.FindGameObjectWithTag("GameController");
        var player = playerComponent.GetComponent<Controller>().Player;
        return player;
    }

    public Controller GetController()
    {
        var Component = GameObject.FindGameObjectWithTag("GameController");
        var controller = Component.GetComponent<Controller>();
        return controller;
    }


}
