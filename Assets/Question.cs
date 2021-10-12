using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    [System.NonSerialized]
    public string [] Choice;
    public int answer;
    public string question;

    // Start is called before the first frame update
    void Start()
    {
        Choice = new string[3];
    }

    public void setQuestion(string question, string choice0, string choice1, string choice2, int answer)
    {
        this.question = question;

        Choice[0] = choice0;
        Choice[1] = choice1;
        Choice[2] = choice2;

        this.answer = answer;
    }

    public string getQuestion()
    {
        return question;
    }

    public string getChoice(int index)
    {
        return Choice[index];
    }

    public int getAnswer()
    {
        return answer;
    }
}
