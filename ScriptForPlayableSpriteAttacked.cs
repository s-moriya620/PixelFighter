using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForPlayabelSpriteAttacked : MonoBehaviour
{
    public int SpriteAttackedX = 0;
    public int SpriteAttackedY = 0;
    public float SpriteAttackedScale = 0.8f;
    public int AttackedIconX = 0;
    public int AttackedIconY = 0;
    public float AttackedIconScale = 0.8f;
    public int HitIconX = 0;
    public int HitIconY = 0;
    public float HitIconScale = 0.8f;
    public GameObject RedAttacked;
    public GameObject GreenAttacked;
    public GameObject BlueAttacked;
    public GameObject Hit;
    public GameObject RedPandaAttacked;
    public GameObject RedPandaEvo1Attacked;
    public GameObject RedPandaEvo2Attacked;
    public GameObject PyroMonkeyAttacked;
    public GameObject PyroMonkeyEvo1Attacked;
    public GameObject PyroMonkeyEvo2Attacked;
    public GameObject TaiyakiAttacked;
    public GameObject TaiyakiEvo1Attacked;
    public GameObject TaiyakiEvo2Attacked;
    public GameObject UfoCatAttacked;
    public GameObject UfoCatEvo1Attacked;
    public GameObject UfoCatEvo2Attacked;
    public GameObject HydroPhantasmAttacked;
    public GameObject HydroPhantasmEvo1Attacked;
    public GameObject HydroPhantasmEvo2Attacked;
    public GameObject PurpleFighterAttacked;
    public GameObject PurpleFighterEvo1Attacked;
    public GameObject PurpleFighterEvo2Attacked;
    
    // Start is called before the first frame update
    void Start()
    {
        switch(PlayableSpriteController.ChosenColor){
            case 0:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    RedPandaAttacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(RedPandaAttacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    RedPandaEvo1Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(RedPandaEvo1Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);
                    break;
                    case 2:
                    RedPandaEvo2Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(RedPandaEvo2Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 1:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    PyroMonkeyAttacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(PyroMonkeyAttacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    PyroMonkeyEvo1Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(PyroMonkeyEvo1Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);
                    break;
                    case 2:
                    PyroMonkeyEvo2Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(PyroMonkeyEvo2Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 2:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    TaiyakiAttacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(TaiyakiAttacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    TaiyakiEvo1Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(TaiyakiEvo1Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);
                    break;
                    case 2:
                    TaiyakiEvo2Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(TaiyakiEvo2Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 3:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    UfoCatAttacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(UfoCatAttacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    UfoCatEvo1Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(UfoCatEvo1Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);
                    break;
                    case 2:
                    UfoCatEvo2Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(UfoCatEvo2Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 4:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    HydroPhantasmAttacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(HydroPhantasmAttacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    HydroPhantasmEvo1Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(HydroPhantasmEvo1Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);
                    break;
                    case 2:
                    HydroPhantasmEvo2Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(HydroPhantasmEvo2Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 5:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    PurpleFighterAttacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(PurpleFighterAttacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    PurpleFighterEvo1Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(PurpleFighterEvo1Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);
                    break;
                    case 2:
                    PurpleFighterEvo2Attacked.transform.localScale = new Vector3(SpriteAttackedScale, SpriteAttackedScale, 1.0f);
                    Instantiate(PurpleFighterEvo2Attacked, new Vector3(SpriteAttackedX, SpriteAttackedY, 0), Quaternion.identity);                   
                    break;
                }
            break;
        } 
        switch(AttackColorController.BossAttackColor)
        {
            case 0:
            RedAttacked.transform.localScale = new Vector3(AttackedIconScale, AttackedIconScale, 1.0f);
            Instantiate(RedAttacked, new Vector3(AttackedIconX, AttackedIconY, 0), Quaternion.identity);  
            break;
            case 1:
            GreenAttacked.transform.localScale = new Vector3(AttackedIconScale, AttackedIconScale, 1.0f);
            Instantiate(GreenAttacked, new Vector3(AttackedIconX, AttackedIconY, 0), Quaternion.identity);  
            break;
            case 2:
            BlueAttacked.transform.localScale = new Vector3(AttackedIconScale, AttackedIconScale, 1.0f);
            Instantiate(BlueAttacked, new Vector3(AttackedIconX, AttackedIconY, 0), Quaternion.identity);  
            break;
        }
        Hit.transform.localScale = new Vector3(HitIconScale, HitIconScale, 1.0f);
        Instantiate(Hit, new Vector3(HitIconX, HitIconY, 0), Quaternion.identity);  
        Invoke(nameof(GoToNextScene), 5.0f);
    }


    private void GoToNextScene()
    {
        SceneManager.LoadScene("27_1 PlayableSpriteLosingScene");
    }
}
