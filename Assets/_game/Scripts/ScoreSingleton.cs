using TMPro;
using UnityEngine;

public class ScoreSingleton : MonoBehaviour
{
    #region Singleton
    public static ScoreSingleton Instance;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            DestroyImmediate(gameObject);
            return;
        }
        Instance = this;
    }
    #endregion

    private int score;
    public TMP_Text scoreText;
    public TMP_Text winnerMsg;
    public void scoreModify(int points)
    {
        score += points;
        scoreText.text = score.ToString();

        if (score >= 27)
        {
            winnerMsg.text = "¡Felicidades!\n Ha superado los 27 puntos y ganado el juego";
        }

    }
}