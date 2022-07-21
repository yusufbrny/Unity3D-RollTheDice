using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheck : MonoBehaviour
{
    Vector3 diceVelocity;

    void FixedUpdate()
    {
        diceVelocity = Dice.DiceVelo;
    }

    void OnTriggerStay(Collider hamdi)
    {
        if(diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch(hamdi.gameObject.name)
            {
                case "Side1":
                    DiceText.diceNo = 2;
                    break;
                case "Side2":
                    DiceText.diceNo = 3;
                    break;
                case "Side3":
                    DiceText.diceNo = 1;
                    break;
                case "Side4":
                    DiceText.diceNo = 6;
                    break;
                case "Side5":
                    DiceText.diceNo = 4;
                    break;
                case "Side6":
                    DiceText.diceNo = 5;
                    break;
            }
        }
    }
}
