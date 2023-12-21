using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newY = Mathf.Max(player.transform.position.y, 11f);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
       
    }
}
