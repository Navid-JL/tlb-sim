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

    public bool Lookup(int virtualPage, out int physicalPage)
    {
        foreach (var entry in entries)
        {
            if (entry != null && entry.VirtualPage == virtualPage)
            {
                physicalPage = entry.PhysicalPage;
                return true;
            }
        }

        physicalPage = -1;
        return false;
    }

    public void Insert(int virtualPage, int physicalPage)
    {
        // Replace the oldest entry with the new one
        entries[0] = new TLBEntry { VirtualPage = virtualPage, PhysicalPage = physicalPage };
    }
}
