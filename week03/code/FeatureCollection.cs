public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Feature[] Features { get; set; }
}
public class Feature
{
    public Properties Properties { get; set; }
    public Geometry Geometry { get; set; }
}

public class Properties
{
    public string Place { get; set; }
    public double Mag { get; set; }
    public long Time { get; set; }
}

public class Geometry
{
    public double[] Coordinates { get; set; }
}