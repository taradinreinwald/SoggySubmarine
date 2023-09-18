using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int _score;
   

    public void IncreaseScore(int value)
    {
        _score += value;
        Debug.Log(string.Format("current score is {0}", _score));
    }

}
