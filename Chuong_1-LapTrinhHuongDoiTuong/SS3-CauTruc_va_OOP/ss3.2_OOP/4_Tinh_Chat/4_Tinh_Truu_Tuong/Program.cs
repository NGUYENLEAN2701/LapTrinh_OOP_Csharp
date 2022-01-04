using System;

namespace AbstractionApplication
{
    //! Abstraction with interface
    interface IExportData
    {
        void Export();
    }

    class TextExport : IExportData
    {
        public void Export()
        {
            Console.WriteLine("Export data to .txt file");
        }
    }

    class CsvExport : IExportData
    {
        public void Export()
        {
            Console.WriteLine("Export data to .csv file");
        }
    }

    class Application
    {
        private readonly IExportData _exportData;

        public Application(IExportData exportData)
        {
            _exportData = exportData;
        }

        public void ExportData()
        {
            _exportData.Export();
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Application app = new Application(new TextExport());
            app.ExportData();


            Application app_cvs = new Application(new CsvExport());
            app_cvs.ExportData();

            Console.ReadKey();
        }
    }
}