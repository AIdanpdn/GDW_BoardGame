using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using TMPro;

public class PawnMove : MonoBehaviour
{
    public int MoveX = 0;
    public int MoveY = 0;
    public int _cardId;
    public float currentX = 0;
    public float currentY = 0;
    public int _turn = 0; //Turn identifier, 0 = blue 1 = red
    public bool _wallCloneFlag;

    [SerializeField] private GameObject wall;
    [SerializeField] private PawnMove pawnMove;
    [SerializeField] private cardPlay _cardPlayB1;
    [SerializeField] private cardPlay _cardPlayB2;
    [SerializeField] private cardPlay _cardPlayB3;
    [SerializeField] private cardPlay _cardPlayR1;
    [SerializeField] private cardPlay _cardPlayR2;
    [SerializeField] private cardPlay _cardPlayR3;
    public Button[] _cardButtons;

    [SerializeField] private GameObject inputBox;
    [SerializeField] public TMP_Text Heading;

    [SerializeField] private GameObject Disabled1;
    [SerializeField] private GameObject Disabled2;
    [SerializeField] private GameObject Disabled3;
    [SerializeField] private GameObject Disabled4;
    [SerializeField] private GameObject Disabled5;
    [SerializeField] private GameObject Disabled6;

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
        inputBox.SetActive(false);
        Heading.enabled = true;

        if (_turn == 0)
        {
            Heading.text = "Player 2's Turn";
            _turn = 1;
            Debug.Log(_turn);
            _cardButtons[0].enabled = false;
            _cardButtons[1].enabled = false;
            _cardButtons[2].enabled = false;
            _cardButtons[3].enabled = true;
            _cardButtons[4].enabled = true;
            _cardButtons[5].enabled = true;
            Disabled1.SetActive(true);//DONT CHANGE: THESE DISABLED OBJS ARE TRUE=DISABLED (Opposite of what u would think)
            Disabled2.SetActive(true);
            Disabled3.SetActive(true);
            Disabled4.SetActive(false);
            Disabled5.SetActive(false);
            Disabled6.SetActive(false);
        }

        else if (_turn == 1)
        {
            Heading.text = "Player 1's Turn";
            _turn = 0;
            Debug.Log(_turn);
            _cardButtons[0].enabled = true;
            _cardButtons[1].enabled = true;
            _cardButtons[2].enabled = true;
            _cardButtons[3].enabled = false;
            _cardButtons[4].enabled = false;
            _cardButtons[5].enabled = false;
            Disabled1.SetActive(false);
            Disabled2.SetActive(false);
            Disabled3.SetActive(false);
            Disabled4.SetActive(true);
            Disabled5.SetActive(true);
            Disabled6.SetActive(true);
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

    public void wallFunc(int X, int Y) //Takes cordinates and spawns a wall there, tags the new wall as Duped
    {
        Debug.Log("wallFunc " + X + " " + Y);
        GameObject _wallSpawned = Instantiate(wall);
        _wallSpawned.transform.Rotate(0, -90, 0);
        _wallSpawned.transform.Translate(X, Y, 0);
        _wallSpawned.tag = "Duped";

        _wallCloneFlag = true;
    }

    private void checkWin() //checks for win conditions
    {
        if (currentX >= 7)
        {
            transform.Translate(MoveX, 0, 0);
            Debug.Log("p1 wins");
            Heading.text = "Blue Wins!"; // Changed from normal text to TMPro Header (Using it for multipurpose)
            Heading.color = Color.blue;
            _turn = 2;
            _cardButtons[0].enabled = false;
            _cardButtons[1].enabled = false;
            _cardButtons[2].enabled = false;
            _cardButtons[3].enabled = false;
            _cardButtons[4].enabled = false;
            _cardButtons[5].enabled = false;

        }

        if (currentX <= -7)
        {
            Debug.Log("p2 wins");
            Heading.text = "Red Wins!"; // Changed from normal text to TMPro Header (Using it for multipurpose)
            Heading.color = Color.red;
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

    public void disableCard(GameObject disable)
    {
        if (disable == Disabled1)
        {
            Disabled1.SetActive(true);
        }
        else if (disable == Disabled2)
        {
            Disabled2.SetActive(true);
        }
        else if (disable == Disabled3)
        {
            Disabled3.SetActive(true);
        }
        else if (disable == Disabled4)
        {
            Disabled4.SetActive(true);
        }
        else if (disable == Disabled5)
        {
            Disabled5.SetActive(true);
        }
        else if (disable == Disabled6)
        {
            Disabled6.SetActive(true);
        }
    }

    public void unDisableCard(GameObject disable)
    {
        if (disable == Disabled1)
        {
            Disabled1.SetActive(false);
        }
        else if (disable == Disabled2)
        {
            Disabled2.SetActive(false);
        }
        else if (disable == Disabled3)
        {
            Disabled3.SetActive(false);
        }
        else if (disable == Disabled4)
        {
            Disabled4.SetActive(false);
        }
        else if (disable == Disabled5)
        {
            Disabled5.SetActive(false);
        }
        else if (disable == Disabled6)
        {
            Disabled6.SetActive(false);
        }
    }
}
