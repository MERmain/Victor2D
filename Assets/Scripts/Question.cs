using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public string Quest;
    public string Answer;

    public Question( string quest, string answer)
    {
        Quest = quest;
        Answer = answer.ToUpper();

    }

	
}
