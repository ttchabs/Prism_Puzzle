using UnityEngine;
using UnityEngine.UI;

public class PlayerSwitch : MonoBehaviour
{
    public Transform Player1;
    public Transform Player2;

    public Transform Player1BG;
    public Transform Player2BG;

    public Transform resizedscreen;
    public Transform center;
    public Transform centerBG;

    public Vector3 size = new Vector3( 1f, 1f,0);
    public GameObject Player2PuzzleButton;

    public GameObject p1button;
    public GameObject p2button;

    public GameObject p1Showbutton;
    public GameObject p2Showbutton;

    public GameObject StartButton;
    public GameObject StartScreen;

    public GameObject PuzzleCardSelector;
    public GameObject Player2PatternButton;

    public Transform leftoffscreen;
    public Transform rightOffscreen;

    public ShuffleAndSelectPuzzleCards PatternCardsScript;

    


    private void Start()
    {
        p1button.SetActive(false);
        p2Showbutton.SetActive(false);
        p1Showbutton.SetActive(false);
        PuzzleCardSelector.SetActive(false);
        Player2PatternButton.SetActive(false);
        

        PatternCardsScript = FindObjectOfType<ShuffleAndSelectPuzzleCards>();


    }



    public void Swaptoplayer2()
    {
        Player1BG.position = leftoffscreen.position;
        Player2BG.position = centerBG.position;
        Player1.position = resizedscreen.position;
        Player1.transform.localScale -= size;
        Player2.position = center.position;
        Player2.transform.localScale += size;


        p1button.SetActive(true);
        p2button.SetActive(false);
        p1Showbutton.SetActive(false);
        p2Showbutton.SetActive(true);
        Player2PatternButton.SetActive(true);


        PatternCardsScript.HidePuzzleCard();
        Player2PuzzleButton.SetActive(true);

    }

   public void Swaptoplayer1()
    {
        Player2.position = resizedscreen.position;
        Player2.transform.localScale -= size ;
        Player1.position = center.position;
        Player1.transform.localScale += size ;
        Player1BG.position = centerBG.position;
        Player2BG.position = rightOffscreen.position;

        p1button.SetActive(false);
        p2button.SetActive(true);
        p1Showbutton.SetActive(true);
        p2Showbutton.SetActive(false);


        
        


    }

    public void StartGmae()
    {
        StartButton.SetActive(false);
        StartScreen.SetActive(false);
        p2button.SetActive(true);
        p1Showbutton.SetActive(true);
        PuzzleCardSelector.SetActive(true);
       

    }
}
