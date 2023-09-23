using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnMove : MonoBehaviour
{
    public int MoveX;
    public int MoveY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(int MoveX, int MoveY) 
    {
        
        transform.Translate(MoveX, MoveY, 0);
        Debug.Log("Pawn moved");
    }
}
