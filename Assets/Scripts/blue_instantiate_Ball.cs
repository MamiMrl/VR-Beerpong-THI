using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Photon.Realtime;

public class blue_instantiate_Ball : MonoBehaviourPunCallbacks
{
    public float timeDuration = 10.0f;
    Vector3 player_blue_location; // Player blue ball spawn location.
    public GameObject blue_ping_pong_ball;
    public GameObject Bowl_Blue;

    public Transform InitialPosition;

    IEnumerator Startx(){
        player_blue_location = Bowl_Blue.transform.position;
        while (true){
            GameObject bluePingPongBallInstance = Instantiate(blue_ping_pong_ball, player_blue_location, Quaternion.identity);
            // Destroying the ball after the specified time duration.
            Destroy(bluePingPongBallInstance, timeDuration);
            // Wait for the specified time duration before instantiating the next ball.
            yield return new WaitForSeconds(timeDuration);
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnBalls());
    }


    private IEnumerator SpawnBalls()
    {


        while (true)
        {

            if (PhotonNetwork.IsMasterClient == false)
            {
                yield return new WaitForSeconds(timeDuration);
                continue;
            }

            //GameObject bluePingPongBallInstance = Instantiate(blue_ping_pong_ball, InitialPosition.position, Quaternion.identity);

            var ball = PhotonNetwork.Instantiate(blue_ping_pong_ball.name, InitialPosition.position, Quaternion.identity);
            yield return new WaitForSeconds(timeDuration);
            PhotonNetwork.Destroy(ball);
            //Destroy(bluePingPongBallInstance, timeDuration);
            yield return new WaitForSeconds(1.0f);
        }
    }


}