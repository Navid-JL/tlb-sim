using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TlbSim.Library;

public class TLBEntry
{
    public int VirtualPage { get; set; }
    public int PhysicalPage { get; set; }
}

// TLB class represents the Translation Lookaside Buffer
public class TLB
{
    private TLBEntry[] entries;

    public TLB(int size)
    {
        entries = new TLBEntry[size];
    }
}
