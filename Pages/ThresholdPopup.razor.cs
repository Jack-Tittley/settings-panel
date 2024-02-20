
using Microsoft.AspNetCore.Components;
using System;
namespace Pages;
public class ThresholdController
{
    public double ThresholdOne { get; set; }
    public double ThresholdTwo { get; set; }
    public double ThresholdThree { get; set; }
    
    public ThresholdController(double originalThresholdOne, double originalThresholdTwo, double originalThresholdThree)
    {
        this.ThresholdOne = originalThresholdOne;
        this.ThresholdTwo = originalThresholdTwo;
        this.ThresholdThree = originalThresholdThree;

    }


    public void ThresholdUp(int index)
    {
        switch (index)
        {
            case 1:
                if (ThresholdOne <= ThresholdTwo - 1)
                {
                    ThresholdOne++;
                }
                break;
            case 2:
                if (ThresholdTwo < ThresholdThree - 1)
                {
                    ThresholdTwo++;
                }

                break;
            case 3:
                if(ThresholdTwo > ThresholdOne && ThresholdOne >= 1 && ThresholdTwo >= 1)
                {
                    ThresholdTwo--;
                    ThresholdOne--;
                    
                }
                break;

        }
    }


    public void ThresholdDown(int index)
    {
        switch (index)
        {
            case 1:
                if (ThresholdOne >= 1)
                {
                    ThresholdOne--;
                }
                break;
            case 2:
                if (ThresholdTwo > ThresholdOne)
                {
                    ThresholdTwo--;
                }
                break;

            case 3:
                if (ThresholdTwo <= 99)
                {
                    ThresholdTwo++;

                }
                break;
        }
    }


    public string getThresholdLineWidth(int index)
    {
        double value = 0;
        switch (index)
        {
            case 1: value = ThresholdOne * 2; break;
            case 2: value = (ThresholdTwo - ThresholdOne) * 2; break;
            case 3: value = (ThresholdThree - ThresholdTwo) * 2; break;

        }


        return (string)"width: " + value.ToString() + "px;";
    }
}


  

