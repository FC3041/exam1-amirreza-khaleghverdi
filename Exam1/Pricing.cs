

namespace Exam1; 

public interface IStrategy
{
    public double discount { get; set; }
}



public class PercentageDiscountStrategy:IStrategy
{
    public double discount { get; set; }

    public PercentageDiscountStrategy(double v)
    {
        this.discount = v;
    }
}





public class NoDiscountStrategy:IStrategy
{
    double IStrategy.discount { get; set; }=0;
}




public class PricingEngine
{
    private IStrategy strategy;

    public PricingEngine(IStrategy v)
    {
        strategy=v;
    }

    public double CalculatePrice(double v)
    {
        return v*(1-strategy.discount);
    }

    public void SetStrategy(IStrategy percentageDiscountStrategy)
    {
        strategy=percentageDiscountStrategy;
    }

}
