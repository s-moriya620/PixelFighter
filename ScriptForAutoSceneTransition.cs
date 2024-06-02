using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForAutoSceneTransition : MonoBehaviour
{
    void Start()
    {
        float TimeToTransition = 0.0f;
        if (SceneManager.GetActiveScene().name == "11 MainScene") {
            TimeToTransition = 4.5f;
        } else if (SceneManager.GetActiveScene().name == "27_1 PlayableSpriteLosingScene") {
            TimeToTransition = 7.0f;
        } else if (SceneManager.GetActiveScene().name == "41 RefreshSpriteScene") {
            TimeToTransition = 7.0f;
        }
        Invoke(nameof(GoToNextScene), TimeToTransition);
    }
    private void GoToNextScene()
    {
        if (SceneManager.GetActiveScene().name == "11 MainScene") {
            SceneManager.LoadScene("15 ColorValueCapturingScene");
        } else if (SceneManager.GetActiveScene().name == "27_1 PlayableSpriteLosingScene") {
            SceneManager.LoadScene("11 MainScene");
        } else if (SceneManager.GetActiveScene().name == "41 RefreshSpriteScene") {
            SceneManager.LoadScene("31 PlayableSpriteMapScene");
        }
    }
}
