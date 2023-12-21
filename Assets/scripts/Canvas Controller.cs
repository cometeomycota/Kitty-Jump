using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public Canvas canvas; // Reference to your Canvas
    // Start is called before the first frame update
    void Start()
    {
        
    }

  

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            canvas.gameObject.SetActive(false);
        }
    }
}
