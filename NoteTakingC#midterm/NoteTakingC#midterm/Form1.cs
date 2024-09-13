using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingC_midterm
{
    public partial class frmNotes : Form
    {
        private BindingList<Note> notes = new BindingList<Note>() { new Note() };
        Note currentNote = null;
        public frmNotes()
        {
            InitializeComponent();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            //Add note to note list
            notes.Add(new Note());
        }

        private void frmNotes_Load(object sender, EventArgs e)
        {
            //Set bindings
            noteBindingSource.DataSource = notes;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if there is a note to delete, delete the note
            if (currentNote != null)
                notes.Remove(currentNote);
        }

        private void noteBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            currentNote = noteBindingSource.Current as Note;
        }
    }

    public class Note
    {
        public Note(string title = "", string body = "")
        {
            Title = title;
            Body = body;
        }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
