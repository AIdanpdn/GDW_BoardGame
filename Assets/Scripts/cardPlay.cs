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
    [SerializeField] private Text _text;
    [SerializeField] private Image _cardSprite;
    private void Start()
    {
        //Sprite plus1Forward = Resources.Load<Sprite>("+1Forward"); //Loads the sprite
    }

    private void Update() //will be where the card sprite gets updated (empty and unfinished)
    {
        if (_cardId == 0)
        {
            //_cardSprite.sprite = null;
        }
        else if (_cardId == 1)
        {
            //_cardSprite.sprite = plus1Forward;
        }
        else if (_cardId == 2)
        {

        }

        else if (_cardId == 3)
        {


        }
    }

    public void cardDraw() //Gets random number that corresponds to each card (Is seperate for each card slot already)
    {
        _cardId = Random.Range(1, 3); //Change to 22
        Debug.Log("Card Id " + _cardId);
        _text.text = ("Card ID " + _cardId);
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

        _cardId = 0;
        Debug.Log("2nd ID " + _cardId);
        _text.text = ("Card ID " + _cardId);
    }
}
