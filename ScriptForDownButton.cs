using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForDownButton : MonoBehaviour
{
    public void ChangeScreenForDownButton()
    {
        if (SceneManager.GetActiveScene().name == "00 OpeningScene")
        {
            //SceneManager.LoadScene("TestGPS"); //For GPS Test
            // SceneManager.LoadScene("90 AudioManagerForIntroduction");
            SceneManager.LoadScene("01 IntroductionScene");
        }
        else if (SceneManager.GetActiveScene().name == "11 MainScene")
        {
            if (TutorialController.HasPreBattleIntroductionShown == 0) 
            {
                SceneManager.LoadScene("04 PreBattleIntroductionScene");
                TutorialController.HasPreBattleIntroductionShown = 1;
            } else  {
                SceneManager.LoadScene("12 PreBattleScene");
            }
        }
        else if (SceneManager.GetActiveScene().name == "12 PreBattleScene")
        {
            if (TutorialController.HasRefreshSpriteIntroductionShown == 0) 
            {
                SceneManager.LoadScene("05 RefreshSpriteIntroductionScene");
                TutorialController.HasRefreshSpriteIntroductionShown = 1;
            } else  {
                SceneManager.LoadScene("13 PreRefreshSpriteScene");
            }
        }
        else if (SceneManager.GetActiveScene().name == "13 PreRefreshSpriteScene")
        {
            SceneManager.LoadScene("11 MainScene");
        }
        else if (SceneManager.GetActiveScene().name == "21 BossMapScene")
        {
            SceneManager.LoadScene("12 PreBattleScene");
        }
        else if (SceneManager.GetActiveScene().name == "25_1 AttackScanningScene")
        {
            if (AttackColorController.AttackColor == 0){
                AttackColorController.AttackColor = 1;
            } else if (AttackColorController.AttackColor == 1){
                AttackColorController.AttackColor = 2;
            } else if (AttackColorController.AttackColor == 2){
                AttackColorController.AttackColor = 0;
            }
        }
    }
}
