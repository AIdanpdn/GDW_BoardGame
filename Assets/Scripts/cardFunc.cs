using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cardFunc : MonoBehaviour
{
    /* this is the script that cardPlay calls to have all the card Functions*/

    [SerializeField] private PawnMove pawnMove;

    //Card functions so far only moves the pawn towards red side (reds cards will simply multiply these values by -1)
    //We can rename these but rename them in cardPlay also!!!!!!!!!!!!
    public void card0()
    {
        pawnMove.Move(0, 0);
        Debug.Log("cardFunc 0");
    }
    public void card1()
    {
        pawnMove.Move(1, 0);
        Debug.Log("cardFunc 1");
    }    
    public void card2()
    {
        pawnMove.Move(0, 1);
        Debug.Log("cardFunc 2");
    }
    public void card3()
    {
        pawnMove.Move(0, -1);
    }

    public void wallTemp()
    {
        Debug.Log("Button Works");
    }
}
