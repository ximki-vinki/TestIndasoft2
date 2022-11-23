namespace TestIndasoft;

public class Measurement
{
    public double WaterNumber { get; private set; }
    public List<Equipment> Equipments = new();
    public int Id;
    public double WeightEmptyPick { get; private set; }
    public double WeightFullPick { get; private set; }
    public double WaterDensity { get; } = 998.2019;
    public double CorrectionAirPressure { get; private set; }

    public Measurement(int id)
    {
        Id = id;
    }

    public void AddValues(double waterNumber, double weightEmptyPick,double weightFullPick, double correctionAirPressure)
    {
        WaterNumber= waterNumber;
        WeightEmptyPick = weightEmptyPick;
        WeightFullPick = weightFullPick;
        CorrectionAirPressure = correctionAirPressure;
    }

}