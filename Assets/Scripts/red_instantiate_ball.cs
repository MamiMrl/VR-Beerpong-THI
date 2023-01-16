using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_instantiate_ball : MonoBehaviour
{
    public float timeDuration = 10.0f;
    Vector3 player_red_location; // Player blue ball spawn location.
    public GameObject red_ping_pong_ball;
    public GameObject Bowl_Red;

    public Transform InitialPosition;

    IEnumerator Startx()
    {
        player_red_location = Bowl_Red.transform.position;
        while (true)
        {
            GameObject redPingPongBallInstance = Instantiate(red_ping_pong_ball, player_red_location, Quaternion.identity);
            // Destroying the ball after the specified time duration.
            Destroy(redPingPongBallInstance, timeDuration);
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
            GameObject bluePingPongBallInstance = Instantiate(red_ping_pong_ball, InitialPosition.position, Quaternion.identity);
            yield return new WaitForSeconds(timeDuration);
            Destroy(bluePingPongBallInstance, timeDuration);
            yield return new WaitForSeconds(1.0f);
        }
    }


}