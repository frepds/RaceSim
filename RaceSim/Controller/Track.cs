namespace RaceSim;

public class Track
{
    public string Name { get; set; }
    public LinkedList<Section> Sections { get; set; }

    public Track(string name, SectionTypes[] sections)
    {
        Name = name;
        Sections = InitializeSections(sections);
    }
    
}
