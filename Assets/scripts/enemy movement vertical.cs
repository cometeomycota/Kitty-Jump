using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemymovementvertical : MonoBehaviour
{
    public float speed = 7f;
    public string levelToRestart;
    public float yValue;
    public float yValue2;
    private void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {

        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > yValue || transform.position.y < yValue2)
        {
            speed *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the enemy collides with the player
        if (other.CompareTag("Player"))
        {
            // Restart the level
            SceneManager.LoadScene(levelToRestart);
        }
    }
}