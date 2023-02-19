namespace RaceSim;

public interface IParticipant
{ 
    public string Name { get; set; }
    public int Points { get; set; }
    public IEquipment Equipment { get; set; }
    public TeamColors TeamColors { get; set; }
}