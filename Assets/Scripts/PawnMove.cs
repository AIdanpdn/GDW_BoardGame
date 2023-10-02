using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnMove : MonoBehaviour
{
    public int MoveX;
    public int MoveY;
    public int BlueCardId1 = 0;
    public int BlueCardId2 = 0;
    public int BlueCardId3 = 0;
    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnStart()
    {
        card.DrawCards();
    }

    public void Move(int MoveX, int MoveY) 
    {
        transform.Translate(MoveX, MoveY, 0);
        Debug.Log("Pawn moved");
    }
}
