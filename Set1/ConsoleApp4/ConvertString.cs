using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class DataExt
    {
        public string FIRMNAME { get; set; }
        public string FILETYPE { get; set; }
        public string[] TICKERS { get; set; }
        public string[] FIELDS { get; set; }
        public string[] DATA { get; set; }

        public static DataExt Parse(string input)
        {
            var DataEXt = new DataExt();
            var lines = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var tickers = new List<string>();
            var fields = new List<string>();
            var data = new List<string>();
            bool isTickers = false, isFields = false, isData = false;

            foreach (var line in lines)
            {
                if (line.StartsWith("FIRMNAME"))
                {
                    DataEXt.FIRMNAME = line.Split('=')[1].Trim();
                }
                else if (line.StartsWith("FILETYPE"))
                {
                    DataEXt.FILETYPE = line.Split('=')[1].Trim();
                }
                else if (line.StartsWith("START-OF-TICKERS"))
                {
                    isTickers = true;
                }
                else if (line.StartsWith("END-OF-TICKERS"))
                {
                    isTickers = false;
                }
                else if (line.StartsWith("START-OF-FIELDS"))
                {
                    isFields = true;
                }
                else if (line.StartsWith("START-OF-DATA"))
                {
                    isFields = false;
                    isData = true;
                }
                else if (line.StartsWith("END-OF-DATA"))
                {
                    isData = false;
                }
                else if (isTickers)
                {
                    tickers.Add(line.Trim());
                }
                else if (isFields)
                {
                    fields.Add(line.Trim());
                }
                else if (isData)
                {
                    data.Add(line.Trim());
                }
            }

            DataEXt.TICKERS = tickers.ToArray();
            DataEXt.FIELDS = fields.ToArray();
            DataEXt.DATA = data.ToArray();

            return DataEXt;

        }
    }
}
