using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timerValue;

    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool loadNextQuestsion;
    public bool isAnsweringQuestion = false;
    public float fillFraction;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0f;
    }

    void UpdateTimer() 
    {
        timerValue -= Time.deltaTime;

        if (timerValue <= 0f) 
        {
            if (isAnsweringQuestion) {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            } else {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuestion = true;
                loadNextQuestsion = true;
            }
        }
        else
        {
            if (isAnsweringQuestion) {
                fillFraction = timerValue / timeToCompleteQuestion;
            } else {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
        }
    }
}
