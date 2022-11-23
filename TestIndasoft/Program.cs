using TestIndasoft;

Print.InMessage("должна происходить проверка на возможность проведения анализа");
CheckPermissionToWork.GetAll();
Print.ForUser("можете приступить к работе");
Print.InMessage("запрос в БД о текущих пробах в лаборатории");
var Samples = new List<Sample>
{
    new(1)
};

foreach (var item in Samples)
{
    var flagPermissionSample = CheckSampleToAnalisys.GetPermission(item);
}

Print.InMessage(
    "происходит проверка на доступность и необходимость пробы для анализа из пула всех проб находящихся в лаборатории");
Print.ForUser("выберите пробу");
Print.ForUser("вы выбрали пробу 1");
var tempSampleAnalysis = new SampleAnalysis(1, Samples[0]);
var tempMeasurement = new Measurement(1);
Print.ForUser("Выберите оборудование");
Print.InMessage("отображение оборудования исходя из доступных для этой методики и в данное время");
tempMeasurement.Equipments.Add(new Equipment(1));
Print.ForUser("Введите данные");
Print.InMessage("на этом этапе должна проводиться корректность вводимых данных");
tempMeasurement.AddValues(1, 1, 1.1, 1);
tempSampleAnalysis.AddDencity(Calculation.Dencity(tempMeasurement));
Print.InMessage("должна  происходить проверка на корректость вычисленной плотности");
Print.ForUser("Сохранить данные?");
Samples[1].Analysis.Add(tempSampleAnalysis);