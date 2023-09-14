using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int _score;
   List<Collectable> collectables = new List<Collectable>();
    List<GameObject> otherObjects = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddObjects(GameObject gamePiece)
    {
        otherObjects.Add(gamePiece);
    }
    void RemoveObject(GameObject gamePiece)
    {
        otherObjects?.Remove(gamePiece);
    }
    void AddCollectable(Collectable newCollectable)
    {
        collectables.Add(newCollectable);
    }
    void RemoveCollectable(Collectable deadCollectable)
    {
        collectables?.Remove(deadCollectable);
    }

    public void IncreaseScore(int value)
    {
        _score += value;
        Debug.Log(string.Format("current score is {0}", _score));
    }

}
