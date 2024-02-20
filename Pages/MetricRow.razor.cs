using Microsoft.AspNetCore.Components;

namespace Pages;

public partial class ThisMetricRow : ComponentBase
{
    public Metric Metrics { get; set; } = new Metric();

    public void CheckboxChanged()
    {
        if (Metrics.IncludeInScore)
        {
            Metrics.IncludeInScore = false;
            
        }

        else
        {
            Metrics.IncludeInScore = true;
            
        }
    }

    public void VisibilityToggled()
    {

        if (Metrics.IsVisible)
        {
            Metrics.IsVisible = false;
           
        }

        else
        {
            Metrics.IsVisible = true;
            
        }

        
    }

    public void WeightUp(int index)
    {
        if (Metrics.IsVisible)
        {
            switch (index)
            {
                case 1:
                    if (Metrics.WeightOne < 10)
                    {
                        Metrics.WeightOne++;
                    }
                    break;
                case 2:
                    if (Metrics.WeightTwo < 10)
                    {
                        Metrics.WeightTwo++;
                    }
                    break;
                case 3:
                    if (Metrics.WeightThree < 10)
                    {
                        Metrics.WeightThree++;
                    }
                    break;
            }
        }
    }

    public void WeightDown(int index)
    {

        if (Metrics.IsVisible)
        {
            switch (index)
            {
                case 1:
                    if (Metrics.WeightOne > 0)
                    {
                        Metrics.WeightOne--;
                    }
                    break;
                case 2:
                    if (Metrics.WeightTwo > 0)
                    {
                        Metrics.WeightTwo--;
                    }
                    break;
                case 3:
                    if (Metrics.WeightThree > 0)
                    {
                        Metrics.WeightThree--;
                    }
                    break;
            }
        }
    }

    public string GetThresholdLineWidth(int index)


    {
        double value = 0;
        switch (index)
        {
           
        
            case 1: value = Metrics.ThresholdOne; break;
            case 2: value = (Metrics.ThresholdTwo - Metrics.ThresholdOne) ; break;
            case 3: value = (Metrics.ThresholdThree - Metrics.ThresholdTwo); break;

        }


        return (string)"width: " + value.ToString() + "px;";
    }



        
       




    

    public void SetName(string name)
    {
        Metrics.MetricName = name;
    }

    public void SetID(int id)
    {
      Metrics.Id = id;
    }

   
}
