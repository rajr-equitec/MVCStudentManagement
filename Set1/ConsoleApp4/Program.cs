using ConsoleApp4;

internal class Program
{
    private static void Main(string[] args)
    {
        //Question1
        Circles c = new Circles();
        c.Cal();

        //Question2
        PrintSize p = new PrintSize();
        PrintSize.Cal();

        //Question3
        Employee.Disp();

        //Question4
        NewSwitch.Userinput();

        //Question5

string input = @"START-OF-FILE
FIRMNAME = Equitec
FILETYPE = PC
START-OF-TICKERS
ABB IN Equity
CEAT IN Equity
RIL IN Equity
END-OF-TICKERS
START-OF-FIELDS
CMP
MARKET_CAP
START-OF-DATA
ABB IN Equity|100|50000000
CEAT IN Equity|20|70000000
END-OF-DATA
END-OF-FILE";

 DataExt data = DataExt.Parse(input);

 Console.WriteLine($"FIRMNAME: {data.FIRMNAME}");
 Console.WriteLine($"FILETYPE: {data.FILETYPE}");
 Console.WriteLine("TICKERS: " + string.Join(", ", data.TICKERS));
 Console.WriteLine("FIELDS: " + string.Join(", ", data.FIELDS));
 Console.WriteLine("DATA: " + string.Join(", ", data.DATA));
 Console.ReadLine();
}

}