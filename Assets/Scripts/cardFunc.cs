using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class cardFunc : MonoBehaviour
{
    /* this is the script that cardPlay calls to have all the card Functions*/
    [SerializeField] private InputField InputFieldX;
    [SerializeField] private InputField InputFieldY;
    private int InputValueX;
    private int InputValueY;
    private int lookForKey = 0;


    [SerializeField] private PawnMove pawnMove;

    //Card functions so far only moves the pawn towards red side (reds cards will simply multiply these values by -1)
    public void card0()
    {
        pawnMove.Move(0, 0);
        Debug.Log("cardFunc 0");
    }
    public void card1() // 1 forward
    {
        pawnMove.Move(1, 0);
        Debug.Log("cardFunc 1");
    }    
    public void card2() // 1 up
    {
        pawnMove.Move(0, 1);
        Debug.Log("cardFunc 2");
    }
    public void card3() // 1 down
    {
        pawnMove.Move(0, -1); 
        Debug.Log("cardFunc 3");
    }
    public void card4() // 2 forward
    {
        pawnMove.Move(2, 0);
        Debug.Log("cardFunc 4");
    }
    public void card6() // 2 up
    {
        pawnMove.Move(0, 2);
        Debug.Log("cardFunc 6");
    }
    public void card7() // 2 down
    {
        pawnMove.Move(0, -2);
        Debug.Log("cardFunc 7");
    }

    public void wallTemp() //ALL WALL STUFF DO NOT MESS WITH, CARD 5 IS WALL
    {
        InputFieldX.enabled = true;
        InputFieldY.enabled = true;
        lookForKey = 1;
        
    }
    private void Update()
    {
        if (lookForKey == 1)
        {
            if (Input.GetKey(KeyCode.Return)) 
            {
                InputValueX = int.Parse(InputFieldX.text) - 8;
                InputValueY = int.Parse(InputFieldY.text) - 3;
                pawnMove.wallFunc(InputValueX, InputValueY);
                lookForKey = 0;
                InputFieldX.text = ("");
                InputFieldY.text = ("");

            }
        }
        
    }
}
