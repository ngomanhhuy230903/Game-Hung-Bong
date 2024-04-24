using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;
    float m_spawmTime;
    int m_Score;
    UIManager m_ui;
    public int Score
    {
        get; set;
    }
    public bool IsGameOver
    {
        get; set;
    }
    public void IncreseScore()
    {
        m_Score++;
        m_ui.setScore("Score: " + m_Score);
    }
    public void SpawnBall()
    {
        Vector2 spawnB = new Vector2(Random.Range(-8, 8), 6);
        
        if (ball)
        {
            Instantiate(ball, spawnB, Quaternion.identity);
        }
    }
    public void PlayAgain()
    {
        m_Score = 0;
        IsGameOver = false;
        m_ui.setScore("Score: " + m_Score);
        m_ui.ShowGameOverPanel(false);

    }

    // Start is called before the first frame update
    void Start()
    {
        m_spawmTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.setScore("Score: " + m_Score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawmTime -= Time.deltaTime;
        if (IsGameOver)
        {
            m_spawmTime = 0;
            m_ui.ShowGameOverPanel(true);
            return;
        }
        if (m_spawmTime <= 0)
        {
            SpawnBall();
            m_spawmTime = spawnTime;
        }
    }
}
