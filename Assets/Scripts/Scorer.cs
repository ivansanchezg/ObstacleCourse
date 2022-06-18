using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int Score { get; private set; } = 0;

    public void IncreaseScore()
    {
        Score += 1;
        Debug.Log($"Score: {Score}");
    }
}
