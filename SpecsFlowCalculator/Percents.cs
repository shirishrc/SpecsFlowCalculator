namespace SpecsFlowCalculator;

public class Percents
{
    public int totalNums { get; set; }
    private int res;

    public Percents()
    {
        res = (totalNums / 200) * 100;
    }

    public string getPercentResult()
    {
        if (res < 35)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }
}