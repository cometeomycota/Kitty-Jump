using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 7f;  
    public string levelToRestart;  
    public float xValue1;
    public float xValue2;
 
     void Start()
    {
     
    }
    void Update()

    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x > xValue1 || transform.position.x < xValue2)
        {
            speed *= -1; 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
           
            SceneManager.LoadScene(levelToRestart);
            
        }
    }
}