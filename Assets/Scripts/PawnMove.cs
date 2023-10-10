using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnMove : MonoBehaviour
{
    public int MoveX;
    public int MoveY;
    public int _cardId;
    private float currentX = 0;
    private float currentY = 0;

    [SerializeField] private cardPlay _cardPlay;

    // Start is called before the first frame update
    void Start()
    {
        TurnStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnStart()
    {
        currentX = transform.position.x;
        currentY = transform.position.y;
        Debug.Log(currentX + " " + currentY);
        Debug.Log(MoveX + " " + MoveY);
        //Card Draw
        _cardPlay.cardDraw();
    }

    public void Move(int MoveX, int MoveY) 
    {
        transform.Translate(currentX + MoveX, currentY + MoveY, 0);
        Debug.Log("Pawn moved");
    }
}
