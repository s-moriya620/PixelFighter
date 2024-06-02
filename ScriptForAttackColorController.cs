using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AttackColorController
{
    public static int AttackColor = 0;
    public static int BossAttackColor = 0;
    public static int DidPlayerWin = 1;
}

public class ScriptForAttackColorController : MonoBehaviour
{
    public int ValueToGetResultOfFight;
    public GameObject canvas;
    public GameObject RedScanning;
    public GameObject GreenScanning;
    public GameObject BlueScanning;
    void Start()
    {
        int RandomNumberForBossSttack = Random.Range(0, 3);
        if (DemoModeController.IsDemoModeOn == 1){
            AttackColorController.BossAttackColor = 1;
        } else {
            AttackColorController.BossAttackColor = RandomNumberForBossSttack;
        }
    }
    void Update(){
        ValueToGetResultOfFight = (AttackColorController.AttackColor - AttackColorController.BossAttackColor + 3) % 3; // 0 -> draw; 1 -> lose; 2 -> win
        if (ValueToGetResultOfFight == 0){
            if (AttackColorController.AttackColor == 0){
                if (PlayableSpriteController.RValue > BossSpriteController.BossRValue){
                    AttackColorController.DidPlayerWin = 1;
                } else {
                    AttackColorController.DidPlayerWin = 0;
                }
            } else if (AttackColorController.AttackColor == 1){
                if (PlayableSpriteController.GValue > BossSpriteController.BossGValue){
                    AttackColorController.DidPlayerWin = 1;
                } else {
                    AttackColorController.DidPlayerWin = 0;
                }
            } else if (AttackColorController.AttackColor == 2){
                if (PlayableSpriteController.BValue > BossSpriteController.BossBValue){
                    AttackColorController.DidPlayerWin = 1;
                } else {
                    AttackColorController.DidPlayerWin = 0;
                }
            }
        } else if (ValueToGetResultOfFight == 1) {
            AttackColorController.DidPlayerWin = 0;
        } else if (ValueToGetResultOfFight == 2) {
            AttackColorController.DidPlayerWin = 1;
        }
        switch(AttackColorController.AttackColor){
            case 0:    
            GameObject RedAttack = (GameObject)Instantiate (RedScanning);
            RedAttack.transform.SetParent (canvas.transform, false);              
            break;
            case 1:    
            GameObject GreenAttack = (GameObject)Instantiate (GreenScanning);
            GreenAttack.transform.SetParent (canvas.transform, false);                      
            break;
            case 2:    
            GameObject BlueAttack = (GameObject)Instantiate (BlueScanning);
            BlueAttack.transform.SetParent (canvas.transform, false);                     
            break;
        }
    }
}
