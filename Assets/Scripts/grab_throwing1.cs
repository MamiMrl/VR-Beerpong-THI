// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class grab : MonoBehaviour
// {
//     List<GameObject> objects = new List<GameObject>();

//     bool isHolding = false;

//     // Update is called once per frame
//     void Update()
//     {
//        if (OVRInput.Get(OVRInput.RawButton.LHandTrigger) && !isHolding)
//        {    
//             isHolding = true;
//             foreach (GameObject go in objects)
//             {
//                 go.transform.parent = transform;
//                 if (go.GetComponent<Rigidbody>())
//                 {
//                     Rigidbody rb = go.GetComponent<Rigidbody>();
//                     rb.isKinematic = true;
//                     rb.useGravity = false;

//                 }
//             }
//        }  else if (!OVRInput.Get(OVRInput.RawButton.LHandTrigger) && isHolding)
//        {
//             isHolding = false;
//             foreach (GameObject go in objects)
//             {
//                 if (go.GetComponent<Rigidbody>())
//                 {
//                     Rigidbody rb = go.GetComponent<Rigidbody>();
//                     rb.isKinematic = false;
//                     rb.useGravity = true;
//                     rb.velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch);
//                 }
//             }
//             transform.DetachChildren();
//        }
//     }

//     void OnTriggerEnter(Collider col)
//     {
//         objects.Add(col.gameObject);
//     }

//     void OnTriggerExit(Collider col)
//     {
//         objects.Remove(col.gameObject);
//     }
// }
