using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public Text player1ScoreText;
    public Text player2ScoreText;

    void Start()
    {
        player1ScoreText.text = "Player 1: " + player1Score;
        player2ScoreText.text = "Player 2: " + player2Score;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball_collider"))
        {
            if (other.gameObject.name == "cup_upper_blue_1")
            {
                player1Score++;
                player1ScoreText.text = "Player 1: " + player1Score;
            }
            else if (other.gameObject.name == "cup_upper_red_1")
            {
                player2Score++;
                player2ScoreText.text = "Player 2: " + player2Score;
            }
        }
    }
}