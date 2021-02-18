using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject bee;
    public GameObject pivot;
    public int obstacle_score = 5;
    public Text highScoreText;
    public Text currentScoreText;

    private int highScore;
    private int currentScore;
    private bool playEnd;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        highScore = 0;
        currentScore = 0;
        playEnd = true;
        startPosition = bee.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playEnd)
        {
            if (Input.GetKeyDown(KeyCode.Space) || OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                ResetBee();
                currentScore = 0;
                UpdateScores();
                pivot.gameObject.SetActive(true);
                playEnd = false;
            }
        }
    }
    public void EndPlay()
    {
        ResetBee();
        pivot.gameObject.SetActive(false);
        playEnd = true;
        if (currentScore > highScore)
        {
            highScore = currentScore;
            UpdateScores();
        }
    }
    public void BeePassedObstacle()
    {
        currentScore += obstacle_score;
        UpdateScores();
    }
    private void ResetBee()
    {
        bee.transform.position = startPosition;
        pivot.transform.rotation = Quaternion.identity;

    }
    private void UpdateScores()
    {
        currentScoreText.text = "Current Score: " + currentScore.ToString();
        highScoreText.text = "High Score: " + highScore.ToString();
    }
}
