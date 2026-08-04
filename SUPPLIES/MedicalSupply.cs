using System;
namespace DisasterReliefSystem.SUPPLIES;

public class MedicalSupply : SupplyItem
{
    private bool requiresRefrigeration;
    private int expiryDays;

    public MedicalSupply(string name, double weightKg, double volumeM3, bool requiresRefrigeration, int expiryDays) 
        : base(name, weightKg, volumeM3)
    {
        this.requiresRefrigeration = requiresRefrigeration;
        this.expiryDays = expiryDays;
    }

    public override double CalculateUrgencyValue()
    {
        double score = 100.0 / (expiryDays + 1);
        if (requiresRefrigeration)
        {
            score *= 2.0;
        }
        return score;
    }
}