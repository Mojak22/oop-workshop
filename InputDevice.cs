namespace Domain
{
    class InputDevice : Device
    {
        // Skal læse en temp værdi fra Device
        public double sensorTemp()
        {
            
        }
        
        // Skal læse om der er bevægelse
        public bool isMoving()
        {
            // Læser værdi 0 = false
            // Læser værdi 1 = true
        }
        
        // Skal aflæse mængden af strøm brugt fra en Device
        public int getPowerUsage()
        {
            // Læser værdier i Joule og skal være i int
        }
        
    }
}