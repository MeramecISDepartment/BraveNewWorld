using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiomeGeneration
{
    class JBiome
    {
    }
}

public class Rootobject
{
    public Rainforest rainforest { get; set; }
    public Arid arid { get; set; }
    public DryTemperate drytemperate { get; set; }
    public HumidTemperate humidtemperate { get; set; }
    public CoolTemperate cooltemperate { get; set; }
    public Alpine alpine { get; set; }
    public Polar polar { get; set; }
}

public class Rainforest
{
    public string[] latitude { get; set; }
    public string[] altitude { get; set; }
    public string[] slope { get; set; }
    public string[] substrate { get; set; }
    public string[] aspect { get; set; }
    public string[] color { get; set; }
}

public class Arid
{
    public string latitude { get; set; }
    public string altitude { get; set; }
    public string[] slope { get; set; }
    public string[] substrate { get; set; }
    public string aspect { get; set; }
    public string[] color { get; set; }
}

public class DryTemperate
{
    public string latitude { get; set; }
    public string altitude { get; set; }
    public string slope { get; set; }
    public string[] substrate { get; set; }
    public string aspect { get; set; }
    public string[] color { get; set; }
}

public class HumidTemperate
{
    public string latitude { get; set; }
    public string altitude { get; set; }
    public string slope { get; set; }
    public string[] substrate { get; set; }
    public string aspect { get; set; }
    public string[] color { get; set; }
}

public class CoolTemperate
{
    public string latitude { get; set; }
    public string[] altitude { get; set; }
    public string slope { get; set; }
    public string[] substrate { get; set; }
    public string[] aspect { get; set; }
    public string[] color { get; set; }
}

public class Alpine
{
    public string latitude { get; set; }
    public string altitude { get; set; }
    public string slope { get; set; }
    public string[] substrate { get; set; }
    public string aspect { get; set; }
    public string[] color { get; set; }
}

public class Polar
{
    public string latitude { get; set; }
    public string altitude { get; set; }
    public string slope { get; set; }
    public string substrate { get; set; }
    public string aspect { get; set; }
    public string[] color { get; set; }
}
