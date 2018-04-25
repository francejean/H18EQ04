using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bates_Reservation_Chambres
{
    public partial class BR_Chambres : Bate_s_Reservation_Base_Biblioteque.BR_Biblio
    {
        private DataRow BR_dataRow_Chambre;
        private bool lienGrid = false;
        private bool abandon = true;

        public BR_Chambres()
        {
            InitializeComponent();
            BR_LA_ListeSelection_S.Visible = false;
            BR_LA_ListeSelection2_S.Visible = false;

            BR_Button_LS_CodeType_S.Enabled = false;
            BR_Button_LS_CodeLoc_S.Enabled = false;
            Desactive();
        }
        private void BR_Chambres_Load(object sender, EventArgs e)
        {
            Fill();
            LienChambre();
            abandon = false;
        }

        private void Fill()
        {
            //this.BR_TA_Chambres.Fill(this.BR_DS_Chambres.chambre);
            //this.BR_TA_Chambres_Ayant.Fill(this.BR_DS_Chambres.ayant);
        }
        private void LienChambre()
        {
            this.BR_BS_Chambres.DataMember = "chambre";
            this.BR_BS_Chambres.DataSource = this.BR_DS_Chambres;
            this.BR_BS_Chambres_Ayant.DataSource = this.BR_BS_Chambres;
            this.BR_BS_Chambres_Ayant.DataMember = "FK__ayant__Nocham__64D7DFA6";

            Lier();
        }
        private bool Validation()
        {
            if (BR_TB_Chambre_NoCham.Text.Length == 0)
            {
                BR_TB_Chambre_NoCham.Focus();
                BR_EP.SetError(BR_TB_Chambre_NoCham, "Veuillez entrer un Numéro de chambre valide s'il vous plaît! ");
                BR_TB_Chambre_NoCham.BackColor = Color.Red;
                return false;
            }

            //BR_dataRow_Chambre["NoCham"] = BR_TB_Chambre_NoCham.Text;
            //BR_EP.SetError(BR_TB_Chambre_NoCham, "");
            return true;
        }
        private bool Valide()
        {
            bool valide = true;
            if (!Validation()) valide = false;
            /*
            if ((BR_TB_Chambre_CodeType.Text.Length != 2) || (!IsNumeric(BR_TB_Chambre_CodeType.Text)))
            {
                BR_EP.SetError(BR_TB_Chambre_CodeType, "Entrez un poste d'un maximium un code valide ");
                valide = false;
            }
            else BR_EP.SetError(BR_TB_Chambre_CodeType, "");*/
            /*
            if (Cb_Dept_Ach.Text.Length == 0)
            {
                errorProvider1.SetError(Cb_Dept_Ach, "Choisir un département ");
                valide = false;
            }
            else errorProvider1.SetError(Cb_Dept_Ach, "");


          
            BR_EP.SetError(BR_TB_Chambres_Etat, "");
            BR_EP.SetError(BR_TB_Chambre_CodeLoc, "");
            BR_EP.SetError(BR_TB_Chambres_Prix, "");
            BR_EP.SetError(BR_TB_Chambre_Desc1, "");
            BR_EP.SetError(BR_TB_Chambre_Desc2, "");

            */
            return valide;
        }
        private void Delier()
        {
            BR_DGV_Chambres.DataSource = null;
            BR_TB_Chambre_NoCham.Clear();
            BR_TB_Chambre_Etage.Clear();
            BR_TB_Chambres_Prix.Clear();
           
            BR_TB_Chambres_Etat.Clear();
            BR_TB_Chambre_CodeType.Clear();
            BR_TB_Chambre_CodeLoc.Clear();
            BR_TB_Chambre_Desc1.Clear();
            BR_TB_Chambre_Desc2.Clear();

            BR_TB_Chambre_NoCham.DataBindings.Clear();
            BR_TB_Chambre_Etage.DataBindings.Clear();
            BR_TB_Chambres_Prix.DataBindings.Clear();
           
            BR_TB_Chambres_Etat.DataBindings.Clear();
            BR_TB_Chambre_CodeType.DataBindings.Clear();
            BR_TB_Chambre_CodeLoc.DataBindings.Clear();
            BR_TB_Chambre_Desc1.DataBindings.Clear();
            BR_TB_Chambre_Desc2.DataBindings.Clear();

            lienGrid = false;

        }
        private void Lier()
        {
            if (lienGrid == false)
            {
                BR_DGV_Chambres.DataSource = BR_BS_Chambres_Ayant;
                try
                {
                    BR_TB_Chambre_NoCham.DataBindings.Add("Text", BR_BS_Chambres, "NoCham");
                    BR_TB_Chambre_Etage.DataBindings.Add("Text", BR_BS_Chambres, "Etage");
                    BR_TB_Chambres_Prix.DataBindings.Add("Text", BR_BS_Chambres, "Prix");
                    
                    BR_TB_Chambres_Etat.DataBindings.Add("Text", BR_BS_Chambres, "Etat");
                    BR_TB_Chambre_CodeType.DataBindings.Add("Text", BR_BS_Chambres, "CodTypCham");
                    BR_TB_Chambre_CodeLoc.DataBindings.Add("Text", BR_BS_Chambres, "CodLoc");
                    BR_TB_Chambre_Desc1.DataBindings.Add("Text", BR_BS_Chambres, "DescLoc");
                    BR_TB_Chambre_Desc2.DataBindings.Add("Text", BR_BS_Chambres, "DescTyp");
        
                    lienGrid = true;
                }
                catch
                {
                    throw;
                }
            }
        }
        public bool IsNumeric(string Nombre)
        {
            try
            {
                int.Parse(Nombre);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void BR_CreationChambre()
        {
            BR_dataRow_Chambre = BR_DS_Chambres.Tables["chambre"].NewRow();
            BR_dataRow_Chambre["NoCham"] = BR_TB_Chambre_NoCham.Text;
            BR_DS_Chambres.Tables["chambre"].Rows.Add(BR_dataRow_Chambre);
            BR_BS_Chambres.Position = BR_BS_Chambres.Count - 1;
            Lier();

            BR_TB_Chambre_NoCham.BackColor = Color.GreenYellow;
            BR_TB_Chambre_NoCham.Enabled = false;

            ///AJOUT AUTOMATIQUE DE L'ETAGE A LA CHAMBRE
            char tokens = BR_TB_Chambre_NoCham.Text[0];
            BR_TB_Chambre_Etage.Text = tokens.ToString();      
            ///AJOUT AUTOMATIQUE DE L'ETAGE A LA CHAMBRE

           

            //Active();
            BR_TB_Chambre_Etage.Enabled = false;
            BR_TB_Chambre_CodeType.Enabled = true;
            BR_TB_Chambre_CodeType.Focus();
        }
        private void BR_TB_Chambre_NoCham_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                int index = BR_BS_Chambres.Find("NoCham", BR_TB_Chambre_NoCham.Text);

                if ((BR_TB_Chambre_NoCham.Text.Length == 0) || (!IsNumeric(BR_TB_Chambre_NoCham.Text)))
                {
                    BR_EP.SetError(BR_TB_Chambre_NoCham, " Veuillez entrer un nombre compris entre 000 et 199");
                    BR_TB_Chambre_NoCham.BackColor = Color.Red;
                    BR_TB_Chambre_NoCham.Focus();
                    abandon = false;

                }
                else
                {
                    if (BR_TB_Chambre_NoCham.Text.Length != 3)
                    {
                        BR_EP.SetError(BR_TB_Chambre_NoCham, "Veuillez entrer 3 caractères ");
                        BR_TB_Chambre_NoCham.Focus();
                        BR_TB_Chambre_NoCham.BackColor = Color.Red;
                        abandon = false;

                    }
                    else
                    {
                        if (index < 0)
                        {
                            BR_EP.SetError(BR_TB_Chambre_NoCham, "");
                            abandon = true;
                            BR_CreationChambre();
                        }
                        else
                        {
                            BR_EP.SetError(BR_TB_Chambre_NoCham, "Ce numéro de chambre existe déjà" + index.ToString());
                            BR_TB_Chambre_NoCham.Focus();
                            BR_TB_Chambre_NoCham.BackColor = Color.Red;
                            abandon = false;
                        }
                    }
                }
            }
        }
        private void BR_TB_Chambre_NoCham_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                Validation();
        }
        private void BR_TB_Chambre_CodeType_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                Validation();
        }
        private void BR_TB_Chambre_Desc1_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                Validation();
        }

        private void BR_TB_Chambre_CodeLoc_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                Validation();
        }

        private void BR_TB_Chambre_Desc2_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                Validation(); 
        }

        private void BR_TB_Chambres_Etat_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                Validation();
        }

        private void BR_TB_Chambres_Prix_Leave(object sender, EventArgs e)
        {
            if (abandon == false)
                Validation();
        }
        //    private void Cs_Num_Ach_Validating(object sender, CancelEventArgs e)
        // {// s'appelle aussitôt que le champ no bon est quitté
        // alors je teste si je n'ai pas appuyer sur abandonné
        //      if (abandon == false)
        //    {
        /*// si index == -1 ok n'existe pas donc ok pour ajouter
        int index = Bs_Ach.Find("num_Ach", Cs_Num_Ach.Text);// 'avec le binding source

        if ((Cs_Num_Ach.Text.Length == 0) || (!IsNumeric(Cs_Num_Ach.Text)))
        {
            errorProvider1.SetError(Cs_Num_Ach, " Veuillez entrer un nombre compris entre 00001 et 99999");

            Cs_Num_Ach.Focus();

        }
        else
        {
            if (Cs_Num_Ach.Text.Length != 5)
            {
                errorProvider1.SetError(Cs_Num_Ach, "Veuillez entrer 5 caractères ");
                Cs_Num_Ach.Focus();

            }
            else
            // 'Validation de clé primaire dans Acheteur
            {
                if (index < 0) //     'ici avec le retour du binding source 
                {
                    errorProvider1.SetError(Cs_Num_Ach, "");
                    Creer_Ach();
                    // return true;
                }
                else
                {
                    errorProvider1.SetError(Cs_Num_Ach, "Ce numéro d'acheteur existe déjà" + index.ToString());

                    Cs_Num_Ach.Focus();

                }
            }
        }*/

        //    }
        //  }

        #region "Boutons G"
        private void BR_Button_Add_G_Click(object sender, EventArgs e)
        {
            BR_Button_LS_CodeType_S.Enabled = true;
            BR_Button_LS_CodeLoc_S.Enabled = true;
        }
        private void BR_Button_Gotofirst_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.MoveFirst();
        }
        private void BR_Button_Previous_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.MovePrevious();
        }
        private void BR_Button_Next_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.MoveNext();
        }
        private void BR_Button_Gotoend_G_Click(object sender, EventArgs e)
        {
            BR_BS_Chambres.MoveLast();
        }
        private void BR_Button_Undo_G_Click(object sender, EventArgs e)
        {
            Desactive();
        }
        private void BR_Button_Save_G_Click(object sender, EventArgs e)
        {
            Desactive();
        }
        #endregion
        #region " Activation des Saisies "
        // efface toutes les erreurs sur abandon au cas ou abandonne avec erreur   
        private void ClearErreurs()
        {
            BR_EP.SetError(BR_TB_Chambre_NoCham, "");
            BR_EP.SetError(BR_TB_Chambre_Etage, "");
            BR_EP.SetError(BR_TB_Chambres_Etat, "");
            BR_EP.SetError(BR_TB_Chambre_CodeType, "");
            BR_EP.SetError(BR_TB_Chambre_CodeLoc, "");
            BR_EP.SetError(BR_TB_Chambres_Prix, "");
            BR_EP.SetError(BR_TB_Chambre_Desc1, "");
            BR_EP.SetError(BR_TB_Chambre_Desc2, "");
        }

        private void Active()
        {
            BR_TB_Chambre_NoCham.Enabled = true;
            BR_TB_Chambre_Etage.Enabled = true;
            BR_TB_Chambres_Prix.Enabled = true;
            
            BR_TB_Chambres_Etat.Enabled = true;
            BR_TB_Chambre_CodeType.Enabled = true;
            BR_TB_Chambre_CodeLoc.Enabled = true;
            BR_TB_Chambre_Desc1.Enabled = true;
            BR_TB_Chambre_Desc2.Enabled = true;

        }
        private void Desactive()
        {
            BR_TB_Chambre_NoCham.Enabled = false;
            BR_TB_Chambre_Etage.Enabled = false;
            BR_TB_Chambres_Prix.Enabled = false;
           
            BR_TB_Chambre_Desc1.Enabled = false;
            BR_TB_Chambre_Desc2.Enabled = false;
            BR_TB_Chambres_Etat.Enabled = false;
            BR_TB_Chambre_CodeType.Enabled = false;
            BR_TB_Chambre_CodeLoc.Enabled = false;
        }

        #endregion
        #region "Bouton S"
        private void BR_Button_Add_S_Click(object sender, EventArgs e)
        {
            abandon = false;

            BR_Button_Del_S.Visible = false;
            BR_LA_Del_S.Visible = false;
            BR_Button_View_S.Visible = false;
            BR_LA_View_S.Visible = false;
            BR_Button_Edit_S.Visible = false;
            BR_LA_Edit_S.Visible = false;

            Active();
            
            Desactive();

            BR_TB_Chambre_NoCham.Enabled = true;
            BR_TB_Chambre_NoCham.Focus();

            Delier();
        }
        private void BR_Button_Undo_S_Click(object sender, EventArgs e)
        {
            abandon = true;
            ClearErreurs();
            BR_TB_Chambre_NoCham.BackColor = Color.Empty;
            BR_TB_Chambre_CodeType.BackColor = Color.Empty;
            BR_TB_Chambre_Desc1.BackColor = Color.Empty;
            BR_TB_Chambre_CodeLoc.BackColor = Color.Empty;
            BR_TB_Chambre_Desc2.BackColor = Color.Empty;
            BR_TB_Chambres_Etat.BackColor = Color.Empty;
            BR_TB_Chambres_Prix.BackColor = Color.Empty;
            BR_Button_Add_S.Visible = true;
            BR_Button_Del_S.Visible = true;
            BR_Button_View_S.Visible = true;
            BR_Button_Edit_S.Visible = true;
            BR_Button_Save_S.Visible = true;
            BR_Button_Quit_G.Visible = true;
            Desactive();
            BR_DS_Chambres.Tables["chambre"].RejectChanges();
            BR_BS_Chambres.ResetCurrentItem();
            Lier();

            BR_BS_Chambres.Position = 0;
            /*
            DialogResult result = MessageBox.Show("Souhaitez-vous annuler?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Quitter!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //BR_Chambres_Load(this, EventArgs.Empty);


            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Vous retournez à la saisie!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    */
        }
        private void BR_Button_Save_S_Click(object sender, EventArgs e)
        {
            if (Valide())
            {
                BR_BS_Chambres.Position = 0;
                BR_dataRow_Chambre.EndEdit();
                // TA_ach.Update(ds_Ach.ACH);
                //BR_TA_Chambres.Update(BR_DS_Chambres.chambre);

                BR_Button_Add_S.Visible = true;
                BR_LA_Add_S.Visible = true;
                BR_Button_Del_S.Visible = true;
                BR_LA_Del_S.Visible = true;
                BR_Button_View_S.Visible = true;
                BR_LA_View_S.Visible = true;
                BR_Button_Undo_S.Visible = true;
                BR_LA_Undo_S.Visible = true;
                BR_Button_Edit_S.Visible = true;
                BR_LA_Edit_S.Visible = true;
                BR_Button_Save_S.Visible = true;
                BR_LA_Save_S.Visible = true;

                Active();
                abandon = false;
            }
        }
        private void BR_Button_Del_S_Click(object sender, EventArgs e)
        {
            abandon = false;
        }
        private void BR_Button_View_S_Click(object sender, EventArgs e)
        {
            abandon = false;
        }
        private void BR_Button_Edit_S_Click(object sender, EventArgs e)
        {
            /*
            abandon = false;
            Dtr_Ach = ds_Ach.Tables["Ach"].Rows[Bs_Ach.Position]; //pour travailler avec dtr au lieu de tout la ligne de code
                                                                  // sinon ne prend pas toujours les modifications
            Dtr_Ach.BeginEdit();
            Ly_Activer_Boutons(true, true, true, true, true, true, true, true, true, true, true, true, true);
            // pas permettre de modifier la clef primaire
            Activer_Saisie(false, true, true, true);
            */
        }
        private void BR_LA_View_S_Click(object sender, EventArgs e)
        {
            //int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_NoCham BR_LS_NoCham = new BR_LS_Chambres_NoCham();
            BR_LS_NoCham.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            /*if (BR_LS_NoCham.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }*/

            int oldposition = BR_BS_Chambres.Position;
            if (BR_LS_NoCham.ShowDialog() != DialogResult.OK)
            {
                BR_BS_Chambres.Position = oldposition;
            }
        }
        #endregion
        #region "Validations"

        private void Quitter()
        {
            string dead = "";
            string kill = BR_TB_Chambre_CodeType.Text = "STOP";
            ValidCodeType(kill, out dead);
            kill = BR_TB_Chambre_Desc1.Text = "STOP";
            ValidDesc1(kill, out dead);
            BR_TB_Chambre_CodeLoc.Text = "STOP";
            ValidCodeLoc(kill, out dead);
            BR_TB_Chambre_Desc2.Text = "STOP";
            ValidDesc2(kill, out dead);
            BR_TB_Chambres_Etat.Text = "STOP";
            ValidEtat(kill, out dead);
            BR_TB_Chambres_Prix.Text = "STOP";
            ValidPrix(kill, out dead);

            abandon = true;
            ClearErreurs();
            BR_TB_Chambre_NoCham.BackColor = Color.Empty;
            BR_TB_Chambre_CodeType.BackColor = Color.Empty;
            BR_TB_Chambre_Desc1.BackColor = Color.Empty;
            BR_TB_Chambre_CodeLoc.BackColor = Color.Empty;
            BR_TB_Chambre_Desc2.BackColor = Color.Empty;
            BR_TB_Chambres_Etat.BackColor = Color.Empty;
            BR_TB_Chambres_Prix.BackColor = Color.Empty;
            BR_Button_Undo_S.Visible = true;
            BR_Button_Add_S.Visible = false;
            BR_Button_Save_S.Visible = false;
            BR_Button_Quit_G.Visible = false;
            Desactive();
            BR_DS_Chambres.Tables["chambre"].RejectChanges();
            BR_BS_Chambres.ResetCurrentItem();
            Lier();

            BR_BS_Chambres.Position = 0;

        }
        #region [Validation]BR_TB_Chambre_CodeType
        private void BR_TB_Chambre_CodeType_Validated(object sender, System.EventArgs e)
            {
                BR_EP.SetError(BR_TB_Chambre_CodeType, "");
                DialogResult result = MessageBox.Show("Souhaitez-vous continuer?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("OK", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
                }
                else if (result == DialogResult.No)
                {
                   Quitter();
                MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        private void BR_TB_Chambre_CodeType_Validating(object sender, CancelEventArgs e)
            {
                string errorMsg;

                if (!ValidCodeType(BR_TB_Chambre_CodeType.Text, out errorMsg))
                {
                    e.Cancel = true;
                    BR_TB_Chambre_CodeType.Select(0, BR_TB_Chambre_CodeType.Text.Length);
                    this.BR_EP.SetError(BR_TB_Chambre_CodeType, errorMsg);
                }
            }
        public bool ValidCodeType(string CodeTypeCham, out string errorMessage)
            {

                if (CodeTypeCham.Length == 0)
                {
                    errorMessage = "Entrer une code type chambre valide : 1S, 2S, 1D ou 2D svp.";
                    BR_TB_Chambre_CodeType.BackColor = Color.Red;
                    return false;
                }

                if (BR_TB_Chambre_CodeType.Text == "1S" || BR_TB_Chambre_CodeType.Text == "2S" || BR_TB_Chambre_CodeType.Text == "1D" || BR_TB_Chambre_CodeType.Text == "2D"
                    || BR_TB_Chambre_CodeType.Text == "1s" || BR_TB_Chambre_CodeType.Text == "2s" || BR_TB_Chambre_CodeType.Text == "1d" || BR_TB_Chambre_CodeType.Text == "2d" || BR_TB_Chambre_CodeType.Text == "STOP")
                {
                    errorMessage = "";
                    BR_TB_Chambre_CodeType.BackColor = Color.GreenYellow;
                    BR_TB_Chambre_CodeType.Enabled = false;

                    BR_TB_Chambre_Desc1.Enabled = true;
                    BR_TB_Chambre_Desc1.Focus();
                    return true;
                }
                errorMessage = "Entrez un code type au bon format.\n" + "For example '1S, 2S, 1D ou 2D' ";
                BR_TB_Chambre_CodeType.BackColor = Color.Red;
                return false;
            }
        #endregion
        #region [Validation]BR_TB_Chambre_Desc1
        private void BR_TB_Chambre_Desc1_Validated(object sender, EventArgs e)
        {
            BR_EP.SetError(BR_TB_Chambre_Desc1, "");
            DialogResult result = MessageBox.Show("Souhaitez-vous continuer 2?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("OK", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                /*string dead = "";
                string kill = BR_TB_Chambre_Desc1.Text = "STOP";
                ValidDesc1(kill, out dead);*/
                Quitter();
            }
        }
        private void BR_TB_Chambre_Desc1_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDesc1(BR_TB_Chambre_Desc1.Text, out errorMsg))
            {
                e.Cancel = true;
                BR_TB_Chambre_Desc1.Select(0, BR_TB_Chambre_Desc1.Text.Length);
                this.BR_EP.SetError(BR_TB_Chambre_Desc1, errorMsg);
            }
        } 
        public bool ValidDesc1(string Desc1, out string errorMessage)
        {

            if (Desc1.Length == 0)
            {
                errorMessage = "Entrer une code type chambre valide : standars, avec balcon, bain tourbillon, handicape ou internet svp.";
                BR_TB_Chambre_Desc1.BackColor = Color.Red;
                return false;
            }

            if (BR_TB_Chambre_Desc1.Text.ToLower() == "standars" || BR_TB_Chambre_Desc1.Text.Trim().ToLower() == "avec balcon" || BR_TB_Chambre_Desc1.Text.Trim().ToLower() == "bain tourbillon" || BR_TB_Chambre_Desc1.Text.ToLower() == "handicape"
                || BR_TB_Chambre_Desc1.Text.ToLower() == "internet" || BR_TB_Chambre_Desc1.Text == "STOP")
            {
                errorMessage = "";
                BR_TB_Chambre_Desc1.BackColor = Color.GreenYellow;
                BR_TB_Chambre_Desc1.Enabled = false;

                BR_TB_Chambre_CodeLoc.Enabled = true;
                BR_TB_Chambre_CodeLoc.Focus();
                return true;
            }
            errorMessage = "Entrez une bonne commodité svp.\n" +  "Par examples 'standars, avec balcon, bain tourbillon , handicape ou internet svp' ";
            BR_TB_Chambre_Desc1.BackColor = Color.Red;
            return false;
        }
        #endregion
        #region [Validation]BR_TB_Chambre_CodeLoc
        private void BR_TB_Chambre_CodeLoc_Validated(object sender, EventArgs e)
        {
            BR_EP.SetError(BR_TB_Chambre_CodeLoc, "");
            DialogResult result = MessageBox.Show("Souhaitez-vous continuer 3?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("OK", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string dead = "";
                string kill = BR_TB_Chambre_CodeLoc.Text = "STOP";
                ValidCodeLoc(kill, out dead);
            }
        }
        private void BR_TB_Chambre_CodeLoc_Validating(object sender, CancelEventArgs e)
                {
                    string errorMsg;
                    if (!ValidCodeLoc(BR_TB_Chambre_CodeLoc.Text, out errorMsg))
                    {
                        e.Cancel = true;
                        BR_TB_Chambre_CodeLoc.Select(0, BR_TB_Chambre_CodeLoc.Text.Length);
                        this.BR_EP.SetError(BR_TB_Chambre_CodeLoc, errorMsg);
                    }
                }
        public bool ValidCodeLoc(string CodeLoc, out string errorMessage)
        {

            if (CodeLoc.Length == 0)
            {
                errorMessage = "Entrer une code type chambre valide : AR , AV ou VC svp.";
                BR_TB_Chambre_CodeLoc.BackColor = Color.Red;
                return false;
            }

            if (BR_TB_Chambre_CodeLoc.Text.ToUpper() == "AR" || BR_TB_Chambre_CodeLoc.Text.ToUpper() == "AV" || BR_TB_Chambre_CodeLoc.Text.ToUpper() == "VC" || BR_TB_Chambre_CodeLoc.Text == "STOP")
            {
                errorMessage = "";
                BR_TB_Chambre_CodeLoc.BackColor = Color.GreenYellow;
                BR_TB_Chambre_CodeLoc.Enabled = false;

                BR_TB_Chambre_Desc2.Enabled = true;
                BR_TB_Chambre_Desc2.Focus();
                return true;
            }

            errorMessage = "Entrez une bonne localisation svp.\n" + "Par exzmple 'AR, AV ou VC svp.'";
            BR_TB_Chambre_CodeLoc.BackColor = Color.Red;
            return false;
        }

        #endregion
        #region [Validation]BR_TB_Chambre_Desc2
        private void BR_TB_Chambre_Desc2_Validating(object sender, CancelEventArgs e)
            {
                string errorMsg;
                if (!ValidDesc2(BR_TB_Chambre_Desc2.Text, out errorMsg))
                {
                    e.Cancel = true;
                    BR_TB_Chambre_Desc2.Select(0, BR_TB_Chambre_Desc2.Text.Length);
                    this.BR_EP.SetError(BR_TB_Chambre_Desc2, errorMsg);
                }
            }
            private void BR_TB_Chambre_Desc2_Validated(object sender, EventArgs e)
            {
                BR_EP.SetError(BR_TB_Chambre_Desc2, "");
                DialogResult result = MessageBox.Show("Souhaitez-vous continuer 4?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("OK", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    string dead = "";
                    string kill = BR_TB_Chambre_Desc2.Text = "STOP";
                    ValidDesc2(kill, out dead);
                }
            }
            public bool ValidDesc2(string Desc2, out string errorMessage)
            {

                if (Desc2.Length == 0)
                {
                    errorMessage = "Entrer une code type chambre valide : arriere, avant ou vu sur cimetiere svp.";
                    return false;
                }

                if (BR_TB_Chambre_Desc2.Text.ToLower() == "arriere" || BR_TB_Chambre_Desc2.Text.ToLower() == "avant" || BR_TB_Chambre_Desc2.Text.ToLower() == "vu sur cimetiere" || BR_TB_Chambre_Desc2.Text == "STOP")
                {
                    errorMessage = "";
                    BR_TB_Chambre_Desc2.BackColor = Color.GreenYellow;
                    BR_TB_Chambre_Desc2.Enabled = false;

                    BR_TB_Chambres_Etat.Enabled = true;
                    BR_TB_Chambres_Etat.Focus();
                    return true;
                    
                }

                errorMessage = "Entrez une bonne commodité svp.\n" + "Par exemple 'arriere, avant ou vu sur cimetiere svp' ";
                BR_TB_Chambre_CodeLoc.BackColor = Color.Red;
                return false;
            }

        #endregion
        #region [Validation]BR_TB_Chambre_Etat
        private void BR_TB_Chambres_Etat_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEtat(BR_TB_Chambres_Etat.Text, out errorMsg))
            {
                e.Cancel = true;
                BR_TB_Chambres_Etat.Select(0, BR_TB_Chambres_Etat.Text.Length);
                this.BR_EP.SetError(BR_TB_Chambres_Etat, errorMsg);
            }
        }
        private void BR_TB_Chambres_Etat_Validated(object sender, EventArgs e)
        {
            BR_EP.SetError(BR_TB_Chambres_Etat, "");
            DialogResult result = MessageBox.Show("Souhaitez-vous continuer 5?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("OK", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string dead = "";
                string kill = BR_TB_Chambres_Prix.Text = "STOP";
                ValidPrix(kill, out dead);
            }
        }
        public bool ValidEtat(string Etat, out string errorMessage)
        {
            if (Etat.Length == 0)
            {
                errorMessage = "Entrer un etat de chambre valide : disponible ou non disponible svp.";
                return false;
            }

            if (BR_TB_Chambres_Etat.Text.ToLower() == "disponible" || BR_TB_Chambres_Etat.Text.ToLower() == "non disponible" || BR_TB_Chambres_Etat.Text == "STOP")
            {
                errorMessage = "";
                BR_TB_Chambres_Etat.BackColor = Color.GreenYellow;
                BR_TB_Chambres_Etat.Enabled = false;

                BR_TB_Chambres_Prix.Enabled = true;
                BR_TB_Chambres_Prix.Focus();
                return true;
            }

            errorMessage = "Entrez une bonne commodité svp.\n" + "Par exemple 'disponible ou non disponible svp' ";
            BR_TB_Chambres_Etat.BackColor = Color.Red;
            return false;
        }

        #endregion
        #region [Validation]BR_TB_Chambre_Prix
        private void BR_TB_Chambres_Prix_Validating(object sender, CancelEventArgs e)
                {
                    string errorMsg;
                    if (!ValidPrix(BR_TB_Chambres_Prix.Text, out errorMsg))
                    {
                        e.Cancel = true;
                        BR_TB_Chambres_Prix.Select(0, BR_TB_Chambres_Prix.Text.Length);
                        this.BR_EP.SetError(BR_TB_Chambres_Prix, errorMsg);
                    }
                }
                private void BR_TB_Chambres_Prix_Validated(object sender, EventArgs e)
                {
                    BR_EP.SetError(BR_TB_Chambres_Prix, "");
                    DialogResult result = MessageBox.Show("Souhaitez-vous continuer 6?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("OK", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        string dead = "";
                        string kill = BR_TB_Chambres_Prix.Text = "STOP";
                        ValidPrix(kill, out dead);

                    }
                }
                public bool ValidPrix(string Etat, out string errorMessage)
                {

                    if (Etat.Length == 0)
                    {
                        errorMessage = "Entrer un prix de chambre valide : 150 ou 200 svp.";
                        return false;
                    }

                    if (BR_TB_Chambres_Prix.Text.ToLower() == "disponible" || BR_TB_Chambres_Prix.Text.ToLower() == "non disponible" || BR_TB_Chambres_Etat.Text == "STOP")
                    {
                        errorMessage = "";
                        BR_TB_Chambres_Prix.BackColor = Color.GreenYellow;
                        BR_TB_Chambres_Prix.Enabled = false;

                        return true;
                    }
                        

                    errorMessage = "Entrez une bonne commodité svp.\n" + "Par exemple 'disponible ou non disponible svp' ";
                    BR_TB_Chambres_Prix.BackColor = Color.Red;
                    return false;
                }
        #endregion         
        #endregion
        #region "Bouton liste de selection"
        private void BR_Button_LS_S_Click(object sender, EventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_NoCham BR_LS_NoCham = new BR_LS_Chambres_NoCham();
            BR_LS_NoCham.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            if (BR_LS_NoCham.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
        }
        private void BR_Button_LS_CodeType_S_Click(object sender, EventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_CodeType BR_LS_CodeType = new BR_LS_Chambres_CodeType();
            BR_LS_CodeType.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            if (BR_LS_CodeType.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
        }

        private void BR_Button_LS_CodeLoc_S_Click(object sender, EventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_CodeLoc BR_LS_CodeLoc = new BR_LS_Chambres_CodeLoc();
            BR_LS_CodeLoc.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            if (BR_LS_CodeLoc.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
        }
        private void BR_Button_LS_Chambre_S_MouseHover(object sender, EventArgs e)
        {
            BR_LA_ListeSelection_S.Visible = true;

            BR_LA_Chambre_CodeType.Visible = false;
            BR_TB_Chambre_CodeType.Visible = false;

            BR_LA_Chambre_Desc2.Visible = false;
            BR_TB_Chambre_Desc2.Visible = false;
            BR_LA_Chambre_CodeLoc.Visible = false;
            BR_TB_Chambre_CodeLoc.Visible = false;
            BR_LA_Chambre_Desc1.Visible = false;
            BR_TB_Chambre_Desc1.Visible = false;
            BR_Button_LS_CodeType_S.Visible = false;
            BR_Button_LS_CodeLoc_S.Visible = false;
            BR_LA_Chambre_Prix.Visible = false;
            BR_TB_Chambres_Prix.Visible = false;

        }
        private void BR_Button_LS_Chambre_S_MouseLeave(object sender, EventArgs e)
        {
            BR_LA_ListeSelection_S.Visible = false;

            BR_LA_Chambre_NoCham.Visible = true;
            BR_TB_Chambre_NoCham.Visible = true;
            BR_Button_LS_CodeType_S.Visible = true;
            BR_Button_LS_CodeLoc_S.Visible = true;
            BR_LA_Chambre_CodeType.Visible = true;
            BR_TB_Chambre_CodeType.Visible = true;
            BR_LA_Chambre_Etage.Visible = true;
            BR_TB_Chambre_Etage.Visible = true;
            BR_LA_Chambre_Etat.Visible = true;
            BR_TB_Chambres_Etat.Visible = true;
            BR_LA_Chambre_CodeLoc.Visible = true;
            BR_TB_Chambre_CodeLoc.Visible = true;
            BR_LA_Chambre_Prix.Visible = true;
            BR_TB_Chambres_Prix.Visible = true;
            BR_LA_Chambre_Desc1.Visible = true;
            BR_TB_Chambre_Desc1.Visible = true;
            BR_LA_Chambre_Desc2.Visible = true;
            BR_TB_Chambre_Desc2.Visible = true;
        }
        private void BR_Button_LS_CodeType_S_MouseHover(object sender, EventArgs e)
        {
            BR_LA_ListeSelection2_S.Text = " Liste de Selection\n     Code Type";
            BR_LA_ListeSelection2_S.Visible = true;

            BR_LA_Chambre_NoCham.Visible = false;
            BR_TB_Chambre_NoCham.Visible = false;
            BR_Button_LS_Chambre_S.Visible = false;
            BR_LA_Chambre_CodeType.Visible = false;
            BR_TB_Chambre_CodeType.Visible = false;
            BR_LA_Chambre_Etage.Visible = false;
            BR_TB_Chambre_Etage.Visible = false;
            BR_LA_Chambre_Etat.Visible = false;
            BR_TB_Chambres_Etat.Visible = false;
            BR_LA_Chambre_CodeLoc.Visible = false;
            BR_TB_Chambre_CodeLoc.Visible = false;
            BR_LA_Chambre_Prix.Visible = false;
            BR_TB_Chambres_Prix.Visible = false;
        }

        private void BR_Button_LS_CodeType_S_MouseLeave(object sender, EventArgs e)
        {
            BR_LA_ListeSelection2_S.Visible = false;

            BR_LA_Chambre_NoCham.Visible = true;
            BR_TB_Chambre_NoCham.Visible = true;
            BR_Button_LS_Chambre_S.Visible = true;
            BR_LA_Chambre_CodeType.Visible = true;
            BR_TB_Chambre_CodeType.Visible = true;
            BR_LA_Chambre_Etage.Visible = true;
            BR_TB_Chambre_Etage.Visible = true;
            BR_LA_Chambre_Etat.Visible = true;
            BR_TB_Chambres_Etat.Visible = true;
            BR_LA_Chambre_CodeLoc.Visible = true;
            BR_TB_Chambre_CodeLoc.Visible = true;
            BR_LA_Chambre_Prix.Visible = true;
            BR_TB_Chambres_Prix.Visible = true;
        }

        private void BR_Button_LS_CodeLoc_S_MouseHover(object sender, EventArgs e)
        {
            BR_LA_ListeSelection2_S.Text = " Liste de Selection\n Code Localisation";
            BR_LA_ListeSelection2_S.Visible = true;

            BR_LA_Chambre_NoCham.Visible = false;
            BR_TB_Chambre_NoCham.Visible = false;
            BR_Button_LS_Chambre_S.Visible = false;
            BR_LA_Chambre_CodeType.Visible = false;
            BR_TB_Chambre_CodeType.Visible = false;
            BR_LA_Chambre_Etage.Visible = false;
            BR_TB_Chambre_Etage.Visible = false;
            BR_LA_Chambre_Etat.Visible = false;
            BR_TB_Chambres_Etat.Visible = false;
            BR_LA_Chambre_CodeLoc.Visible = false;
            BR_TB_Chambre_CodeLoc.Visible = false;
            BR_LA_Chambre_Prix.Visible = false;
            BR_TB_Chambres_Prix.Visible = false;
        }

        private void BR_Button_LS_CodeLoc_S_MouseLeave(object sender, EventArgs e)
        {
            BR_LA_ListeSelection2_S.Visible = false;

            BR_LA_Chambre_NoCham.Visible = true;
            BR_TB_Chambre_NoCham.Visible = true;
            BR_Button_LS_Chambre_S.Visible = true;
            BR_LA_Chambre_CodeType.Visible = true;
            BR_TB_Chambre_CodeType.Visible = true;
            BR_LA_Chambre_Etage.Visible = true;
            BR_TB_Chambre_Etage.Visible = true;
            BR_LA_Chambre_Etat.Visible = true;
            BR_TB_Chambres_Etat.Visible = true;
            BR_LA_Chambre_CodeLoc.Visible = true;
            BR_TB_Chambre_CodeLoc.Visible = true;
            BR_LA_Chambre_Prix.Visible = true;
            BR_TB_Chambres_Prix.Visible = true;
        }
        #endregion

    }
    #region "Validation email a garder"
    /*public bool ValidEmailAddress(string CodeTypeCham, out string errorMessage)
       {
           // Confirm that the e-mail address string is not empty.
           if (CodeTypeCham.Length == 0)
           {
               errorMessage = "e-mail address is required.";
               return false;
           }

           // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
           if (CodeTypeCham.IndexOf("@") > -1)
           {
               if (CodeTypeCham.IndexOf(".", CodeTypeCham.IndexOf("@")) > CodeTypeCham.IndexOf("@"))
               {
                   errorMessage = "";
                   BR_TB_Chambre_CodeType.BackColor = Color.GreenYellow;
                   BR_TB_Chambre_CodeType.Enabled = false;
                   BR_TB_Chambre_Desc1.Enabled = true;
                   BR_TB_Chambre_Desc1.Focus();
                   return true;
               }
           }

           errorMessage = "e-mail address must be valid e-mail address format.\n" +
              "For example 'someone@example.com' ";
           return false;
       }*/
    #endregion
}
