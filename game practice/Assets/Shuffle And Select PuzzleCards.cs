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
    public GameObject Player1PuzzleButton;
    public GameObject Player2PuzzleButton;

    private GameObject player2puzzle;
    private GameObject player1puzzle;




    public void Player1PuzzleCard()
    {
        player1puzzle = PuzzleCards[Random.Range(0, PuzzleCards.Count)];
        Instantiate(player1puzzle, cardposition.position, Quaternion.identity); 
        Destroy(Player1PuzzleButton.gameObject);
       

    }
    public void Player2PuzzleCard()
    {
        player2puzzle = PuzzleCards[Random.Range(0, PuzzleCards.Count)];
        Instantiate(player2puzzle, cardposition.position, Quaternion.identity);
        Destroy(Player2PuzzleButton.gameObject);
    }
    public void HidePuzzleCard()
    {
        player2puzzle.SetActive(false);
        player1puzzle.SetActive(false);
    }

   

    

    public void ShowP2puzzleCard()
    {
        player2puzzle.SetActive(true);

    }

    

   






}
