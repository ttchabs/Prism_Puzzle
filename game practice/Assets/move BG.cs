using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBG : MonoBehaviour
{
    public Transform Player1BG;
    public Transform Player2BG;

    public Transform leftoffscreen;
    public Transform rightOffscreen;
    public Transform center;
    public void moveBG2tocenter()
    {
        Player2BG.position = center.position;
        Player1BG.position = leftoffscreen.position;
    }
    public void moveBG1tocenter()
    {
        Player1BG.position = center.position;
        Player2BG.position = rightOffscreen.position;

    }
}
