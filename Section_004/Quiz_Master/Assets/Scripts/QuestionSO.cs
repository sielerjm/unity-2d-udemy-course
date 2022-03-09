using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")] // Unity Object

public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new question text here";  // change var in inspector
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    // Used to display question text
    public string GetQuestion()
    {
        return question;  // returns Question
    }

    // Returns correct answer
    public string GetAnswer(int index)
    {
        return answers[index];
    }

    // Get correct answer index
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    
}
