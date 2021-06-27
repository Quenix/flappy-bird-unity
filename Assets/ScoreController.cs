using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;

        if (Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }

    }
}
