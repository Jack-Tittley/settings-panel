using System;

namespace Pages;

public class Metric
{
    public int Id { get; set; }
    public bool IsVisible { get; set; }
    public string? MetricName { get; set; }
    public bool IncludeInScore { get; set; }
    public int WeightOne { get; set; }
    public int WeightTwo { get; set; }
    public int WeightThree { get; set; }
    public double ThresholdOne { get; set; }
    public double ThresholdTwo { get; set; }
    public double ThresholdThree { get; set; }

    public Metric()
    {
        Id = 0;
        IsVisible = true;
        MetricName = "";
        IncludeInScore = true;
        WeightOne = 0;
        WeightTwo = 3;
        WeightThree = 10;
        ThresholdOne = 15;
        ThresholdTwo = 35;
        ThresholdThree = 100;
    }

    public Metric(int id, bool isVisible, string? metricName, bool includeInScore, int weightOne, int weightTwo, int weightThree, double thresholdOne, double thresholdTwo, double thresholdThree)
    {
        Id = id;
        this.IsVisible = isVisible;
        MetricName = metricName;
        this.IncludeInScore = includeInScore;
        this.WeightOne = weightOne;
        this.WeightTwo = weightTwo;
        this.WeightThree = weightThree;
        this.ThresholdOne = thresholdOne;
        this.ThresholdTwo = thresholdTwo;
        this.ThresholdThree = thresholdThree;
    }
}
