using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parentandchildren : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     RecursiveOperation(transform);   
    }

    void RecursiveOperation(Transform currenttransform)
    {
        foreach (Transform child in currenttransform)
        { RecursiveOperation(child); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
