namespace TestIndasoft;

public class Sample
{
    public string AllInformation = "Вся необходимая информация о пробе для лаборатории";

    public Sample(int idSample)
    {
        IdSample = idSample;
    }

    public int IdSample { get; }
    public List<SampleAnalysis> Analysis=new ();
}