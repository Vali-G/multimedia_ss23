using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControllerJR : MonoBehaviour
{

    [Header("References")]
    public GameObject startBoundaries;
    public Timer timer;
    public Transform PosPlayer1;
    public Transform PosPlayer2;
    public float playerHeight;
    public LayerMask whatIsGoal;
    public TextMeshProUGUI winnerText;
    public TextMeshProUGUI timeOfWinnerText;
    public GameObject HUD;
    public bool gameOver;

    private bool wonP1;
    private bool wonP2;

    // Start is called before the first frame update
    void Start()
    {
        wonP1 = false;
        wonP2 = false;
        gameOver = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        checkForWin();
        if(wonP1)
        {
            EndGame("Player 1");
        }
        else if(wonP2)
        {
            EndGame("Player 2");
        }
    
    }

    public void BeginGame()
    {
        startBoundaries.SetActive(false);
        timer.StartTimer();
    }

    private void checkForWin()
    {
        wonP1 = Physics.Raycast(PosPlayer1.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGoal);
        wonP2 = Physics.Raycast(PosPlayer2.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGoal);
    }

    public void EndGame(string winner)
    {
        HUD.SetActive(false);
        gameOver = true;
        winnerText.text = winner + " won!";
        timeOfWinnerText.text = timer.currentTime.ToString("0.00") + " time";
        enabled = false;
    }
}
