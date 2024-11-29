namespace Domain;

public class OutputDevice : Consumer, Device
{
    private double tempSetPoint;
    // Skal lave et temp setPoint
    public double tempSetPoint(double temp)
    {
        this.tempSetPoint = temp;
    }
    
    // Skal læse værdi af aktuel temperatur
    public double tempActual()
    {
        // Skal læse værdien fra Device
    }
    
    // Justering af akutator
    public void adjustTemp()
    {
        if (temp < tempSetPoint)
        {
            actuator++;
        }
        else if (temp > tempSetPoint)
        {
            actuator--;
        }
    }
    
}