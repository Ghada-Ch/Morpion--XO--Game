using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Morpion;
using System.Threading;

namespace Morpion
{
    public partial class Morpion : Form
    {
        bool Gagne ;
        int nbClic ;
        public static String J1 = "Joueur1";
        public static String J2 = "Joueur2";

        public Morpion()
        {
            InitializeComponent();
            
            nbClic = 0;
            Gagne = false;
        }

        private void Morpion_Load(object sender, EventArgs e)
        {
            nbClic = 0;
            Gagne = false;
            cmdGo.Enabled = true;
            btQuitter.Visible = false;
            btReplay.Visible = false;
            lblFin.Text = "Fin Game";
            cmdGo.ForeColor = Color.Red;
            _listeBoutons.Add(cmdJeu1);
            _listeBoutons.Add(cmdJeu2);
            _listeBoutons.Add(cmdJeu3);
            _listeBoutons.Add(cmdJeu4);
            _listeBoutons.Add(cmdJeu5);
            _listeBoutons.Add(cmdJeu6);
            _listeBoutons.Add(cmdJeu7);
            _listeBoutons.Add(cmdJeu8);
            _listeBoutons.Add(cmdJeu9);

            _listeLabels.Add(txtJeu1);
            _listeLabels.Add(txtJeu2);
            _listeLabels.Add(txtJeu3);
            _listeLabels.Add(txtJeu4);
            _listeLabels.Add(txtJeu5);
            _listeLabels.Add(txtJeu6);
            _listeLabels.Add(txtJeu7);
            _listeLabels.Add(txtJeu8);
            _listeLabels.Add(txtJeu9);
            lblFin.Visible = false;
            for (int i = 0; i < 9; i++)
            {
                _listeLabels[i].Text = "";
                _listeBoutons[i].Text = "";
                _listeBoutons[i].Enabled = false;
                _listeBoutons[i].Visible = true;
                _listeLabels[i].Visible = false;
            }

        }
        void FinGame()
        {
            
                cmdJeu1.Enabled = false;
                cmdJeu2.Enabled = false;
                cmdJeu3.Enabled = false;
                cmdJeu4.Enabled = false;
                cmdJeu5.Enabled = false;
                cmdJeu6.Enabled = false;
                cmdJeu7.Enabled = false;
                cmdJeu8.Enabled = false;
                cmdJeu9.Enabled = false;
            lblFin.Visible = true;
                if (Gagne == true)
                if(_joueurActive==joueur.Joueur1)
                    lblFin.Text += "\n \n" + J1 + " a Gagné";
                else
                    lblFin.Text += "\n \n"+J2 + " a Gagné";
            else
                    lblFin.Text += "\n  \n Aucun Gagnant !";
            btQuitter.Visible = true;
            btReplay.Visible = true;
            
        }
       bool RechercheGangant(int position)
        {
            switch(position)
            {
                case 1:
                    if (((txtJeu1.Text == txtJeu2.Text) && (txtJeu1.Text == txtJeu3.Text)) || (txtJeu1.Text == txtJeu4.Text && txtJeu1.Text == txtJeu7.Text) || (txtJeu1.Text == txtJeu5.Text && txtJeu1.Text == txtJeu9.Text))
                        return true;
                    else
                        return false;
                       
                case 2:
                    if (((txtJeu1.Text == txtJeu2.Text) && (txtJeu1.Text == txtJeu3.Text)) || ((txtJeu2.Text == txtJeu5.Text) && (txtJeu2.Text == txtJeu8.Text)) )
                        return true;
                    else
                        return false;
                case 3:
                    if ((txtJeu1.Text == txtJeu2.Text && txtJeu1.Text == txtJeu3.Text) || (txtJeu3.Text == txtJeu5.Text && txtJeu3.Text == txtJeu7.Text) || (txtJeu3.Text == txtJeu6.Text && txtJeu3.Text == txtJeu9.Text))
                        return true;
                    else
                        return false;
                case 4:
                    if ((txtJeu4.Text == txtJeu5.Text && txtJeu4.Text == txtJeu6.Text) || (txtJeu4.Text == txtJeu1.Text && txtJeu4.Text == txtJeu7.Text) )
                        return true;
                    else
                        return false;
                case 5:
                    if ((txtJeu4.Text == txtJeu5.Text && txtJeu4.Text == txtJeu6.Text) || (txtJeu5.Text == txtJeu3.Text && txtJeu5.Text == txtJeu7.Text) || (txtJeu5.Text == txtJeu1.Text && txtJeu5.Text == txtJeu9.Text))
                        return true;
                    else
                        return false;
                case 6:
                    if ((txtJeu6.Text == txtJeu5.Text && txtJeu4.Text == txtJeu6.Text) || (txtJeu6.Text == txtJeu3.Text && txtJeu6.Text == txtJeu9.Text) )
                        return true;
                    else
                        return false;
                case 7:
                    if ((txtJeu7.Text == txtJeu5.Text && txtJeu7.Text == txtJeu3.Text) || (txtJeu8.Text == txtJeu7.Text && txtJeu7.Text == txtJeu9.Text) || (txtJeu4.Text == txtJeu7.Text && txtJeu7.Text == txtJeu1.Text))
                        return true;
                    else
                        return false;
                case 8:
                    if ((txtJeu8.Text == txtJeu7.Text && txtJeu8.Text == txtJeu9.Text) || (txtJeu8.Text == txtJeu5.Text && txtJeu8.Text == txtJeu2.Text) )
                        return true;
                    else
                        return false;
                case 9:
                    if ((txtJeu9.Text == txtJeu5.Text && txtJeu9.Text == txtJeu1.Text) || (txtJeu8.Text == txtJeu7.Text && txtJeu7.Text == txtJeu9.Text) || (txtJeu9.Text == txtJeu6.Text && txtJeu9.Text == txtJeu3.Text))
                        return true;
                    else
                        return false;
                default: return false;

            }
            
        }
        void SetVisibilityBT(Button bt)
        {
            int numbt = Convert.ToInt32(bt.Name.Substring(6));
            switch (numbt)
            {
                case 1:
                    cmdJeu1.Visible = false; txtJeu1.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu1.Text = "X";
                    else
                        txtJeu1.Text = "O";
                    break;
                case 2:
                    cmdJeu2.Visible = false; txtJeu2.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu2.Text = "X";
                    else
                        txtJeu2.Text = "O";
                    break;
                case 3:
                    cmdJeu3.Visible = false; txtJeu3.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu3.Text = "X";
                    else
                        txtJeu3.Text = "O";
                    break;
                case 4:
                    cmdJeu4.Visible = false; txtJeu4.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu4.Text = "X";
                    else
                        txtJeu4.Text = "O";
                    break;
                case 5:
                    cmdJeu5.Visible = false; txtJeu5.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu5.Text = "X";
                    else
                        txtJeu5.Text = "O";
                    break;
                case 6:
                    cmdJeu6.Visible = false; txtJeu6.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu6.Text = "X";
                    else
                        txtJeu6.Text = "O";
                    break;
                case 7:
                    cmdJeu7.Visible = false; txtJeu7.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu7.Text = "X";
                    else
                        txtJeu7.Text = "O";
                    break;
                case 8:
                    cmdJeu8.Visible = false; txtJeu8.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu8.Text = "X";
                    else
                        txtJeu8.Text = "O";
                    
                    break;
                case 9:
                    cmdJeu9.Visible = false; txtJeu9.Visible = true;
                    if (_joueurActive == joueur.Joueur1)
                        txtJeu9.Text = "X";
                    else
                        txtJeu9.Text = "O";
                    break;
                default: break;
            }
           
            /*if validergrille() arrêter le jeu et afficher le gagant*/
            
            Gagne = RechercheGangant(numbt);
            nbClic++;
            if((Gagne==true)||(nbClic==9))
            {
                FinGame();
            }
            else
            {
                if (_joueurActive == joueur.Joueur1)
                {
                    _joueurActive = joueur.Joueur2;
                    lblJoueurAct.Text = J2;
                }
                else

                {
                    _joueurActive = joueur.Joueur1;
                    lblJoueurAct.Text = J1;
                }
            }
            
               

           
        }


