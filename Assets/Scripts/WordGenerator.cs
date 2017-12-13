using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

    private static string[] wordList = {    "abdi", "kuring", "anjeun", "budak", "rencang", "rerencangan", "bapa", "ibu", "tuang", "neda", "dahar",
                                            "isuk", "beurang", "peuting", "indung", "nini", "aki", "panon", "mastaka", "hudang", "labuh", "ulin",
                                            "belajar", "geulis", "kasep", "ulah", "lamun", "sesa", "kamari", "isukan", "merenah", "maneh", "naha",
                                            "kumargi", "kulawarga", "bade", "atos", "parantos", "sakedap", "baheula", "kolot", "loba", "saeutik"   };

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
