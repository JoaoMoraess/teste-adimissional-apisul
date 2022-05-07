class GenerateFullReportUseCase
{
  private readonly ProvaAdmissionalCSharpApisul.IElevadorService elevadorService;
  public GenerateFullReportUseCase(ProvaAdmissionalCSharpApisul.IElevadorService elevadorService)
  {
    this.elevadorService = elevadorService;
  }

  public void Generate()
  {
    Console.Clear();
    Console.WriteLine("Generating full report...\n");
    var lessUsedFloor = elevadorService.andarMenosUtilizado();
    var mostUsedElevator = elevadorService.elevadorMaisFrequentado();
    var highestFlowElevator = elevadorService.periodoMaiorFluxoElevadorMaisFrequentado();
    var lessUsedElevator = elevadorService.elevadorMenosFrequentado();
    var lowestFlowElevator = elevadorService.periodoMenorFluxoElevadorMenosFrequentado();
    var highestUsageElevator = elevadorService.periodoMaiorUtilizacaoConjuntoElevadores();
    var percentualElevatorA = elevadorService.percentualDeUsoElevadorA();
    var percentualElevatorB = elevadorService.percentualDeUsoElevadorB();
    var percentualElevatorC = elevadorService.percentualDeUsoElevadorC();
    var percentualElevatorD = elevadorService.percentualDeUsoElevadorD();
    var percentualElevatorE = elevadorService.percentualDeUsoElevadorE();

    Console.WriteLine("a. Qual é o andar menos utilizado pelos usuários");
    Console.WriteLine($"R: Andar ({lessUsedFloor[0]})\n");
    Console.WriteLine("b. Qual é o elevador mais frequentado e o período que se encontra maior fluxo");
    Console.WriteLine($"R: Elevador ({mostUsedElevator[0]}) no período ({highestFlowElevator[0]})\n");
    Console.WriteLine("c. Qual é o elevador menos frequentado e o período que se encontra menor fluxo");
    Console.WriteLine($"R: Elevador ({lessUsedElevator[0]}) no período ({lowestFlowElevator[0]})\n");
    Console.WriteLine("d. Qual o período de maior utilização do conjunto de elevadores");
    Console.WriteLine($"R: Período ({highestUsageElevator[0]})\n");
    Console.WriteLine("e. Qual o percentual de uso de cada elevador com relação a todos os serviços prestados");
    Console.WriteLine($"R: Elevador A - {percentualElevatorA}%");
    Console.WriteLine($"R: Elevador B - {percentualElevatorB}%");
    Console.WriteLine($"R: Elevador C - {percentualElevatorC}%");
    Console.WriteLine($"R: Elevador D - {percentualElevatorD}%");
    Console.WriteLine($"R: Elevador E - {percentualElevatorE}%");




  }
}