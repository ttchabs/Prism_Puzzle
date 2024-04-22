using UnityEngine;
using UnityEngine.UI;

public class PlayerSwitch : MonoBehaviour
{
    public Transform Player1;
    public Transform Player2;

    public Transform resizedscreen;
    public Transform center;

    public Vector3 size = new Vector3( 1f, 1f,0);

    public GameObject p1button;
    public GameObject p2button;

    public GameObject p1Showbutton;
    public GameObject p2Showbutton;

    public GameObject P1Pattern;
    public GameObject P2Pattern;

    public GameObject StartButton;
    public GameObject StartScreen;
   

   public void Swaptoplayer2()
    {
        Player1.position = resizedscreen.position;
        Player1.transform.localScale -= size;
        Player2.position = center.position;
        Player2.transform.localScale += size;
        p1button.SetActive(true);
        p2button.SetActive(false);
        p1Showbutton.SetActive(false);
        p2Showbutton.SetActive(true);
        P1Pattern.SetActive(false);
        


    }

   public void Swaptoplayer1()
    {
        Player2.position = resizedscreen.position;
        Player2.transform.localScale -= size ;
        Player1.position = center.position;
        Player1.transform.localScale += size ;
        p1button.SetActive(false);
        p2button.SetActive(true);
        p1Showbutton.SetActive(true);
        p2Showbutton.SetActive(false);
        P2Pattern.SetActive(false);

        
    }

    private void Start()
    {
        p2button.SetActive (false);
        P1Pattern.SetActive (false);
        P2Pattern.SetActive (false);
        p2Showbutton.SetActive(false);

    }

    public void P1Show()
    {
        P1Pattern.SetActive (true);
    }

    public void P2Show()
    {
        P2Pattern.SetActive (true);
    }

    public void StartGmae()
    {
        StartButton.SetActive(false);
        StartScreen.SetActive(false);
        p1button.SetActive(true);
        p2Showbutton.SetActive(true);
    }
}
