using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int playerLives;

    public void UpdatePlayerLives(int amount)
    {
        playerLives += amount;
    }
}
