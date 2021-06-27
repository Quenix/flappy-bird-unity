using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{

    public Text textScore;
    public bool isBestScore;

    // Start is called before the first frame update
    void Start()
    {
        Score.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int score = isBestScore ? Score.bestScore : Score.score;

        textScore.text = score.ToString();
    }
}
