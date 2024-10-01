using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    [SerializeField]
    private ScoreChanger scoreChanger;  

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);  
    }

    void OnTriggerEnter(Collider other)
    {
        if (scoreChanger != null)  
        {
            scoreChanger.AddScore();  
        }

        Destroy(gameObject);  
    }
}
