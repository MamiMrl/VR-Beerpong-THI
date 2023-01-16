using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_destroy_cup : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("blue_destroy_cup")){
            Destroy(other.gameObject);
<<<<<<< HEAD
            GameManager.Instance.Player2Scored();
=======
>>>>>>> e75eeec0923cc1b82a7360ffd31392f34fd5b33b
        }
    }
}
