using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager Instance;

    public TextMeshProUGUI ScoreUi;

    public int ScorePlayerBlue;
    public int ScorePlayerRed;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        ScorePlayerBlue = 0;
        ScorePlayerRed = 0;

        UpdateScoreBoard();
    }

    // Update is called once per frame
    void Update()
    {

        UpdateScoreBoard();


    }
    
    public void Player1Scored()
    {
        ScorePlayerRed = ScorePlayerRed + 1;
        UpdateScoreBoard();
    }

    public void Player2Scored()
    {
        ScorePlayerBlue = ScorePlayerBlue + 1;
        UpdateScoreBoard();
    }


    public void UpdateScoreBoard()
    {
        string score_txt = ScorePlayerBlue + " x " + ScorePlayerRed;

        if(ScorePlayerBlue == 10)
        {
            score_txt = "Player Blue Won!";
        }

        if (ScorePlayerRed == 10)
        {
            score_txt = "Player Blue Won!";
        }

        // get the text meshpro ui
        // set score_text

        ScoreUi.text = score_txt;
    }

}
