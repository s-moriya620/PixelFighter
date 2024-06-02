using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForStartFighting : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(GoToNextScene), 2.5f);
    }
    
    private void GoToNextScene()
    {
        SceneManager.LoadScene("24_2 PlayableSpriteIdlingBeforeFight");
    }
}
