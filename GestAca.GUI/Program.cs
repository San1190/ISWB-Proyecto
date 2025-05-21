using GestAca.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestAca.Services;
using GestAca.Persistence;

namespace GestAca.GUI
{
    public partial class GestAcaApp
    {
        private GestAcaService service;

        public GestAcaApp(GestAcaService service)
        {

            InitializeComponent();
            this.service = service;
        }
    }
    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
     
        static void Main()
        {
            GestAcaService service = new GestAcaService(new EntityFrameworkDAL(new GestAcaDbContext()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GestAca());
        }
    }
}
