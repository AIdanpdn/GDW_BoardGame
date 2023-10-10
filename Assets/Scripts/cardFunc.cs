using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cardFunc : MonoBehaviour
{
    [SerializeField] private PawnMove pawnMove;
    public void card1()
    {
        pawnMove.Move(1, 0);
    }    
    public void card2()
    {
        pawnMove.Move(0, 1);
    }
}
