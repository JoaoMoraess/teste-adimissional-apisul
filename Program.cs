public class Program
{
  public static void Main(string[] args)
  {
    IResearchRepo localResearchRepo = new LocalResearchRepo();

    var elevatorServices = new ElevatorServices(localResearchRepo.loadData());
    var generateFullReportUseCase = new GenerateFullReportUseCase(elevatorServices);

    generateFullReportUseCase.Generate();
  }
}