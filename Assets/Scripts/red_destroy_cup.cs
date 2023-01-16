using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_destroy_cup : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("red_destroy_cup"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.Player1Scored();
        }
    }
}
