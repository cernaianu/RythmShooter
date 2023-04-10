using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Clasa descrie proprietatile generale ale jucatorului
[Serializable]
public class ModelJucator
{
    private float puncteViata;
    private float vitezaMiscare;
    private float putereDauneBaza;
    private float putereMagnetismPiese;

    public float PuncteViata { get => puncteViata; set => puncteViata = value; }
    public float VitezaMiscare { get => vitezaMiscare; set => vitezaMiscare = value; }
    public float PutereDauneBaza { get => putereDauneBaza; set => putereDauneBaza = value; }
    public float PutereMagnetismPiese { get => putereMagnetismPiese; set => putereMagnetismPiese = value; }
}
