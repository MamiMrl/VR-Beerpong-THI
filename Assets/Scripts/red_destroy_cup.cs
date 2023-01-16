using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_destroy_cup : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
<<<<<<< HEAD
        if(other.CompareTag("red_destroy_cup"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.Player1Scored();
=======
        if(other.CompareTag("red_destroy_cup")){
            Destroy(other.gameObject);
>>>>>>> e75eeec0923cc1b82a7360ffd31392f34fd5b33b
        }
    }
}
