using System;

using Microsoft.AspNetCore.Components;

namespace Pages;


public class UserProfile : ComponentBase

   

{
    public ProfileInfo Profile{ get; set; }

    public Boolean ShowThresholdPopup { get; set; } = false;
    private ThisMetricRow? SelectedRow;
   
    public List<ThisMetricRow> GetMetrics()
    {
        return Profile.Metrics;
    }

    public void ClearMetrics()
    {
        if (Profile.Metrics != null)
        {
            Profile.Metrics.Clear();
        }

    }

    public List<ThisMetricRow> CopyRow(List<ThisMetricRow> Metrics)
    {
        List<ThisMetricRow> newMetrics = new List<ThisMetricRow>(); 
        foreach (var item in Metrics)
        {
            ThisMetricRow newRow = new ThisMetricRow();
            newRow.Metrics = new Metric(item.Metrics.Id, item.Metrics.IsVisible, item.Metrics.MetricName, item.Metrics.IncludeInScore, item.Metrics.WeightOne, item.Metrics.WeightTwo, item.Metrics.WeightThree, item.Metrics.ThresholdOne, item.Metrics.ThresholdTwo, item.Metrics.ThresholdThree);
            newMetrics.Add(newRow);
            {

            };
        }
        return newMetrics;
    }

    public void ClickedThresholdPopup(ThisMetricRow row)
    {
        ShowThresholdPopup = true;
        this.SelectedRow = row;

    }

    public ThisMetricRow GetSelectedRow()
    {
        return this.SelectedRow;
    }

    public void ThresholdUp()
    {
        Profile.PassRate++;
    }

    public void ThresholdDown()
    {
        Profile.PassRate--;
    }




public void InitMetrics()
    {
        if (Profile.Metrics.Count == 0)
        {
            string[] names = { "Open start Tasks", "Open Finish Tasks", "Future Actual Dates", "Riding Data Date", "Invalid Constraints", "Resources", "Relationship: Start to Finish", "Negative float", "As Late as Possible", "Duplicate Relationship" };
            int x = 1;
            foreach (string name in names)
            {
                ThisMetricRow row = new ThisMetricRow();
                row.SetName(name);
                row.SetID(x);
                x++;
                Profile.Metrics.Add(row);


            }
        }
       
        
    }

   

}

