using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForSelectButton : MonoBehaviour
{
    public void ChangeScreenForSelectButton()
    {
        if (SceneManager.GetActiveScene().name == "00 OpeningScene")
        {
            
            if (DemoModeController.IsDemoModeOn == 1){
                SceneManager.LoadScene("06 PlayableSpriteMapFirstTimeScene");
            } else {
                SceneManager.LoadScene("01 IntroductionScene");
            }
        }
        else if (SceneManager.GetActiveScene().name == "06 PlayableSpriteMapFirstTimeScene")
        {
            SceneManager.LoadScene("07 PlayableSpriteMapCapturingFirstTimeScene");
        }
        else if (SceneManager.GetActiveScene().name == "07 PlayableSpriteMapCapturingFirstTimeScene")
        {
            SceneManager.LoadScene("08 PlayableSpriteScanningFirstTimeScene");
        }
        else if (SceneManager.GetActiveScene().name == "08 PlayableSpriteScanningFirstTimeScene")
        {
            SceneManager.LoadScene("09 GetSpriteFirstTimeScene");
        }
        else if (SceneManager.GetActiveScene().name == "09 GetSpriteFirstTimeScene")
        {
            if (DemoModeController.IsDemoModeOn == 1){
                SceneManager.LoadScene("11 MainScene");
            } else {
                SceneManager.LoadScene("03 MainSceneIntroductionScene");
            }
        }   
        else if (SceneManager.GetActiveScene().name == "11 MainScene")
        {
            SceneManager.LoadScene("14 StatusScene");
        }
        else if (SceneManager.GetActiveScene().name == "12 PreBattleScene")
        {
            SceneManager.LoadScene("21 BossMapScene");
        }
        else if (SceneManager.GetActiveScene().name == "13 PreRefreshSpriteScene")
        {
            SceneManager.LoadScene("41 RefreshSpriteScene");
        }
        else if (SceneManager.GetActiveScene().name == "14 StatusScene")
        {
            SceneManager.LoadScene("11 MainScene");
        }
        else if (SceneManager.GetActiveScene().name == "15 ColorValueCapturingScene")
        {
            SceneManager.LoadScene("16 ColorValueScanningScene");
        }
        else if (SceneManager.GetActiveScene().name == "16 ColorValueScanningScene")
        {
            SceneManager.LoadScene("17 GetColorScene");
        }
        else if (SceneManager.GetActiveScene().name == "17 GetColorScene")
        {
            SceneManager.LoadScene("11 MainScene");
        }
        else if (SceneManager.GetActiveScene().name == "21 BossMapScene")
        {
            SceneManager.LoadScene("22 BossMapCapturingScene");
        }
        else if (SceneManager.GetActiveScene().name == "22 BossMapCapturingScene")
        {
            SceneManager.LoadScene("23 BossScanningScene");
        }
        else if (SceneManager.GetActiveScene().name == "23 BossScanningScene")
        {
            SceneManager.LoadScene("24_0 BossAppearingScene");
        }
        else if (SceneManager.GetActiveScene().name == "24_0 BossAppearingScene")
        {
            SceneManager.LoadScene("24_1 StartFightingScene");
        }
        else if (SceneManager.GetActiveScene().name == "24_1 StartFightingScene")
        {
            SceneManager.LoadScene("24_2 PlayableSpriteIdlingBeforeFight");
        }
        else if (SceneManager.GetActiveScene().name == "24_2 PlayableSpriteIdlingBeforeFight")
        {
            SceneManager.LoadScene("25_0 AttackColorCapturingScene");
        }
        else if (SceneManager.GetActiveScene().name == "25_0 AttackColorCapturingScene")
        {
            SceneManager.LoadScene("25_1 AttackScanningScene");
        }
        else if (SceneManager.GetActiveScene().name == "25_1 AttackScanningScene")
        {
            SceneManager.LoadScene("26_0 PlayableSpriteAttackingScene");
        }
        else if (SceneManager.GetActiveScene().name == "26_0 PlayableSpriteAttackingScene")
        {
            SceneManager.LoadScene("26_1 BossSpriteAttackingScene");
        }
        else if (SceneManager.GetActiveScene().name == "26_1 BossSpriteAttackingScene")
        {
            if (AttackColorController.DidPlayerWin == 1){
                SceneManager.LoadScene("26_2 AttackMeetingWinScene");
            } else if (AttackColorController.DidPlayerWin == 0){
                SceneManager.LoadScene("26_3 AttackMeetingLoseScene");
            }
        }
        else if (SceneManager.GetActiveScene().name == "26_2 AttackMeetingWinScene")
        {
            SceneManager.LoadScene("26_4 BossAttackedScene");
        }
        else if (SceneManager.GetActiveScene().name == "26_3 AttackMeetingLoseScene")
        {
            SceneManager.LoadScene("26_5 PlayableSpriteAttackedScene");
        }
        else if (SceneManager.GetActiveScene().name == "26_4 BossAttackedScene")
        {
            SceneManager.LoadScene("27_0 BossDefeatedScene");
        }
        else if (SceneManager.GetActiveScene().name == "26_5 PlayableSpriteAttackedScene")
        {
            SceneManager.LoadScene("27_1 PlayableSpriteLosingScene");
        }
        else if (SceneManager.GetActiveScene().name == "27_0 BossDefeatedScene")
        {
            SceneManager.LoadScene("27_2 PlayableSpriteWinningScene");
        }
        else if (SceneManager.GetActiveScene().name == "27_1 PlayableSpriteLosingScene")
        {
            SceneManager.LoadScene("24_0 BossAppearingScene");
        }
        else if (SceneManager.GetActiveScene().name == "27_2 PlayableSpriteWinningScene")
        {
            if (PlayableSpriteController.EvoLevel == 2){
                SceneManager.LoadScene("11 MainScene");
            } else {
                if (DemoModeController.IsDemoModeOn == 0) {
                    if (PlayableSpriteController.EXP <= 0) {
                        PlayableSpriteController.EXP = PlayableSpriteController.EXP + 1000;
                        SceneManager.LoadScene("43 SpriteEvolutionScene");
                    } else{
                        SceneManager.LoadScene("11 MainScene");
                    } 
                } else {
                    SceneManager.LoadScene("43 SpriteEvolutionScene");                   
                }
            }       
        }
        else if (SceneManager.GetActiveScene().name == "31 PlayableSpriteMapScene")
        {
            SceneManager.LoadScene("32 PlayableSpriteMapCapturingScene");
        }
        else if (SceneManager.GetActiveScene().name == "32 PlayableSpriteMapCapturingScene")
        {
            SceneManager.LoadScene("33 PlayableSpriteScanningScene");
        }
        else if (SceneManager.GetActiveScene().name == "33 PlayableSpriteScanningScene")
        {
            SceneManager.LoadScene("42 GetSpriteScene");
        }
        else if (SceneManager.GetActiveScene().name == "41 RefreshSpriteScene")
        {
            SceneManager.LoadScene("13 PreRefreshSpriteScene");
        }
        else if (SceneManager.GetActiveScene().name == "42 GetSpriteScene")
        {
            SceneManager.LoadScene("11 MainScene");
        }
        else if (SceneManager.GetActiveScene().name == "43 SpriteEvolutionScene")
        {
            SceneManager.LoadScene("11 MainScene");
        }
    }
}
