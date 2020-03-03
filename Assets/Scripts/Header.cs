using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Header : MonoBehaviour {

    public Text txtLvl;
    public Text txtMoney;
    public Text txtEnergy;
    public Text txtTimerEnergy;
    public Text txtExp;
    private GameHelper helper = new GameHelper();
    

    public void Init()
    {
        var player = helper.GetPlayer();

        txtLvl.text = player.Lvl.ToString();
        txtMoney.text = player.Money.ToString();
        txtExp.text = player.CurrentExp.ToString()+"/"+Config.ExpLvl[player.Lvl].ToString();
        txtEnergy.text = player.Energy.ToString();
        if (player.Energy >= Config.maxEnergy)
        {
            txtTimerEnergy.gameObject.SetActive(false);
        }
        else
        {
            txtTimerEnergy.gameObject.SetActive(true);
        }
        

    }


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
