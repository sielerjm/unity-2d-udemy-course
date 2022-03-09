using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;

    int correctAnswerIndex;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    private void Start()
    {
        questionText.text = question.GetQuestion();

        //TextMeshProUGUI buttonText = answerButtons[0].GetComponentInChildren<TextMeshProUGUI>();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }

    }

    public void OnAnswerSelected(int index)
    {
        Image buttonImage;


        if(index == question.GetCorrectAnswerIndex())  // ! This isn't being triggered
        {
            questionText.text = "Correct!";

            Debug.Log("Correct Button!");  // TEST

            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        } else
        {
            Debug.Log("Incorrect Button!");  // TEST
            correctAnswerIndex = question.GetCorrectAnswerIndex();
            string correctAnswer = question.GetAnswer(correctAnswerIndex);

            questionText.text = "Sorry, the correct answer was;\n" + correctAnswer;

            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;

        }
    }

}
