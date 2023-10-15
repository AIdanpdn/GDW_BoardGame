using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cardFunc : MonoBehaviour
{
    /* this is the script that cardPlay calls to have all the card Functions*/
    [SerializeField] private GameObject inputBox;
    [SerializeField] public TMP_Text Text;
    [SerializeField] public TMP_Text Heading;
    [SerializeField] private InputField InputFieldX;
    [SerializeField] private InputField InputFieldY;
    private int IntX;
    private int IntY;
    private int InputValueX;
    private int InputValueY;
    private int lookForKey = 0;

    [SerializeField] private cardPlay cardPlay1;
    [SerializeField] private cardPlay cardPlay2;
    [SerializeField] private cardPlay cardPlay3;
    [SerializeField] private cardPlay cardPlay4;
    [SerializeField] private cardPlay cardPlay5;
    [SerializeField] private cardPlay cardPlay6;

    [SerializeField] private PawnMove pawnMove;
    

    public void Start() //Hides the input box at the start (in case it isnt alr disabled)
    {
        inputBox.SetActive(false);
    }

    //Card functions so far only moves the pawn towards red side (reds cards will simply multiply these values by -1)
    public void card0()
    {
        pawnMove.Move(0, 0);
        Debug.Log("cardFunc 0");
    }
    public void card1() // 1 forward
    {
        pawnMove.Move(1, 0);
        Debug.Log("cardFunc 1");
    }    
    public void card2() // 1 up
    {
        pawnMove.Move(0, 1);
        Debug.Log("cardFunc 2");
    }
    public void card3() // 1 down
    {
        pawnMove.Move(0, -1); 
        Debug.Log("cardFunc 3");
    }
    public void card4() // 2 forward
    {
        pawnMove.Move(2, 0);
        Debug.Log("cardFunc 4");
    }
    public void card6() // 2 up
    {
        pawnMove.Move(0, 2);
        Debug.Log("cardFunc 6");
    }
    public void card7() // 2 down
    {
        pawnMove.Move(0, -2);
        Debug.Log("cardFunc 7");
    }

    public void wallTemp() //ALL WALL STUFF DO NOT MESS WITH, CARD 5 IS WALL
    {
        InputFieldX.enabled = true;
        InputFieldY.enabled = true;
        inputBox.SetActive(true); // INPUT BOX AS A WHOLE
        Heading.enabled = false;
        lookForKey = 1;
        
    }
    private void Update()
    {
        if (lookForKey == 1)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                IntX = int.Parse(InputFieldX.text);
                IntY = int.Parse(InputFieldY.text);
                InputValueX = int.Parse(InputFieldX.text) - 7;
                InputValueY = int.Parse(InputFieldY.text) - 3;
                if (IntX < 1 || IntX > 13 || IntY < 1 || IntY > 5) // Check for bad input and write error msg
                {
                    Debug.Log("ERROR!");
                    Text.text = "Error! Try again!\nPress [Enter] to place wall";
                }
                else
                {
                    pawnMove.wallFunc(InputValueX, InputValueY);
                    lookForKey = 0;
                    InputFieldX.text = ("");
                    InputFieldY.text = ("");
                    Text.text = "Press [Enter] to place wall\nPress [Esc] to cancel"; // Reset text
                    inputBox.SetActive(false);
                    Heading.enabled = true;
                    lookForKey = 0;
                }
            }
            else if (Input.GetKey(KeyCode.Escape))
            {
                inputBox.SetActive(false);
                Heading.enabled = true;
                lookForKey = 0;
                cardPlay1.CancelCard();
                cardPlay2.CancelCard();
                cardPlay3.CancelCard();
                cardPlay4.CancelCard();
                cardPlay5.CancelCard();
                cardPlay6.CancelCard();
            }
        }
        
    }
}
