using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PawnMove : MonoBehaviour
{
    public int MoveX = 0;
    public int MoveY = 0;
    public int _cardId;
    private float currentX = 0;
    private float currentY = 0;

    [SerializeField] private cardPlay _cardPlayB1;
    [SerializeField] private cardPlay _cardPlayB2;
    [SerializeField] private cardPlay _cardPlayB3;
    

    private void Start() //button in the middle does this click that instead 
    {
        //TurnStart();
    }


    public void TurnStart() //Draws all 3 of blues cards, updates the pawns current position
    {
        currentX = transform.position.x;
        currentY = transform.position.y;
        Debug.Log("CurrentPos " + currentX + " " + currentY);
        Debug.Log("Move " + MoveX + " " + MoveY);
        //Card Draw
        _cardPlayB1.cardDraw();
        _cardPlayB2.cardDraw();
        _cardPlayB3.cardDraw();
    }

    public void Move(int MoveX, int MoveY) //Moves the pawn
    {
        transform.Translate(MoveX, MoveY, 0);
        Debug.Log("Pawn moved " + MoveX + " " + MoveY);
    }
}
