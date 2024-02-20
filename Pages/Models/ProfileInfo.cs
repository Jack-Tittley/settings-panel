using Pages;

namespace Pages;

public class ProfileInfo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Notes { get; set; }
    public List<ThisMetricRow>? Metrics { get; set; }
    public int PassRate { get; set; }

}
