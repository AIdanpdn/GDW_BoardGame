using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardSprite : MonoBehaviour
{
    public Sprite[] _cardSprite;
    public Image _cardImage;
    [SerializeField] private cardPlay cardPlay;

    private void Update() //will be where the card sprite gets updated (Could be better ngl)
    {
        if (cardPlay._cardId == 0)
        {
            _cardImage.sprite = _cardSprite[0];
        }
        else if (cardPlay._cardId == 1)
        {
            _cardImage.sprite = _cardSprite[1];
        }
        else if (cardPlay._cardId == 2)
        {
            _cardImage.sprite = _cardSprite[2];
        }

        else if (cardPlay._cardId == 3)
        {
            _cardImage.sprite = _cardSprite[3];
        }

        else if (cardPlay._cardId == 4)
        {
            _cardImage.sprite = _cardSprite[4];
        }

        else if (cardPlay._cardId == 5)
        {
            _cardImage.sprite = _cardSprite[5];
        }

        else if (cardPlay._cardId == 6)
        {
            _cardImage.sprite = _cardSprite[6];
        }

        else if (cardPlay._cardId == 7)
        {
            _cardImage.sprite = _cardSprite[7];
        }
    }


}
    