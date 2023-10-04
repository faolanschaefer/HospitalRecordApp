namespace HospitalRecordApp
{
    partial class frmEncounterNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewNote = new System.Windows.Forms.Button();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.btnRemoveProblem = new System.Windows.Forms.Button();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnUpdateNote = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.lsbVitals = new System.Windows.Forms.ListBox();
            this.lblVitals = new System.Windows.Forms.Label();
            this.lsbProblems = new System.Windows.Forms.ListBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lblProblems = new System.Windows.Forms.Label();
            this.btnAddProblem = new System.Windows.Forms.Button();
            this.lblNewProblem = new System.Windows.Forms.Label();
            this.txtNewProblem = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lsbNotes = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewNote
            // 
            this.btnNewNote.Enabled = false;
            this.btnNewNote.Location = new System.Drawing.Point(50, 32);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(124, 23);
            this.btnNewNote.TabIndex = 0;
            this.btnNewNote.Text = "Start new note";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.btnRemoveProblem);
            this.grpInputs.Controls.Add(this.btnDeleteNote);
            this.grpInputs.Controls.Add(this.btnUpdateNote);
            this.grpInputs.Controls.Add(this.btnAddNote);
            this.grpInputs.Controls.Add(this.lsbVitals);
            this.grpInputs.Controls.Add(this.lblVitals);
            this.grpInputs.Controls.Add(this.lsbProblems);
            this.grpInputs.Controls.Add(this.lblNotes);
            this.grpInputs.Controls.Add(this.rtbNotes);
            this.grpInputs.Controls.Add(this.lblProblems);
            this.grpInputs.Controls.Add(this.btnAddProblem);
            this.grpInputs.Controls.Add(this.lblNewProblem);
            this.grpInputs.Controls.Add(this.txtNewProblem);
            this.grpInputs.Controls.Add(this.lblDOB);
            this.grpInputs.Controls.Add(this.lblName);
            this.grpInputs.Controls.Add(this.txtName);
            this.grpInputs.Controls.Add(this.lblId);
            this.grpInputs.Controls.Add(this.txtId);
            this.grpInputs.Controls.Add(this.dtpDOB);
            this.grpInputs.Location = new System.Drawing.Point(228, 22);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(817, 540);
            this.grpInputs.TabIndex = 2;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Add/Edit/Delete Encounter Note";
            // 
            // btnRemoveProblem
            // 
            this.btnRemoveProblem.Enabled = false;
            this.btnRemoveProblem.Location = new System.Drawing.Point(465, 227);
            this.btnRemoveProblem.Name = "btnRemoveProblem";
            this.btnRemoveProblem.Size = new System.Drawing.Size(119, 23);
            this.btnRemoveProblem.TabIndex = 6;
            this.btnRemoveProblem.Text = "Remove problem";
            this.btnRemoveProblem.UseVisualStyleBackColor = true;
            this.btnRemoveProblem.Click += new System.EventHandler(this.btnRemoveProblem_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Enabled = false;
            this.btnDeleteNote.Location = new System.Drawing.Point(215, 501);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(91, 23);
            this.btnDeleteNote.TabIndex = 11;
            this.btnDeleteNote.Text = "Delete note";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // btnUpdateNote
            // 
            this.btnUpdateNote.Enabled = false;
            this.btnUpdateNote.Location = new System.Drawing.Point(118, 501);
            this.btnUpdateNote.Name = "btnUpdateNote";
            this.btnUpdateNote.Size = new System.Drawing.Size(91, 23);
            this.btnUpdateNote.TabIndex = 10;
            this.btnUpdateNote.Text = "Update note";
            this.btnUpdateNote.UseVisualStyleBackColor = true;
            this.btnUpdateNote.Click += new System.EventHandler(this.btnUpdateNote_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Enabled = false;
            this.btnAddNote.Location = new System.Drawing.Point(21, 501);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(91, 23);
            this.btnAddNote.TabIndex = 9;
            this.btnAddNote.Text = "Add note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // lsbVitals
            // 
            this.lsbVitals.Enabled = false;
            this.lsbVitals.FormattingEnabled = true;
            this.lsbVitals.Location = new System.Drawing.Point(621, 74);
            this.lsbVitals.Name = "lsbVitals";
            this.lsbVitals.Size = new System.Drawing.Size(169, 173);
            this.lsbVitals.TabIndex = 7;
            // 
            // lblVitals
            // 
            this.lblVitals.AutoSize = true;
            this.lblVitals.Enabled = false;
            this.lblVitals.Location = new System.Drawing.Point(621, 42);
            this.lblVitals.Name = "lblVitals";
            this.lblVitals.Size = new System.Drawing.Size(32, 13);
            this.lblVitals.TabIndex = 18;
            this.lblVitals.Text = "Vitals";
            // 
            // lsbProblems
            // 
            this.lsbProblems.Enabled = false;
            this.lsbProblems.FormattingEnabled = true;
            this.lsbProblems.Location = new System.Drawing.Point(458, 74);
            this.lsbProblems.Name = "lsbProblems";
            this.lsbProblems.Size = new System.Drawing.Size(134, 147);
            this.lsbProblems.TabIndex = 5;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Enabled = false;
            this.lblNotes.Location = new System.Drawing.Point(18, 253);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "Notes";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Enabled = false;
            this.rtbNotes.Location = new System.Drawing.Point(21, 279);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(769, 211);
            this.rtbNotes.TabIndex = 8;
            this.rtbNotes.Text = "";
            this.rtbNotes.TextChanged += new System.EventHandler(this.rtbNotes_TextChanged);
            // 
            // lblProblems
            // 
            this.lblProblems.AutoSize = true;
            this.lblProblems.Enabled = false;
            this.lblProblems.Location = new System.Drawing.Point(455, 42);
            this.lblProblems.Name = "lblProblems";
            this.lblProblems.Size = new System.Drawing.Size(50, 13);
            this.lblProblems.TabIndex = 17;
            this.lblProblems.Text = "Problems";
            // 
            // btnAddProblem
            // 
            this.btnAddProblem.Enabled = false;
            this.btnAddProblem.Location = new System.Drawing.Point(358, 199);
            this.btnAddProblem.Name = "btnAddProblem";
            this.btnAddProblem.Size = new System.Drawing.Size(62, 23);
            this.btnAddProblem.TabIndex = 4;
            this.btnAddProblem.Text = "Add";
            this.btnAddProblem.UseVisualStyleBackColor = true;
            this.btnAddProblem.Click += new System.EventHandler(this.btnAddProblem_Click);
            // 
            // lblNewProblem
            // 
            this.lblNewProblem.AutoSize = true;
            this.lblNewProblem.Enabled = false;
            this.lblNewProblem.Location = new System.Drawing.Point(18, 204);
            this.lblNewProblem.Name = "lblNewProblem";
            this.lblNewProblem.Size = new System.Drawing.Size(69, 13);
            this.lblNewProblem.TabIndex = 15;
            this.lblNewProblem.Text = "New problem";
            // 
            // txtNewProblem
            // 
            this.txtNewProblem.Enabled = false;
            this.txtNewProblem.Location = new System.Drawing.Point(123, 201);
            this.txtNewProblem.Name = "txtNewProblem";
            this.txtNewProblem.Size = new System.Drawing.Size(222, 20);
            this.txtNewProblem.TabIndex = 3;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Enabled = false;
            this.lblDOB.Location = new System.Drawing.Point(18, 150);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(65, 13);
            this.lblDOB.TabIndex = 14;
            this.lblDOB.Text = "Date of birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Enabled = false;
            this.lblName.Location = new System.Drawing.Point(18, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Patient name";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(123, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Enabled = false;
            this.lblId.Location = new System.Drawing.Point(18, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Note ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(123, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Location = new System.Drawing.Point(123, 147);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(154, 20);
            this.dtpDOB.TabIndex = 2;
            // 
            // lsbNotes
            // 
            this.lsbNotes.Enabled = false;
            this.lsbNotes.FormattingEnabled = true;
            this.lsbNotes.Location = new System.Drawing.Point(32, 64);
            this.lsbNotes.Name = "lsbNotes";
            this.lsbNotes.Size = new System.Drawing.Size(161, 498);
            this.lsbNotes.TabIndex = 1;
            this.lsbNotes.SelectedIndexChanged += new System.EventHandler(this.lsbNotes_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Crimson;
            this.lblMessage.Location = new System.Drawing.Point(29, 573);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 3;
            // 
            // frmEncounterNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 604);
            this.Controls.Add(this.lsbNotes);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.btnNewNote);
            this.Name = "frmEncounterNotes";
            this.Text = "Encounter Notes";
            this.Load += new System.EventHandler(this.frmEncounterNotes_Load);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.Button btnUpdateNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.ListBox lsbVitals;
        private System.Windows.Forms.Label lblVitals;
        private System.Windows.Forms.ListBox lsbProblems;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Label lblProblems;
        private System.Windows.Forms.Button btnAddProblem;
        private System.Windows.Forms.Label lblNewProblem;
        private System.Windows.Forms.TextBox txtNewProblem;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ListBox lsbNotes;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRemoveProblem;
    }
}

