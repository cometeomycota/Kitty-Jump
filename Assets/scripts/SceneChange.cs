using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string targetSceneName; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered!");
       
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Loading scene: " + targetSceneName);
           
            SceneManager.LoadScene(targetSceneName);
        }
    }

}