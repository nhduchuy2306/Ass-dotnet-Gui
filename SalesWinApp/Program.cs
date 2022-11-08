using BussinessObject.Models;
using DataAccess.Repository;

namespace SalesWinApp
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new frmMembers());
        }
    }
}