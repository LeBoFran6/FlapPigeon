using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class increaseScore : MonoBehaviour
{
    public int scor = 0;

    public Text score;
    public Text finalscore;

    public void augmenterScore()
    {
        scor += 1;
        score.text = scor.ToString();
        finalscore.text = scor.ToString();
    }
}
