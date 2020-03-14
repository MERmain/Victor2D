using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public Header Header;
    public Player Player;
    public GameWindow GameWindow;

    void Start ()
    {
        Player = new Player();
        Header.Init();
	}

    public void UpdateHeader()
    {
        Debug.Log(Player.Money);
        Header.Init();
    }
	

	void Update () {
		
	}
    public void ClickTheme(int idTheme)
    {
        Debug.Log("Выбрана тема Id = " + idTheme);

    }
}
