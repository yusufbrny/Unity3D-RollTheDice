using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceText : MonoBehaviour
{
    [SerializeField] private Text text;
    public static int diceNo;

    void Start()
    {
        
    }


    void Update()
    {
        text.text = "Dice value : " + diceNo.ToString();
    }
}
