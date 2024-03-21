namespace Phonebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ContactList _book = new();

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) ||
                    string.IsNullOrEmpty(txtCognome.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text))
                    throw new Exception("Compila tutti i campi");

                Tools.InsertContact(txtNome.Text, txtCognome.Text, txtTelefono.Text, _book);

                Tools.ViewContacts(_book, lvAgenda);

                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) &&
                string.IsNullOrEmpty(txtCognome.Text) &&
                string.IsNullOrEmpty(txtTelefono.Text))
                    throw new Exception("Inserisci almeno un criterio di ricerca");

                var results = Tools.SearchContact(txtNome.Text, txtCognome.Text, txtTelefono.Text, _book);

                if (results.Count() == 0)
                    MessageBox.Show("Nessun elemento trovato.");

                Tools.ViewContacts(results, lvAgenda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) &&
                string.IsNullOrEmpty(txtCognome.Text) &&
                string.IsNullOrEmpty(txtTelefono.Text))
                    throw new Exception("Inserisci almeno un criterio per la cancellazione");

                var results = Tools.SearchContact(txtNome.Text, txtCognome.Text, txtTelefono.Text, _book);

                if (MessageBox.Show($"Sicuro di eliminare {results.Count} contatti", "Attenzione",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Tools.RemoveContact(results, _book);

                    MessageBox.Show("Contatti eliminati");

                    Tools.ViewContacts(_book, lvAgenda);

                    ResetFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetFields()
        {
            foreach (var c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;
                else if (c is ListBox)
                    ((ListBox)c).Text = string.Empty;
        }


    }
}
