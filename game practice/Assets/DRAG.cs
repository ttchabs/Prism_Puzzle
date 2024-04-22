using System.Runtime.CompilerServices;
using UnityEngine;

public class DoubleClick : MonoBehaviour
{
    private const float doubleclicktime = 0.5f;
    private float lastclicktime;
    public Transform Discard;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > lastclicktime)
            {
                Ondoubleclick();
            }

            else
            {
                lastclicktime = Time.time;
            }
        }
    }

    void Ondoubleclick()
    {
        transform.position = Discard.position;
    }

    
}
