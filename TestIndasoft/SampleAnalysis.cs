namespace TestIndasoft;

public class SampleAnalysis
{
    public int IdSampleAnalysis;
    public Sample Sample;
    public double Dencity { get; private set; }

    public SampleAnalysis(int idSampleAnalysis, Sample sample)
    {
        IdSampleAnalysis = idSampleAnalysis;
        Sample = sample;
    }
    public List<Measurement> Measurements = new();

    public void AddDencity(double dencity)
    {
        Dencity = dencity;
    }


}