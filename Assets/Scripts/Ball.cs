using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc;
    private void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player")){
            m_gc.IncreseScore();
            Destroy(gameObject);
            Debug.Log("va cham voi Player");
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("DeathZone"))
        {
            m_gc.IsGameOver = true;
            Destroy(gameObject);
            Debug.Log("va cham voi DeathZone");
        }
    }
}
