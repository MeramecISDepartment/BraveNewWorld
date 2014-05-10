/********************************************************************************************
 * 
 * Class:       JBiome
 * Project:     Brave New World
 * Author:      Keith Emery
 * Date:        4/29/14
 * Description: The JBiome class was created in order to use JSON to define point
 *              characteristics. Although this approach will likely be used in the
 *              future, in the interest of time it was abandoned at this stage. The
 *              technique outlined here:
 *              http://www.codeproject.com/Tips/397574/Use-Csharp-to-get-JSON-Data-from-the-Web-and-Map-i
 *              greatly simplified this process.
 *              
 * ******************************************************************************************/

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
