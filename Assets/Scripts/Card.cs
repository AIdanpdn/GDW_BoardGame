using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Card : MonoBehaviour
{
    public void CardPlayed ()
    {
        Debug.Log("Card Played");
        FindObjectOfType<PawnMove>().GetComponent<PawnMove>().Move(1, 0);
    }
}
