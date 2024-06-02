using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BossSpriteController
{
    public static int ChosenBoss = 1;
    public static int BossRValue = 100;
    public static int BossGValue = 100;
    public static int BossBValue = 100;
    public static int IsSmokeFaceDefeated = 0;
    public static int IsSwapKittyDefeated = 0;
    public static int IsSplitLadyDefeated = 0;
    public static int IsGorillaGraffitiDefeated = 0;
}
public class ScriptForBossInitialization : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (BossSpriteController.IsSmokeFaceDefeated == 0){
            BossSpriteController.ChosenBoss = 1;
        } else if (BossSpriteController.IsSwapKittyDefeated == 0){
            BossSpriteController.ChosenBoss = 0;
        } else {
            BossSpriteController.ChosenBoss = 3;    
        }
    }
}