        List<Button> _listeBoutons = new List<Button>();
        List<Label> _listeLabels = new List<Label>();
        
        enum joueur  {Joueur1, Joueur2 };
        joueur _joueurActive = joueur.Joueur1;


        private void cmdGo_Click(object sender, EventArgs e)
        {
            
            
            cmdGo.ForeColor =Color.Black;
            ShowMessageBox.ShowMessage();
            ShowMessageBox.MsgBox.Show();
            //Thread.Sleep(3000);
            
            
            cmdGo.Enabled = false;
            cmdJeu1.Enabled = true;
            cmdJeu2.Enabled = true;
            cmdJeu3.Enabled = true;
            cmdJeu4.Enabled = true;
            cmdJeu5.Enabled = true;
            cmdJeu6.Enabled = true;
            cmdJeu7.Enabled = true;
            cmdJeu8.Enabled = true;
            cmdJeu9.Enabled = true;
            lblJoueurAct.Text = J1;
        }

        private void cmdJeu1_Click_1(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void cmdJeu2_Click(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void cmdJeu3_Click(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void cmdJeu4_Click(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void cmdJeu5_Click(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void cmdJeu6_Click(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void cmdJeu7_Click(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void cmdJeu8_Click(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void cmdJeu9_Click(object sender, EventArgs e)
        {
            SetVisibilityBT((Button)sender);
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btReplay_Click(object sender, EventArgs e)
        {
            Morpion_Load(sender,e);
        }
    }
}
