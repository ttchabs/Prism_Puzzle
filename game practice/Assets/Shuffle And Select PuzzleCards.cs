using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ShuffleAndSelectPuzzleCards : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> PuzzleCards; // List of card game objects
                                         //the list will be filled with the puzzle card game objects
    public Transform cardposition;
    public GameObject Button;
    public Vector3 size = new Vector3(1f, 1f, 0);


    public void selectandchoose()
    {
        GameObject randomgameobject = PuzzleCards[Random.Range(0, PuzzleCards.Count)];
        Instantiate(randomgameobject, cardposition.position, Quaternion.identity);
        Button.SetActive(false);
        randomgameobject.transform.localScale -= new Vector3 (size.x, size.y, size.z);

    }

}
