using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PawnMove : MonoBehaviour
{
    public int MoveX = 0;
    public int MoveY = 0;
    public int _cardId;
    private float currentX = 0;
    private float currentY = 0;
    public int _turn = 0; //Turn identifier, 0 = blue 1 = red

    [SerializeField] private PawnMove pawnMove;
    [SerializeField] private cardPlay _cardPlayB1;
    [SerializeField] private cardPlay _cardPlayB2;
    [SerializeField] private cardPlay _cardPlayB3;
    [SerializeField] private cardPlay _cardPlayR1;
    [SerializeField] private cardPlay _cardPlayR2;
    [SerializeField] private cardPlay _cardPlayR3;
    [SerializeField] private Text _winText;
    public Button[] _cardButtons;


    private void Start() //button in the middle does this click that instead 
    {
        TurnStart();
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
        _cardPlayR1.cardDraw();
        _cardPlayR2.cardDraw();
        _cardPlayR3.cardDraw();
    }

    public void TurnSwitch()
    {
        if (_turn == 0)
        {
            _turn = 1;
            Debug.Log(_turn);
            _cardButtons[0].enabled = false;
            _cardButtons[1].enabled = false;
            _cardButtons[2].enabled = false;
            _cardButtons[3].enabled = true;
            _cardButtons[4].enabled = true;
            _cardButtons[5].enabled = true;
        }

        else if (_turn == 1)
        {
            _turn = 0;
            Debug.Log(_turn);
            _cardButtons[0].enabled = true;
            _cardButtons[1].enabled = true;
            _cardButtons[2].enabled = true;
            _cardButtons[3].enabled = false;
            _cardButtons[4].enabled = false;
            _cardButtons[5].enabled = false;
            TurnStart();
        }

        else if (_turn == 2)
        {
            SceneManager.LoadScene("BoardGame");
        }
    }

    public void Move(int MoveX, int MoveY) //Moves the pawn
    {
        if (_turn == 1)
        {
            MoveX = MoveX * -1;
        }

        transform.Translate(MoveX, MoveY, 0);
        Debug.Log("Pawn moved " + MoveX + " " + MoveY);
        currentX = transform.position.x;
        currentY = transform.position.y;
        checkWin();
    }

    public void wallFunc()
    {

    }

    private void checkWin()
    {
        if (currentX == 7)
        {
            Debug.Log("p1 wins");
            _winText.text = "Blue Wins!";
            _winText.color = Color.blue;
            _turn = 2;
            _cardButtons[0].enabled = false;
            _cardButtons[1].enabled = false;
            _cardButtons[2].enabled = false;
            _cardButtons[3].enabled = false;
            _cardButtons[4].enabled = false;
            _cardButtons[5].enabled = false;

        }

        if (currentX == -7)
        {
            Debug.Log("p2 wins");
            _winText.text = "Red Wins!";
            _winText.color = Color.red;
            _turn = 2;
            _cardButtons[0].enabled = false;
            _cardButtons[1].enabled = false;
            _cardButtons[2].enabled = false;
            _cardButtons[3].enabled = false;
            _cardButtons[4].enabled = false;
            _cardButtons[5].enabled = false;
        }

        //board boundries
        if (currentY == 3)
        {
            transform.Translate(0, -1 , 0);
        }

        if (currentY == -3)
        {
            transform.Translate(0, 1, 0);
        }

        if (currentY == 4)
        {
            transform.Translate(0, -2, 0);
        }

        if (currentY == -4)
        {
            transform.Translate(0, 2, 0);
        }
    }
}
