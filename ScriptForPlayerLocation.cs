using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScriptForPlayerLocation : MonoBehaviour
{
    RectTransform rect;
    float NorthwestPointLongitude = 144.952415f;
    float NorthwestPointLatitude = -37.809255f;
    float SouthwestPointLongitude = 144.955062f;
    float SouthwestPointLatitude = -37.821103f;
    float SoutheastPointLongitude = 144.974913f;
    float SoutheastPointLatitude = -37.815325f;
    float GridMapHeight = 300;
    float GridMapWidth = 390;

    void Start() {
        rect = GetComponent < RectTransform > ();
        
        
    }
    void Update() {

        double WestStreetLengthCompA = Mathf.Pow(NorthwestPointLongitude - SouthwestPointLongitude, 2);
        double WestStreetLengthCompB = Mathf.Pow(NorthwestPointLatitude - SouthwestPointLatitude, 2);
        double WestStreetLength = Mathf.Pow((float)WestStreetLengthCompA + (float)WestStreetLengthCompB, 0.5f);
        double WestStreetLineSlopeCompA = SouthwestPointLatitude - NorthwestPointLatitude;
        double WestStreetLineSlopeCompB = SouthwestPointLongitude - NorthwestPointLongitude;
        double WestStreetLineSlope = WestStreetLineSlopeCompA / WestStreetLineSlopeCompB;
        double WestStreetLineInterceptCompA = - NorthwestPointLongitude;
        double WestStreetLineInterceptCompB = NorthwestPointLatitude;
        double WestStreetLineIntercept = WestStreetLineInterceptCompA * WestStreetLineSlope + WestStreetLineInterceptCompB;
        double DistanceBtwPlayerAndWestStreetCompB = Mathf.Pow((float)WestStreetLineSlope, 2) + 1;
        double SouthStreetLengthCompA = Mathf.Pow(SouthwestPointLongitude - SoutheastPointLongitude, 2);
        double SouthStreetLengthCompB = Mathf.Pow(SouthwestPointLatitude - SoutheastPointLatitude, 2);

        double SouthStreetLength = Mathf.Pow((float)SouthStreetLengthCompA + (float)SouthStreetLengthCompB, 0.5f);
        double SouthStreetLineSlopeCompA = SouthwestPointLatitude - SoutheastPointLatitude;
        double SouthStreetLineSlopeCompB = SouthwestPointLongitude - SoutheastPointLongitude;
        double SouthStreetLineSlope = SouthStreetLineSlopeCompA / SouthStreetLineSlopeCompB;
        double SouthStreetLineInterceptCompA = - SoutheastPointLongitude;
        double SouthStreetLineInterceptCompB = SoutheastPointLatitude;
        double SouthStreetLineIntercept = SouthStreetLineInterceptCompA * SouthStreetLineSlope + SouthStreetLineInterceptCompB;
        double DistanceBtwPlayerAndSouthStreetCompB = Mathf.Pow((float)SouthStreetLineSlope, 2) + 1;

        double PlayerLocationLongitude = 144.964458f;
        double PlayerLocationLatitude = -37.81098f;
        double DistanceBtwPlayerAndWestStreetCompAa = WestStreetLineSlope * PlayerLocationLongitude;
        double DistanceBtwPlayerAndWestStreetCompAb = - PlayerLocationLatitude;
        double DistanceBtwPlayerAndWestStreetCompA = Mathf.Abs((float)DistanceBtwPlayerAndWestStreetCompAa + (float)DistanceBtwPlayerAndWestStreetCompAb + (float)WestStreetLineIntercept);
        double DistanceBtwPlayerAndWestStreet = DistanceBtwPlayerAndWestStreetCompA / Mathf.Pow((float)DistanceBtwPlayerAndWestStreetCompB, 0.5f);
        double DistanceBtwPlayerAndSouthStreetCompAa = SouthStreetLineSlope * PlayerLocationLongitude;
        double DistanceBtwPlayerAndSouthStreetCompAb = - PlayerLocationLatitude;
        double DistanceBtwPlayerAndSouthStreetCompA = Mathf.Abs((float)DistanceBtwPlayerAndSouthStreetCompAa + (float)DistanceBtwPlayerAndSouthStreetCompAb + (float)SouthStreetLineIntercept);
        double DistanceBtwPlayerAndSouthStreet = (float)DistanceBtwPlayerAndSouthStreetCompA / (float)Mathf.Pow((float)DistanceBtwPlayerAndSouthStreetCompB, 0.5f);
        
        // double UnitForGridHeight = GridMapHeight / WestStreetLength;
        // double UnitForGridWidth = GridMapWidth / SouthStreetLength;
        // double PlayerXInGrid = 

        rect.localPosition += new Vector3(1, 0, 0);
    }
}
