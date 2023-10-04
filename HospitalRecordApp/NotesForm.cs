using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vitals = Notes.Vitals;
using Note = Notes.Note;
using Office = Notes.Office;

namespace HospitalRecordApp
{
    public partial class frmEncounterNotes : Form
    {
        Office thisOffice;
        Note selectedNote;
        public frmEncounterNotes()
        {
            InitializeComponent();
        }
        private void AwaitingMode()
        {
            foreach (Control c in grpInputs.Controls)
            {
                c.Enabled = false;
            }
            btnNewNote.Enabled = true;
            lsbNotes.Enabled = true;
        }
        private void EditMode()
        {
            foreach (Control c in grpInputs.Controls)
            {
                c.Enabled = true;
            }
            btnAddNote.Enabled = false;
            txtId.Enabled = false;
        }
        private void AddMode()
        {
            foreach (Control c in grpInputs.Controls)
            {
                c.Enabled = true;
            }
            btnUpdateNote.Enabled = false;
            btnDeleteNote.Enabled = false;
            txtId.Enabled = false;
        }
        private void LoadFields(Note note)
        {
            txtId.Text = note.NoteId.ToString();
            txtName.Text = note.PatientName;
            dtpDOB.Value = note.DateOfBirth;
            rtbNotes.Text = note.Notes.Replace(';', '\n');
            lsbVitals.Items.Clear();
            lsbProblems.Items.Clear();
            foreach (Vitals vital in note.VitalMeasurements)
            {
                lsbVitals.Items.Add(vital.ToString());
            }
            foreach (string problem in note.Problems)
            {
                lsbProblems.Items.Add(problem.ToString());
            }
        }
        private void ReloadNoteList()
        {
            lsbNotes.Items.Clear();
            foreach (Note note in thisOffice.Notes)
            {
                lsbNotes.Items.Add($"{note.PatientName} (Note: {note.NoteId})");
            }
        }

        private void frmEncounterNotes_Load(object sender, EventArgs e)
        {
            thisOffice = new Office();
            thisOffice.LoadNotes();
            ReloadNoteList();
            AwaitingMode();
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            selectedNote = new Note();
            LoadFields(selectedNote);
            txtId.Text = thisOffice.NextId.ToString();
            AddMode();
        }

        private void lsbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbNotes.SelectedItem == null)
            {
                return;
            }
            int selectedId = int.Parse(new Regex(@"(\d+)\)$").Match(lsbNotes.SelectedItem.ToString()).Groups[1].Value);
            selectedNote = thisOffice.Notes.Find(note => note.NoteId == selectedId);
            LoadFields(selectedNote);
            EditMode();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    throw new Exception("Please enter a name");
                }
                if (dtpDOB.Value > DateTime.Now)
                {
                    throw new Exception("Date of birth cannot be in the future");
                }
                if (string.IsNullOrEmpty(rtbNotes.Text))
                {
                    throw new Exception("Please enter note content");
                }
                string[] problems = new string[lsbProblems.Items.Count];
                for (int i = 0; i < lsbProblems.Items.Count; i++)
                {
                    problems[i] = lsbProblems.Items[i].ToString();
                }
                Note newNote = new Note(thisOffice.NextId, txtName.Text, dtpDOB.Value, problems, rtbNotes.Text);
                thisOffice.AddNote(newNote);
                lsbNotes.Items.Add($"{newNote.PatientName} (Note: {newNote.NoteId})");
                thisOffice.SaveNotes();
                lblMessage.Text = "Note added successfully";
                AwaitingMode();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnAddProblem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewProblem.Text))
            {
                return;
            }
            lsbProblems.Items.Add(txtNewProblem.Text);
            txtNewProblem.Text = "";
        }

        private void btnRemoveProblem_Click(object sender, EventArgs e)
        {
            lsbProblems.Items.Remove(lsbProblems.SelectedItem);
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    throw new Exception("Please enter a name");
                }
                if (dtpDOB.Value > DateTime.Now)
                {
                    throw new Exception("Date of birth cannot be in the future");
                }
                if (string.IsNullOrEmpty(rtbNotes.Text))
                {
                    throw new Exception("Please enter note content");
                }
                string[] problems = new string[lsbProblems.Items.Count];
                for (int i = 0; i < lsbProblems.Items.Count; i++)
                {
                    problems[i] = lsbProblems.Items[i].ToString();
                }
                Note newNote = new Note(selectedNote.NoteId, txtName.Text, dtpDOB.Value, problems, rtbNotes.Text);
                thisOffice.UpdateNote(newNote);
                ReloadNoteList();
                thisOffice.SaveNotes();
                lblMessage.Text = "Note updated successfully";
                AwaitingMode();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            thisOffice.DeleteNote(selectedNote);
            ReloadNoteList();
            thisOffice.SaveNotes();
            lblMessage.Text = "Note deleted successfully";
            AwaitingMode();
        }

        private void rtbNotes_TextChanged(object sender, EventArgs e)
        {
            Note tempNote = new Note();
            tempNote.Notes = rtbNotes.Text;
            List<Vitals> tempVitals = tempNote.GetVitals();
            if (tempVitals != selectedNote.VitalMeasurements)
            {
                lsbVitals.Items.Clear();
                foreach (Vitals vital in tempVitals)
                {
                    lsbVitals.Items.Add(vital.ToString());
                }
            }
        }
    }
}
