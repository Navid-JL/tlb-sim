# TLB Simulation

This project is a simple simulation of a Translation Lookaside Buffer (TLB) in C#. It demonstrates how TLB lookups and insertions work.

## TLB Class

The TLB class represents the Translation Lookaside Buffer. It provides the following methods:

-   Lookup(int virtualPage, out int physicalPage) : This method performs a lookup for a virtual page in the TLB and returns the corresponding physical page if found. It returns a boolean value indicating whether the lookup was successful or not.

-   Insert(int virtualPage, int physicalPage) : This method inserts a new TLB entry for a virtual page and its corresponding physical page. If the TLB is full, it replaces the oldest entry with the new one.

## Usage

To use the TLB simulation, follow these steps:

1. Create an instance of the TLB class with the desired size.

2. Use the Insert method to add TLB entries, providing the virtual page and its corresponding physical page.

3. Use the Lookup method to perform TLB lookups, passing the virtual page as an argument. It will return a boolean value indicating whether the lookup was successful and the corresponding physical page if found.

## Example

// Create a TLB with a size of 4 entries
TLB tlb = new TLB(4);

// Insert TLB entries
tlb.Insert(2, 10);
tlb.Insert(4, 20);

// Perform TLB lookups
int physicalPage;
bool found = tlb.Lookup(2, out physicalPage);
Console.WriteLine($"Lookup result: {found}, Physical page: {physicalPage}");

found = tlb.Lookup(4, out physicalPage);
Console.WriteLine($"Lookup result: {found}, Physical page: {physicalPage}");

// Insert another TLB entry
tlb.Insert(5, 30);

// Perform another lookup
found = tlb.Lookup(5, out physicalPage);
Console.WriteLine($"Lookup result: {found}, Physical page: {physicalPage}");
In this example, we create a TLB with a size of 4 entries, insert two TLB entries, perform lookups for virtual pages 2 and 4, insert another TLB entry, and perform a lookup for virtual page 5.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
