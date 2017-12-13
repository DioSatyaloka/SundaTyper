using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

    public List<Word> words;

    public WordSpawner wordSpawner;
    public Score score;

    private bool hasActiveWord;
    private Word activeWord;
    private int _score = 0;


    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        //Debug.Log(word.word);

        words.Add(word);
    }
    void OnBecameInvisible()
    {
        hasActiveWord = false;
        words.Remove(activeWord);
    }
    public void TypeLetter(char letter)
    {
        if(hasActiveWord)
        {
            //cek apakah hurufnya next dari current active word
            //kalau iya, hurufnya remove dari active word
            if (activeWord.GetNextLetter() == letter)
            {
                _score++;
                score.score = _score;
                activeWord.TypeLetter();
            }

        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    _score++;
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if(hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
