using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ShuffleAndSelectPuzzleCards : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> PuzzleCards; // List of card game objects
                                         //the list will be filled with the puzzle card game objects
    public Transform card1position;
    public Transform card2position;

    public GameObject Player1PuzzleButton;
    public GameObject Player2PuzzleButton;

    private GameObject player2puzzle;
    private GameObject player1puzzle;

    public Transform PLayer1Parent;
    public Transform PLayer2Parent;



    public void Player1PuzzleCard()
    {
        player1puzzle = PuzzleCards[Random.Range(0, PuzzleCards.Count)];
        Instantiate(player1puzzle, card1position.position, Quaternion.identity, card1position.transform);
      //  player1puzzle.transform.parent = card1position.transform;
    
        Player1PuzzleButton.SetActive(false);
        card1position.GetChild(0).gameObject.SetActive(false);



    }
    public void Player2PuzzleCard()
    {
        player2puzzle = PuzzleCards[Random.Range(0, PuzzleCards.Count)];
        Instantiate(player2puzzle, card2position.position, Quaternion.identity, card2position.transform);
        //player2puzzle.transform.parent = card2position;
        player1puzzle.SetActive(false);
        card2position.GetChild(0).gameObject.SetActive(false);

        Destroy(Player2PuzzleButton.gameObject);
    }

    public void ShowP1pattern()
    {
        card1position.GetChild(0).gameObject.SetActive(true);
       // player1puzzle.SetActive(true);
        Debug.Log("puzzle shown");
    }

    public void ShowP2pattern()
    {
        card2position.GetChild(0).gameObject.SetActive(true);

       // player2puzzle.SetActive(true);
    }
}
