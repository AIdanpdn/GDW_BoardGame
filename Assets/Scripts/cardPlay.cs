using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class cardPlay : MonoBehaviour
{
    /* This is the system to play and load the cards*/

    private PawnMove pawnMove;
    public int _cardId = 0;
    [SerializeField] private cardFunc cardFunc;
    public GameObject card;

    public void cardDraw() //Gets random number that corresponds to each card (Is seperate for each card slot already)
    {
        _cardId = Random.Range(1, 8); //Change to 22
        Debug.Log("Card Id " + _cardId);
        //cardSprite.cardImageUpdate();


    }

    public void buttonClicked() //checks if button is pushed and calls the correct function
    {
        Debug.Log("buttonClicked card ID " + _cardId);
        cardPlayed();
    }

    public void cardPlayed() //Checks the card ID in each slot and calls the corresponding function in cardFunc with 0 being no card in that slot
    {
        Debug.Log("1st ID " + _cardId);

        if (_cardId == 0)
        {
            Debug.Log("No card");
            cardFunc.card0();
        }
        else if (_cardId == 1)
        {
            cardFunc.card1();
        }
        else if (_cardId == 2)
        {
            cardFunc.card2();
        }

        else if (_cardId == 3)
        {
            cardFunc.card3();

        }

        else if (_cardId == 4)
        {
            cardFunc.card4();
        }

        else if (_cardId == 5)
        {
            cardFunc.wallTemp();
        }

        else if (_cardId == 6)
        {
            cardFunc.card6();
        }

        else if (_cardId == 7)
        {
            cardFunc.card7();
        }

        _cardId = 0;
        Debug.Log("2nd ID " + _cardId);
    }
}
