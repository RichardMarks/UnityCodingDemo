using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreOnDestroy : MonoBehaviour
{
    public int pointsAwarded;

    ScoreKeeper scoreKeeper;

    private void Awake()
    {
        scoreKeeper = (ScoreKeeper)FindObjectOfType(typeof(ScoreKeeper));
    }

    private void OnDestroy()
    {
        scoreKeeper.AddScore(pointsAwarded);
    }
}
