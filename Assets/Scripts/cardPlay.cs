using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class cardPlay : MonoBehaviour
{
    private PawnMove pawnMove;
    [SerializeField] private cardFunc cardFunc;
    public int _cardId;

    private void Start()
    {
    
    }
    public  int cardDraw()
    {
        _cardId = Random.Range(1, 3); //Change to 22
        //_cardId = 1;
        Debug.Log("Card Id " + _cardId);
        return _cardId;
    }

    public void cardPlayed()
    {
        if (_cardId == 1);
        {
            cardFunc.card1();
        }

        if (_cardId == 2)
        {
            cardFunc.card2();
        }
    }
}
