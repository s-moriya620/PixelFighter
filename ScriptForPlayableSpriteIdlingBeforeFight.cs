using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForPlayableSpriteIdlingBeforeFight : MonoBehaviour
{
    void Start()
    {
        Invoke(nameof(GoToNextScene), 2.0f);
    }
    
    private void GoToNextScene()
    {
        SceneManager.LoadScene("25_0 AttackColorCapturingScene");
    }
}
