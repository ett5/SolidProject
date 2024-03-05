namespace Solid.Core.Entities;
public class Tasks
{
	public int Id {get; set; }
	public string Job { get; set; }
	public float Minute { get; set; }
    public List<Hours> Hours { get; set; }
}
