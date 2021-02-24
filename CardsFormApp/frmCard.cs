using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardsApp;

namespace CardsFormApp
{
    public partial class frmCard : Form
    {
        List<Card> cards;
        Card currentCard;
        public frmCard()
        {
            InitializeComponent();
            cards = new List<Card>();
        }

        private void FrmCard_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateCard_Click(object sender, EventArgs e)
        {
            var testCard = new Card();
            testCard.Type = txtTo.Text;
            testCard.Customer = txtFrom.Text;
            testCard.Receiver = txtTo.Text;
            testCard.Message = txtMessage.Text;
            
            cards.Add(testCard);
            currentCard = testCard;
            MessageBox.Show("Card Created", "Card", MessageBoxButtons.OK);
            DisplayCard();
        }

        private void DisplayCard()
        {
            panCard.BackColor = Color.FromArgb(176, 196, 222);

            lblType.Text = currentCard.Type;
            lblFrom.Text = currentCard.Customer;
            lblTo.Text = currentCard.Receiver;
            lblMessage.Text = currentCard.Message;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your card is on its way");
            Application.Exit();
        }

        private void TxtFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cardtypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
    
}
