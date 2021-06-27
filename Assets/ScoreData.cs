using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ScoreData
{
    public int bestScore;

    public ScoreData()
    {
        bestScore = Score.bestScore;
    }
}
