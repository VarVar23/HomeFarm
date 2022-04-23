using System;

public interface IContainer 
{
    Action TimeWateringAction { get; }
    Action TimePlantAction { get; }
    float TimeWatering { get; set; }
    float TimePlant { get; set; }
    float Size { get; }
    bool Free { get; set; }
}
