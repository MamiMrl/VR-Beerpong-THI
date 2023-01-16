using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_destroy_cup : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("blue_destroy_cup")){
            Destroy(other.gameObject);
            GameManager.Instance.Player2Scored();
        }
    }
}
