using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour {

    public Text txtLetter;
    public string Symbol;
    // Use this for initialization
    public void Init()
    {
        txtLetter.text = Symbol.ToUpper();
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
