using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace IndianStatesCensusAnalyserProblem
{
    public class StatesCensusAnalyser
    {
        //UC-1
        public int ReadStateCensusData(string filePath)
        {
            if (!File.Exists(filePath))
                throw new StateCensusException(StateCensusException.ExceptionType.FILE_INCORRECT, "Incorrect File Path");
            if (!File.Exists(filePath))
                throw new StateCensusException(StateCensusException.ExceptionType.TYPE_INCORRECT, "Incorrect File Type");
            var read=File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Contains("/"))
                throw new StateCensusException(StateCensusException.ExceptionType.DELIMETER_INCORRECT, "Incorrect Delimeter");
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCensusDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data);
                }
                return records.Count() - 1;
            }
        }
        public bool ReadStateCensusData(string filePath, string actualHeader)
        {
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Equals(actualHeader))
                return true;
            else
                throw new StateCensusException(StateCensusException.ExceptionType.HEADER_INCORRECT, "Incorrect Header");
        }
        //UC-2
        public int ReadStateCodeData(string filePath)
        {
            if (!File.Exists(filePath))
                throw new StateCodeException(StateCodeException.ExceptionType.FILE_INCORRECT, "Incorrect File Path");
            if (!File.Exists(filePath))
                throw new StateCodeException(StateCodeException.ExceptionType.TYPE_INCORRECT, "Incorrect File Type");
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Contains("/"))
                throw new StateCodeException(StateCodeException.ExceptionType.DELIMETER_INCORRECT, "Incorrect Delimeter");
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCodeModel>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data);
                }
                return records.Count() - 1;
            }
        }
        public bool ReadStateCodeData(string filePath, string actualHeader)
        {
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Equals(actualHeader))
                return true;
            else
                throw new StateCodeException(StateCodeException.ExceptionType.HEADER_INCORRECT, "Incorrect Header");
        }
    }
}