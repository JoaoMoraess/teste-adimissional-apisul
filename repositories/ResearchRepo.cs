using System.Text.Json;

class LocalResearchRepo : IResearchRepo
{
  private string filePath = "./data/input.json";
  public ResearchData[] loadData()
  {
    string jsonText = File.ReadAllText(this.filePath);
    ResearchData[] researchData = JsonSerializer.Deserialize<ResearchData[]>(jsonText)!;
    return researchData;
  }
}