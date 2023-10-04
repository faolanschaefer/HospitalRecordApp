using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSchaeferAssignment3
{
    public abstract class Vitals
    {
        public enum Level
        {
            None = 0,
            Low = 1,
            High = 2
        }
        private Level vitalLevels;

        public Level VitalLevels { get => vitalLevels; set => vitalLevels = value; }
        public abstract Level GetLevels();
    }
    public class BloodPressure : Vitals
    {
        private double systolic;
        private double diastolic;

        public BloodPressure(string systolic, string diastolic)
        {
            Systolic = systolic;
            Diastolic = diastolic;
            VitalLevels = GetLevels();
        }
        public override Level GetLevels()
        {
            if (systolic < 90 && diastolic < 60)
            {
                return Level.Low;
            }
            else if (systolic > 130 && diastolic > 80)
            {
                return Level.High;
            }
            return Level.None;
        }
        public override string ToString()
        {
            string levelsString = VitalLevels == Level.None ? String.Empty : $"({VitalLevels.ToString()})";
            return $"BP: {systolic}/{diastolic} mmHg {levelsString}";
        }
        public string Systolic { get => systolic.ToString(); set => systolic = double.Parse(value); }
        public string Diastolic { get => diastolic.ToString(); set => diastolic = double.Parse(value); }
    }
    public class HeartRate : Vitals
    {
        private double beatsPerMinute;

        public HeartRate(string beatsPerMinute)
        {
            BeatsPerMinute = beatsPerMinute;
            VitalLevels = GetLevels();
        }

        public override Level GetLevels()
        {
            if (beatsPerMinute < 60)
            {
                return Level.Low;
            }
            else if (beatsPerMinute > 100)
            {
                return Level.High;
            }
            return Level.None;
        }
        public override string ToString()
        {
            string levelsString = VitalLevels == Level.None ? String.Empty : $"({VitalLevels.ToString()})";
            return $"HR: {beatsPerMinute} bpm {levelsString}";
        }
        public string BeatsPerMinute { get => beatsPerMinute.ToString(); set => beatsPerMinute = double.Parse(value); }
    }
    public class Temperature : Vitals
    {
        private double degrees;

        public Temperature(string degrees)
        {
            Degrees = degrees;
            VitalLevels = GetLevels();
        }

        public override Level GetLevels()
        {
            if (degrees < 36.5)
            {
                return Level.Low;
            }
            else if (degrees > 37.2)
            {
                return Level.High;
            }
            return Level.None;
        }
        public override string ToString()
        {
            string levelsString = VitalLevels == Level.None ? String.Empty : $"({VitalLevels.ToString()})";
            return $"T: {degrees} \x00B0C {levelsString}";
        }
        public string Degrees { get => degrees.ToString(); set => degrees = double.Parse(value); }
    }
    public class RespiratoryRate : Vitals
    {
        private double breathsPerMinute;

        public RespiratoryRate(string breathsPerMinute)
        {
            BreathsPerMinute = breathsPerMinute;
            VitalLevels = GetLevels();
        }

        public override Level GetLevels()
        {
            if (breathsPerMinute < 12)
            {
                return Level.Low;
            }
            else if (breathsPerMinute > 16)
            {
                return Level.High;
            }
            return Level.None;
        }
        public override string ToString()
        {
            string levelsString = VitalLevels == Level.None ? String.Empty : $"({VitalLevels.ToString()})";
            return $"RR: {breathsPerMinute} bpm {levelsString}";
        }
        public string BreathsPerMinute { get => breathsPerMinute.ToString(); set => breathsPerMinute = double.Parse(value); }
    }
}
