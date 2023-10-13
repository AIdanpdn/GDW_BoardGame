using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallFunc : MonoBehaviour
{
    private float _wallX;
    private float _wallY;
    private GameObject[] _isCloned;

    [SerializeField] private PawnMove _pawnMove;
    
    private void Cloned()
    {
        _wallX = transform.position.x;
        _wallY = transform.position.y;
        
    }

    void Update()
    {
        _isCloned = GameObject.FindGameObjectsWithTag("Duped");

        if (_pawnMove._wallCloneFlag == true)
        {
            Cloned();
        }

        if (_pawnMove.currentX == _wallX && _pawnMove.currentY == _wallY && tag == "Duped")
        {
            _pawnMove.Move(-1, 0);
        }

    }
}
