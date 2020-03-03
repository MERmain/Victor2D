using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWindow : MonoBehaviour {

    public Text txtTimer;
    public Text QuestionTxt;
    public float CurrentTime;
    public GameObject[] Letters ;
    public List<string> Alphavit;
    int IndexCurrentQuestion = 0; 
    public List<Question> Task1 = new List<Question>
     {
         new Question("Кто говорит на всех языках?","Эхо"),
         new Question ("Что может в одно и то же время: стоять и ходить,висеть и стоять, ходить и лежать?","Часы"),
         new Question("У квадратного стола отпилили один угол. Сколько теперь углов у него стало? ","Пять"),
         new Question("Что самое дефицитное в нашей жизни?","Зло"),
         new Question("Что поднять земли легко, но трудно кинуть далеко?","Пух"),
         new Question("Сидит баба, в сто шуб одета. Кто ее раздевает, тот слезы проливает.","Лук"),
         new Question("Сидит девица в темнице, а коса на улице.","Морковь"),
         new Question("Не шагом ходит, не бегает, а прыгает.","Лягушка"),
         new Question("Кто на себе свой дом носит?","Черепаха"),
         new Question("Ты со мною не знаком? Я живу на дне морском. Голова и 8 ног, вот и весь я - ...","Осьминог")
     };
	// Use this for initialization
	void Start ()
    {
        CurrentTime = Config.timerGame;
         Letters =  GameObject.FindGameObjectsWithTag("Letter");
        Alphavit = new List<string>();
        for (int i = 1040; i < 1072; i++)
        {
            Alphavit.Add(((char)i).ToString());
        }
        NextQuestion();
    }
	
	// Update is called once per frame
	void Update ()
    {
        var time = Time.deltaTime;
        CurrentTime = CurrentTime - time;
        txtTimer.text = "0:" + (int)CurrentTime;


    }
    public void NextQuestion()
    {
        foreach (var item in Letters)
        {
            item.SetActive(true);
        }
        var rnd = new System.Random();
        IndexCurrentQuestion = rnd.Next(0, Task1.Count);
        QuestionTxt.text = Task1[IndexCurrentQuestion].Quest;
        var LetterVariant = new List<string>();
        for (int i = 0; i < Task1[IndexCurrentQuestion].Answer.Length; i++)
        {
            LetterVariant.Add(Task1[IndexCurrentQuestion].Answer[i].ToString());
        }
        var a = 30 - LetterVariant.Count;
        for (int i = 0; i < a; i++)
        {
            LetterVariant.Add(Alphavit[i]);
        }
        for (int i = 0; i < Letters.Length; i++)
        {
            Letters[i].GetComponent<Letter>().Symbol = LetterVariant[i];
            Letters[i].GetComponent<Letter>().Init();
        }

    }
}
