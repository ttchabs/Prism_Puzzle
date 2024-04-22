using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public Transform[] targetSpot; // Assign the target spot in the Unity Editor
    public float snapDistance = 0.5f; 
    private bool isDragging = false;
    private Vector3 offset;

    private float toosmall = 0.35f  ;
    public GameObject player1screen;
    public GameObject player2screen;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.AddComponent<DragAndDrop>();

        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        offset = gameObject.transform.position - GetMouseWorldPosition();
    }

    void OnMouseUp()
    {
        isDragging = false;

        foreach (Transform spots in transform.parent.GetComponent<DragAndDrop>().targetSpot)
        { 
        // Check if the object is close enough to the target spot to snap it into place
            float distance = Vector3.Distance(transform.position, spots.position);
            if (distance <= snapDistance)
             {
                  transform.position = spots.position;
                  break;
            }
    }
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = GetMouseWorldPosition() + offset;
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }

        Vector3 player1Scale = player1screen.transform.localScale;
        Debug.Log(player1Scale);

        if (player1Scale.magnitude <= toosmall)
        {
            isDragging=false;
            Debug.Log("its bigger");
        }

        Vector3 player2Scale = player2screen.transform.localScale;
        Debug.Log(player2Scale);


        if (player2Scale.magnitude <= toosmall)
        {
            isDragging=false ;
            Debug.Log("its bigger");
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}

