using TlbSim.Library;

// Create a TLB with a size of 4 entries
TLB tlb = new TLB(4);

// Simulate TLB lookups and insertions
tlb.Insert(2, 10);
tlb.Insert(4, 20);

int physicalPage;
bool found = tlb.Lookup(2, out physicalPage);
Console.WriteLine($"Lookup result: {found}, Physical page: {physicalPage}");

found = tlb.Lookup(4, out physicalPage);
Console.WriteLine($"Lookup result: {found}, Physical page: {physicalPage}");

tlb.Insert(5, 30);

found = tlb.Lookup(5, out physicalPage);
Console.WriteLine($"Lookup result: {found}, Physical page: {physicalPage}");

found = tlb.Lookup(2, out physicalPage);
Console.WriteLine($"Lookup result: {found}, Physical page: {physicalPage}");

Console.ReadLine();
