using System;
using System.Collections.Generic;
using System.IO;
public class ServerItem
{
    /// <summary>
    /// 
    /// </summary>
    public string ip { get; set; } = string.Empty;
    /// <summary>
    /// 
    /// </summary>
    public int port { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string country { get; set; } = string.Empty;
    /// <summary>
    /// 
    /// </summary>
    public string city { get; set; } = string.Empty;
    /// <summary>
    /// 
    /// </summary>
    public string passwd { get; set; } = string.Empty;
}

public class Ret
{
    /// <summary>
    /// 
    /// </summary>
    public List<ServerItem> server { get; set; }
}

public class Root
{
    /// <summary>
    /// 
    /// </summary>
    public int code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string msg { get; set; } = string.Empty;
    /// <summary>
    /// 
    /// </summary>
    public int role { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Ret ret { get; set; }
}
