using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer : MonoBehaviour
{
    public Wordbank wordBank = null; 
    public Text wordOutput = null;

    public string remainingWord = string.Empty;
    private string currentWord = string.Empty;

    public bool damageTaken = false;

    // Start is called before the first frame update
    private void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()   
    {
        currentWord = wordBank.GetWord();
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if (keysPressed.Length == 1)
                EnterLetter(keysPressed);
        }
    }

    public void EnterLetter(string typedLetter)
    {
        if (isCorrectLetter(typedLetter))
        {
            RemoveLetter();

            if (remainingWord.Length == 0)
            {
                SetCurrentWord();
                damageTaken = true;
            }
        }
    }

    private bool isCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }


}
