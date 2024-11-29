namespace Domain;

public class Device
{
    private string deviceType;

    // Skal kunne angive hvilket type det er

    public string setDeviceType(string deviceType)
    {
        this.deviceType = deviceType;
        return deviceType;
    }
    
    // Skal kunne angive om justering af aktuator er sket
    public bool isAdjusted()
    {
        // Læs fra om justering af temp er sket
        return true;
    }
}