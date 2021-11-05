using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quizzer : MonoBehaviour
{
    Data data;
    public Animator moneyChange;
    public Animator res;
    public TextMeshProUGUI MoneyAnimText;
    public TextMeshProUGUI result;

    public TextMeshProUGUI ansText1;
    public TextMeshProUGUI ansText2;
    public TextMeshProUGUI ansText3;
    public TextMeshProUGUI question;

    int answerIndex;

    public Questions[] q;   

    // Start is called before the first frame update
    public int choiceIndex;
    int questionCounter = 0;

    void Start()
    {
        data = GameObject.Find("GameData").GetComponent<Data>();
        data.loadData();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(q[questionCounter].getQuestion());
        if (questionCounter >= q.Length)
        {
            questionCounter = 0;
        }

        question.SetText(q[questionCounter].question);
        ansText1.SetText(q[questionCounter].choice1);
        ansText2.SetText(q[questionCounter].choice2);
        ansText3.SetText(q[questionCounter].choice3);
        answerIndex = q[questionCounter].answer;

        Debug.Log(questionCounter);
    }

    public void choose(int choiceIndex)
    {
        this.choiceIndex = choiceIndex;

        if (choiceIndex==answerIndex)
        {
            data.money += 100;
            result.SetText("Correct");
            res.SetTrigger("correct");
            MoneyAnimText.SetText("+100");
            moneyChange.SetTrigger("Add");
            questionCounter += 1;
        }
        else {
            result.SetText("Wrong");
            res.SetTrigger("wrong");
            if (data.money <= 0)
            {
                data.money = 0;
            }
            data.money -= 500;
            MoneyAnimText.SetText("-500");
            moneyChange.SetTrigger("Minus");
            questionCounter += 1;
        }
    }

    [System.Serializable]
    public struct Questions
    {
        public string question;

        public string choice1;
        public string choice2;
        public string choice3;

        public int answer;
    }

}
