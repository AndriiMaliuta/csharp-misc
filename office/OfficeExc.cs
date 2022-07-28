namespace csharp_misc.office
{
    using Excel = Microsoft.Office.Interop.Excel;
   
    public class Account
    {
        public int ID { get; set; }
        public double Balance { get; set; }
    }
    public class OfficeExc
    {
        void createExcel() 
        {
            // Create a list of accounts.
            var bankAccounts = new List<Account> 
            {
                new Account {
                            ID = 345678,
                            Balance = 541.27
                            },
                new Account {
                            ID = 1230221,
                            Balance = -127.44
                            }
            };
        }
        static void DisplayInExcel(IEnumerable<Account> accounts)
        {
            var excelApp = new Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a particular template.
            // Because no argument is sent in this example, Add creates a new workbook.
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            // Establish column headings in cells A1 and B1.
            workSheet.Cells[1, "A"] = "ID Number";
            workSheet.Cells[1, "B"] = "Current Balance";
            var row = 1;
            foreach (var acct in accounts)
            {
                row++;
                workSheet.Cells[row, "A"] = acct.ID;
                workSheet.Cells[row, "B"] = acct.Balance;
            }
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();

            ((Excel.Range)workSheet.Columns[1]).AutoFit();
            ((Excel.Range)workSheet.Columns[2]).AutoFit();

            // Display the list in an Excel spreadsheet.
            DisplayInExcel(bankAccounts);
        }
    }
}