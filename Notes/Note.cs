using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Notes
{
    public class Note
    {
        private Regex bloodPressureRegex = new Regex(@"BP:? (\d{2}\d?)/(\d{2}\d?)");
        private Regex heartRateRegex = new Regex(@"HR:? (\d{2}\d?)");
        private Regex temperatureRegex = new Regex(@"T:? (\d{2}\d?)");
        private Regex respiratoryRateRegex = new Regex(@"RR:? (\d{2}\d?)");

        private int noteId;
        private string patientName;
        private DateTime dateOfBirth;
        private string[] problems;
        private string notes;
        private List<Vitals> vitalMeasurements;

        public Note(int noteId, string patientName, DateTime dateOfBirth, string[] problems, string notes)
        {
            NoteId = noteId;
            PatientName = patientName;
            DateOfBirth = dateOfBirth;
            Problems = problems;
            Notes = notes;
            vitalMeasurements = GetVitals();
        }
        public Note(string str)
        {
            string[] fields = str.Split('|');
            NoteId = int.Parse(fields[0]);
            PatientName = fields[1];
            DateOfBirth = DateTime.Parse(fields[2]);
            Notes = fields[3];
            Problems = fields[4].Contains(';') ? fields[4].Split(';') : new string[] { fields[4] };
            vitalMeasurements = GetVitals();
        }
        public Note()
        {
            NoteId = 0;
            PatientName = "";
            DateOfBirth = DateTime.Today;
            problems = new string[0];
            Notes = "";
            VitalMeasurements = new List<Vitals>();
        }
        public override string ToString()
        {
            return $"{noteId}|{patientName}|{dateOfBirth.ToString()}|{notes}|{string.Join(";", problems)}";
        }
        public List<Vitals> GetVitals()
        {
            List<Vitals> newVitals = new List<Vitals>();
            if (!string.IsNullOrEmpty(Notes))
            {
                foreach (Match bp in bloodPressureRegex.Matches(Notes))
                {
                    BloodPressure newBp = new BloodPressure(bp.Groups[1].Value, bp.Groups[2].Value);
                    newVitals.Add(newBp);
                }
                foreach (Match hr in heartRateRegex.Matches(Notes))
                {
                    HeartRate newHr = new HeartRate(hr.Groups[1].Value);
                    newVitals.Add(newHr);
                }
                foreach (Match temp in temperatureRegex.Matches(Notes))
                {
                    Temperature newTemp = new Temperature(temp.Groups[1].Value);
                    newVitals.Add(newTemp);
                }
                foreach (Match rr in respiratoryRateRegex.Matches(Notes))
                {
                    RespiratoryRate newRr = new RespiratoryRate(rr.Groups[1].Value);
                    newVitals.Add(newRr);
                }
            }
            return newVitals;
        }

        public int NoteId { get => noteId; set => noteId = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string[] Problems { get => problems; set => problems = value; }
        public string Notes { get => notes; set => notes = value.Replace('\n', ';'); }
        public List<Vitals> VitalMeasurements { get => vitalMeasurements; set => vitalMeasurements = value; }
    }
}
