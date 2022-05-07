class ElevatorServices : ProvaAdmissionalCSharpApisul.IElevadorService
{
  private readonly ResearchData[] researchData;

  private Dictionary<char, int> useOfElevator = new Dictionary<char, int> {
    { 'A', 0 },
    { 'B', 0 },
    { 'C', 0 },
    { 'D', 0 },
    { 'E', 0 }
  };
  private Dictionary<int, int> useOffloors = new Dictionary<int, int>();
  private Dictionary<char, int> useOfShift = new Dictionary<char, int>();
  private int totalOfUseElevator = 0;

  public ElevatorServices(ResearchData[] researchData)
  {
    this.researchData = researchData;
    this.configureDataStructure(researchData);
    this.totalOfUseElevator = researchData.Length;
  }

  private void configureDataStructure(ResearchData[] dataResult)
  {
    foreach (ResearchData data in dataResult)
    {
      if (this.useOfElevator.ContainsKey(data.elevador)) this.useOfElevator[data.elevador]++;
      else this.useOfElevator.Add(data.elevador, 1);

      if (this.useOffloors.ContainsKey(data.andar)) this.useOffloors[data.andar]++;
      else this.useOffloors.Add(data.andar, 1);

      if (this.useOfShift.ContainsKey(data.turno)) this.useOfShift[data.turno]++;
      else this.useOfShift.Add(data.turno, 1);
    }
  }

  public List<int> andarMenosUtilizado()
  {
    var lessUsedFloor = this.useOffloors.OrderBy(x => x.Value).First();
    List<int> lessUsedFloors = this.useOffloors.Where(floor => floor.Value == lessUsedFloor.Value).Select(floor => floor.Key).ToList();

    return lessUsedFloors;
  }

  public List<char> elevadorMaisFrequentado()
  {
    var mostUsedElevator = this.useOfElevator.OrderByDescending(x => x.Value).First();
    List<char> mostUsedElevators = this.useOfElevator.Where(elevator => elevator.Value == mostUsedElevator.Value).Select(elevator => elevator.Key).ToList();

    return mostUsedElevators;
  }

  public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
  {
    var mostUsedElevators = this.elevadorMaisFrequentado();
    var periodHighestFlow = this.useOfShift.OrderByDescending(x => x.Value).First();
    List<char> periodHighestFlows = this.useOfShift.Where(flow => flow.Value == periodHighestFlow.Value).Select(flow => flow.Key).ToList();

    return periodHighestFlows;
  }

  public List<char> elevadorMenosFrequentado()
  {
    var lessUsedElevator = this.useOfElevator.OrderBy(x => x.Value).First();
    List<char> lessUsedElevators = this.useOfElevator.Where(elevator => elevator.Value == lessUsedElevator.Value).Select(elevator => elevator.Key).ToList();

    return lessUsedElevators;
  }

  public List<char> periodoMenorFluxoElevadorMenosFrequentado()
  {
    var lessUsedElevators = this.elevadorMenosFrequentado();
    Dictionary<char, int> lessUsedElevatorsFlow = new Dictionary<char, int> {
      {'M', 0},
      {'V', 0},
      {'N', 0},
    };

    foreach (var item in this.researchData)
    {
      if (lessUsedElevators.Contains(item.elevador)) lessUsedElevatorsFlow[item.turno]++;
    }

    var lessUsedElevatorsFlowPeriod = lessUsedElevatorsFlow.OrderBy(x => x.Value).First();
    List<char> lessUsedElevatorsFlowPeriods = lessUsedElevatorsFlow.Where(flow => flow.Value == lessUsedElevatorsFlowPeriod.Value).Select(flow => flow.Key).ToList();

    return lessUsedElevatorsFlowPeriods;
  }

  public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
  {
    var mostUsedShift = this.useOfShift.OrderByDescending(x => x.Value).First();
    List<char> mostUsedShifts = this.useOfShift.Where(shift => shift.Value == mostUsedShift.Value).Select(shift => shift.Key).ToList();

    return mostUsedShifts;
  }

  public float percentualDeUsoElevadorA()
  {
    int useOfElevatorA = this.useOfElevator['A'];
    if (this.totalOfUseElevator == 0) return 0;
    var usePercent = ((float)useOfElevatorA / this.totalOfUseElevator) * 100;

    return (float)Math.Round(usePercent, 2);
  }

  public float percentualDeUsoElevadorB()
  {
    int useOfElevatorB = this.useOfElevator['B'];
    if (this.totalOfUseElevator == 0) return 0;
    var usePercent = ((float)useOfElevatorB / this.totalOfUseElevator) * 100;

    return (float)Math.Round(usePercent, 2);
  }

  public float percentualDeUsoElevadorC()
  {
    int useOfElevatorC = this.useOfElevator['C'];
    if (this.totalOfUseElevator == 0) return 0;
    var usePercent = ((float)useOfElevatorC / this.totalOfUseElevator) * 100;

    return (float)Math.Round(usePercent, 2);
  }

  public float percentualDeUsoElevadorD()
  {
    int useOfElevatorD = this.useOfElevator['D'];
    if (this.totalOfUseElevator == 0) return 0;
    var usePercent = ((float)useOfElevatorD / this.totalOfUseElevator) * 100;

    return (float)Math.Round(usePercent, 2);
  }

  public float percentualDeUsoElevadorE()
  {
    int useOfElevatorE = this.useOfElevator['E'];
    if (this.totalOfUseElevator == 0) return 0;
    var usePercent = ((float)useOfElevatorE / this.totalOfUseElevator) * 100;

    return (float)Math.Round(usePercent, 2);
  }

}