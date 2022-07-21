using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    static Rigidbody r;
    public static Vector3 DiceVelo;

    void Start()
    {
        //statik olarak tanýmladýðýmýz rigidbody
        r = GetComponent<Rigidbody>();
    }


    void Update()
    {
        DiceVelo = r.velocity;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(" Zar Baþarýyla Atýldý ");
            DiceText.diceNo = 0;
            float dirX = Random.Range(0, 360);
            float dirY = Random.Range(0, 360);
            float dirZ = Random.Range(0, 360);

            transform.position = new Vector3(0, 5, 0);
            transform.rotation = Quaternion.identity;
            r.AddForce(transform.up * 350);
            r.AddTorque(dirX, dirY, dirZ);
        }
    }
}
