
interface IResearchRepo
{
  ResearchData[] loadData();
}


class ResearchData
{
  public int andar { get; set; }
  public char elevador { get; set; }
  public char turno { get; set; }
}