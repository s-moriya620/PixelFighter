using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForGetValueAndEXPByScanningColor : MonoBehaviour
{
    void Start()
    {
        GetRValue();
        GetEXP();
    }
    public void GetRValue()
    {
        PlayableSpriteController.RValue += 5;
    }
    public void GetEXP()
    {
        if (PlayableSpriteController.EvoLevel < 2){
            PlayableSpriteController.EXP -= 100;
            if (PlayableSpriteController.EXP <= 0) {
                PlayableSpriteController.EXP += 1000;
                if (DemoModeController.IsDemoModeOn == 0) {
                    SceneManager.LoadScene("43 SpriteEvolutionScene");
                }               
            }
        }
    }
}
