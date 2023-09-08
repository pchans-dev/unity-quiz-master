using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quiz question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter me question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion() {
        return question;
    }

    public string[] GetAnswers() {
        return answers;
    }

    public string GetAnswer(int index) {
        return answers[index];
    }

    public int GetCorrectAnswerIndex() {
        return correctAnswerIndex;
    }
}