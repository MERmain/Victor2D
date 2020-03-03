using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
   public List<DelayItem> ItemBonus;
    public int CurrentNumberDay = 2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ItemBonus.Count; i++)
        {
            var NumberDay = i + 1;
            ItemBonus[i].txtNameDay.text = NumberDay.ToString() + " день";
            if (NumberDay == 1)
                ItemBonus[i].Coin1.SetActive(true);
            if (NumberDay == 2)
                ItemBonus[i].Coin2.SetActive(true);
            if (NumberDay > 2)
                ItemBonus[i].Coin3.SetActive(true);
           
            ItemBonus[i].CountMoney.text = (NumberDay * 5).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
