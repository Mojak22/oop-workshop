namespace Domain;

public class Building
{
    private string buildingName;
    
    // Skal kunne lave en list af floors i en bygning
    public List<Floor> floorsInBuilding;

    public Building(string buildingName)
    {
        this.buildingName = buildingName;
    }
    
    // Skal kunne lave en list af rooms i en bygning
    public List<Room> roomsInBuilding;
    
    
}