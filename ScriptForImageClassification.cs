using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Barracuda;

public class ScriptForImageClassification : MonoBehaviour
{
[SerializeField]
    private Texture2D TestGraffitiPhoto;
    [SerializeField]
    private TMP_Text graffitiName;
    [SerializeField]
    private NNModel pf_model_copy;

    private Model runtimeModel;
    private IWorker worker;


    // Start is called before the first frame update
    void Start()
    {
        runtimeModel = ModelLoader.Load(pf_model_copy);
        worker = WorkerFactory.CreateWorker(WorkerFactory.Type.ComputePrecompiled, runtimeModel);
    }
    public void Predict()
    {
        //int numberInput;
        using Tensor TestGraffitiPhoto = new Tensor (1, 1);
        //TestGraffitiPhoto[0] = numberInput;
        worker.Execute(TestGraffitiPhoto);
        Tensor outputTensor = worker.PeekOutput();
        graffitiName.text = outputTensor.ToString();
    }
}
