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
        private bool abandon = false;
        private DataRow BR_dataRow_Chambre;

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

        public BR_Chambres()
        {
            InitializeComponent();
            BR_LA_ListeSelection_S.Visible = false;
        }
        private void BR_Chambres_Load(object sender, EventArgs e)
        {
            Fill();
            LienChambre();
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
            this.BR_BS_Chambres_Ayant.DataMember = "FK__ayant__Nocham__1837881B";

            Lier();
        }
        
        private void Active()
        {
            BR_TB_Chambres_NoCham.Enabled = true;
            BR_TB_Chambres_Etage.Enabled = true;
            BR_TB_Chambres_Etat.Enabled = true;
            BR_TB_Chambre_CodeType.Enabled = true;
            BR_TB_Chambre_CodeLoc.Enabled = true;
            BR_TB_Chambres_Prix.Enabled = true;
            BR_TB_Chambre_Desc1.Enabled = true;
            BR_TB_Chambre_Desc2.Enabled = true;
            
        }
        private void Desactive()
        {
            BR_TB_Chambres_NoCham.Enabled = false;
            BR_TB_Chambres_Etage.Enabled = false;
            BR_TB_Chambres_Etat.Enabled = false;
            BR_TB_Chambre_CodeType.Enabled = false;
            BR_TB_Chambre_CodeLoc.Enabled = false;
            BR_TB_Chambres_Prix.Enabled = false;
            BR_TB_Chambre_Desc1.Enabled = false;
            BR_TB_Chambre_Desc2.Enabled = false;
        }

        private void BR_Button_Add_G_Click(object sender, EventArgs e)
        {
            Active();
            BR_Button_Add_G.Visible = false;
            BR_LA_Add_G.Visible = false;
            BR_Button_Del_G.Visible = false;
            BR_LA_Del_G.Visible = false;
            BR_Button_View_G.Visible = false;
            BR_LA_View_G.Visible = false;
            BR_Button_Undo_G.Visible = false;
            BR_LA_Undo_G.Visible = false;
            BR_Button_Edit_G.Visible = false;
            BR_LA_Edit_G.Visible = false;
            BR_Button_Save_G.Visible = false;
            BR_LA_Save_G.Visible = false;
            BR_Button_List_G.Visible = false;
            BR_LA_List_G.Visible = false;
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

        private void BR_TB_Chambre_CodeType_MouseDoubleClick(object sender, MouseEventArgs e)
         {
             int temp = BR_BS_Chambres.Position;
             BR_LS_Chambres_CodeType BR_LS_CodeType = new BR_LS_Chambres_CodeType();
             BR_LS_CodeType.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
             if (BR_LS_CodeType.ShowDialog() == DialogResult.Cancel)
             {
                 BR_BS_Chambres.Position = temp;
             }
         }
        private void BR_TB_Chambre_CodeLoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_CodeLoc BR_LS_CodeLoc = new BR_LS_Chambres_CodeLoc();
            BR_LS_CodeLoc.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            if (BR_LS_CodeLoc.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
        }
        private void BR_TB_Chambre_Desc1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_Desc1 BR_LS_Desc1 = new BR_LS_Chambres_Desc1();
            BR_LS_Desc1.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            if (BR_LS_Desc1.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
        }
        private void BR_TB_Chambre_Desc2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int temp = BR_BS_Chambres.Position;
            BR_LS_Chambres_Desc2 BR_LS_Desc2 = new BR_LS_Chambres_Desc2();
            BR_LS_Desc2.DBR_LS_DGW_Chambre.DataSource = BR_BS_Chambres;
            if (BR_LS_Desc2.ShowDialog() == DialogResult.Cancel)
            {
                BR_BS_Chambres.Position = temp;
            }
        }

        private void BR_Button_Add_S_Click(object sender, EventArgs e)
       {
        //  BR_Button_Add_S.Visible = false;
        //  BR_LA_Add_S.Visible = false;
            BR_Button_Del_S.Visible = false;
            BR_LA_Del_S.Visible = false;
            BR_Button_View_S.Visible = false;
            BR_LA_View_S.Visible = false;
        //  BR_Button_Undo_S.Visible = false;
        //  BR_LA_Undo_S.Visible = false;
            BR_Button_Edit_S.Visible = false;
            BR_LA_Edit_S.Visible = false;
        //  BR_Button_Save_S.Visible = false;
        //  BR_LA_Save_S.Visible = false;
            
            Desactive();

            BR_TB_Chambres_NoCham.Enabled = true;
            BR_TB_Chambres_NoCham.Focus();

            Delier();
       }
        private void BR_Button_Undo_S_Click(object sender, EventArgs e)
        {
            BR_Button_Add_G.Visible = true;
            BR_LA_Add_G.Visible = true;
            BR_Button_Del_G.Visible = true;
            BR_LA_Del_G.Visible = true;
            BR_Button_View_G.Visible = true;
            BR_LA_View_G.Visible = true;
            BR_Button_Undo_G.Visible = true;
            BR_LA_Undo_G.Visible = true;
            BR_Button_Edit_G.Visible = true;
            BR_LA_Edit_G.Visible = true;
            BR_Button_Save_G.Visible = true;
            BR_LA_Save_G.Visible = true;
            BR_Button_List_G.Visible = true;
            BR_LA_List_G.Visible = true;
        }
        private void BR_Button_Save_S_Click(object sender, EventArgs e)
        {
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
        }

        private void Delier()
        {
            BR_DGV_Chambres.DataSource = null;
            BR_TB_Chambres_NoCham.Clear();
            BR_TB_Chambres_Etage.Clear();
            BR_TB_Chambres_Etat.Clear();
            BR_TB_Chambre_CodeType.Clear();
            BR_TB_Chambre_CodeLoc.Clear();
            BR_TB_Chambres_Prix.Clear();
            BR_TB_Chambre_Desc1.Clear();
            BR_TB_Chambre_Desc2.Clear();
            
            BR_TB_Chambres_NoCham.DataBindings.Clear();
            BR_TB_Chambres_Etage.DataBindings.Clear();
            BR_TB_Chambres_Etat.DataBindings.Clear();
            BR_TB_Chambre_CodeType.DataBindings.Clear();
            BR_TB_Chambre_CodeLoc.DataBindings.Clear();
            BR_TB_Chambres_Prix.DataBindings.Clear();
            BR_TB_Chambre_Desc1.DataBindings.Clear();
            BR_TB_Chambre_Desc2.DataBindings.Clear();
        }
        private void Lier()
        {
            BR_DGV_Chambres.DataSource = BR_BS_Chambres_Ayant;
            try
            {
                BR_TB_Chambres_NoCham.DataBindings.Add("Text", BR_BS_Chambres, "NoCham");
                BR_TB_Chambres_Etage.DataBindings.Add("Text", BR_BS_Chambres, "Etage");
                BR_TB_Chambres_Etat.DataBindings.Add("Text", BR_BS_Chambres, "Etat");
                BR_TB_Chambre_CodeType.DataBindings.Add("Text", BR_BS_Chambres, "CodTypCham");
                BR_TB_Chambre_CodeLoc.DataBindings.Add("Text", BR_BS_Chambres, "CodLoc");
                BR_TB_Chambres_Prix.DataBindings.Add("Text", BR_BS_Chambres, "Prix");
                BR_TB_Chambre_Desc1.DataBindings.Add("Text", BR_BS_Chambres, "DescLoc");
                BR_TB_Chambre_Desc2.DataBindings.Add("Text", BR_BS_Chambres, "DescTyp");
            }
            catch
            {
                throw;
            }
        }

        private void BR_CreationChambre()
        {
            BR_dataRow_Chambre = BR_DS_Chambres.Tables["chambre"].NewRow();
            BR_dataRow_Chambre["NoCham"] = BR_TB_Chambres_NoCham.Text;
            BR_DS_Chambres.Tables["chambre"].Rows.Add(BR_dataRow_Chambre);  
            BR_BS_Chambres.Position = BR_BS_Chambres.Count - 1;
            Lier();

            BR_TB_Chambres_NoCham.BackColor = Color.GreenYellow;
            BR_TB_Chambres_NoCham.Enabled = false;

            BR_TB_Chambre_CodeType.Enabled = true;
            BR_TB_Chambre_CodeType.Focus();
        }
        private void BR_TB_Chambres_NoCham_Validating(object sender, CancelEventArgs e)
        {
            if (abandon == false)
            {
                int index = BR_BS_Chambres.Find("NoCham", BR_TB_Chambres_NoCham.Text);

                if ((BR_TB_Chambres_NoCham.Text.Length == 0) || (!IsNumeric(BR_TB_Chambres_NoCham.Text)))
                {
                    BR_EP.SetError(BR_TB_Chambres_NoCham, " Veuillez entrer un nombre compris entre 000 et 199");
                    BR_TB_Chambres_NoCham.BackColor = Color.Red;
                    BR_TB_Chambres_NoCham.Focus();
                    abandon = false;

                }
                else
                {
                    if (BR_TB_Chambres_NoCham.Text.Length != 3)
                    {
                        BR_EP.SetError(BR_TB_Chambres_NoCham, "Veuillez entrer 3 caractères ");
                        BR_TB_Chambres_NoCham.Focus();
                        BR_TB_Chambres_NoCham.BackColor = Color.Red;
                        abandon = false;

                    }
                    else
                    {
                        if (index < 0)
                        {
                            BR_EP.SetError(BR_TB_Chambres_NoCham, "");
                            abandon = true;
                            BR_CreationChambre();
                        }
                        else
                        {
                            BR_EP.SetError(BR_TB_Chambres_NoCham, "Ce numéro de chambre existe déjà" + index.ToString());
                            BR_TB_Chambres_NoCham.Focus();
                            BR_TB_Chambres_NoCham.BackColor = Color.Red;
                            abandon = false;
                        }
                    }
                }
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
            else
            {
                e.Cancel = false;
                MessageBox.Show("Goodbye.");
            }
        }
        private void BR_TB_Chambre_CodeType_Validated(object sender, System.EventArgs e)
        {
            BR_EP.SetError(BR_TB_Chambre_CodeType, "");
        }
        public bool ValidCodeType(string CodeTypeCham, out string errorMessage)
        {
            if (CodeTypeCham.Length == 0)
            {
                errorMessage = "Entrer une code type chambre valide : 1S, 2S, 1D ou 2D svp.";
                return false;
            }

            if (BR_TB_Chambre_CodeType.Text == "1S" || BR_TB_Chambre_CodeType.Text == "2S" || BR_TB_Chambre_CodeType.Text == "1D" || BR_TB_Chambre_CodeType.Text == "2D"
                || BR_TB_Chambre_CodeType.Text == "1s" || BR_TB_Chambre_CodeType.Text == "2s" || BR_TB_Chambre_CodeType.Text == "1d" || BR_TB_Chambre_CodeType.Text == "2d")
            {
                errorMessage = "";
                BR_TB_Chambre_CodeType.BackColor = Color.GreenYellow;
                BR_TB_Chambre_CodeType.Enabled = false;

                DialogResult result = MessageBox.Show("Souhaitez-vous continuer?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    BR_TB_Chambre_Desc1.Enabled = true;
                    BR_TB_Chambre_Desc1.Focus();
                    return true;
                }
                else if(result == DialogResult.Cancel)
                {
                    MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Affaire pour sortir du mode saisie
                    
                    BR_TB_Chambre_Desc1.Enabled = true;
                    BR_TB_Chambre_Desc1.Focus();
                    return true;
                }
                MessageBox.Show("Aucun des deux!");
                
            }

            errorMessage = "Entrez un code type au bon format.\n" + "For example '1S, 2S, 1D ou 2D' ";
            BR_TB_Chambre_CodeType.BackColor = Color.Red;
            return false;
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
        private void BR_TB_Chambre_Desc1_Validated(object sender, EventArgs e)
        {
            BR_EP.SetError(BR_TB_Chambre_Desc1, "");
        }
        public bool ValidDesc1(string Desc1, out string errorMessage)
        {
            
            if (Desc1.Length == 0)
            {
                errorMessage = "Entrer une code type chambre valide : standars, avec balcon, bain tourbillon, handicape ou internet svp.";
                return false;
            }

            if (BR_TB_Chambre_Desc1.Text.ToLower() == "standars" || BR_TB_Chambre_Desc1.Text.Trim().ToLower() == "avec balcon" || BR_TB_Chambre_Desc1.Text.Trim().ToLower() == "bain tourbillon" || BR_TB_Chambre_Desc1.Text.ToLower() == "handicape"
                || BR_TB_Chambre_Desc1.Text.ToLower() == "internet")
            {
                errorMessage = "";
                BR_TB_Chambre_Desc1.BackColor = Color.GreenYellow;
                BR_TB_Chambre_Desc1.Enabled = false;

                DialogResult result = MessageBox.Show("Souhaitez-vous continuer?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    BR_TB_Chambre_CodeLoc.Enabled = true;
                    BR_TB_Chambre_CodeLoc.Focus();
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Affaire pour sortir du mode saisie
                    BR_TB_Chambre_CodeLoc.Enabled = true;
                    BR_TB_Chambre_CodeLoc.Focus();
                    return true;
                }
                MessageBox.Show("Aucun des deux!");
            }

            errorMessage = "Entrez une bonne commodité svp.\n" +  "Par examples 'standars, avec balcon, bain tourbillon , handicape ou internet svp' ";
            BR_TB_Chambre_Desc1.BackColor = Color.Red;
            return false;
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
        private void BR_TB_Chambre_CodeLoc_Validated(object sender, EventArgs e)
        {
            BR_EP.SetError(BR_TB_Chambre_CodeLoc, "");
        }
        public bool ValidCodeLoc(string CodeLoc, out string errorMessage)
        {

            if (CodeLoc.Length == 0)
            {
                errorMessage = "Entrer une code type chambre valide : AR , AV ou VC svp.";
                return false;
            }

            if (BR_TB_Chambre_CodeLoc.Text.ToUpper() == "AR" || BR_TB_Chambre_CodeLoc.Text.ToUpper() == "AV" || BR_TB_Chambre_CodeLoc.Text.ToUpper() == "VC")
            {
                errorMessage = "";
                BR_TB_Chambre_CodeLoc.BackColor = Color.GreenYellow;
                BR_TB_Chambre_CodeLoc.Enabled = false;

                DialogResult result = MessageBox.Show("Souhaitez-vous continuer?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    BR_TB_Chambre_Desc2.Enabled = true;
                    BR_TB_Chambre_Desc2.Focus();
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Affaire pour sortir du mode saisie
                    BR_TB_Chambre_Desc2.Enabled = true;
                    BR_TB_Chambre_Desc2.Focus();
                    return true;
                }
                MessageBox.Show("Aucun des deux!");
            }

            errorMessage = "Entrez une bonne localisation svp.\n" + "Par exzmple 'AR, AV ou VC svp.'";
            BR_TB_Chambre_CodeLoc.BackColor = Color.Red;
            return false;
        }

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
        }
        public bool ValidDesc2(string Desc2, out string errorMessage)
        {

            if (Desc2.Length == 0)
            {
                errorMessage = "Entrer une code type chambre valide : arriere, avant ou vu sur cimetiere svp.";
                return false;
            }

            if (BR_TB_Chambre_Desc2.Text.ToLower() == "arriere" || BR_TB_Chambre_Desc2.Text.ToLower() == "avant" || BR_TB_Chambre_Desc2.Text.ToLower() == "vu sur cimetiere")
            {
                errorMessage = "";
                BR_TB_Chambre_Desc2.BackColor = Color.GreenYellow;
                BR_TB_Chambre_Desc2.Enabled = false;

                DialogResult result = MessageBox.Show("Souhaitez-vous continuer?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    BR_TB_Chambres_Etat.Enabled = true;
                    BR_TB_Chambres_Etat.Focus();
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Affaire pour sortir du mode saisie
                    BR_TB_Chambres_Etat.Enabled = true;
                    BR_TB_Chambres_Etat.Focus();
                    return true;
                }
                MessageBox.Show("Aucun des deux!");
            }

            errorMessage = "Entrez une bonne commodité svp.\n" + "Par exemple 'arriere, avant ou vu sur cimetiere svp' ";
            BR_TB_Chambre_CodeLoc.BackColor = Color.Red;
            return false;
        }

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
        }
        public bool ValidEtat(string Etat, out string errorMessage)
        {
            if (Etat.Length == 0)
            {
                errorMessage = "Entrer un etat de chambre valide : disponible ou non disponible svp.";
                return false;
            }

            if (BR_TB_Chambres_Etat.Text.ToLower() == "disponible" || BR_TB_Chambres_Etat.Text.ToLower() == "non disponible")
            {
                errorMessage = "";
                BR_TB_Chambres_Etat.BackColor = Color.GreenYellow;
                BR_TB_Chambres_Etat.Enabled = false;

                DialogResult result = MessageBox.Show("Souhaitez-vous continuer?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    BR_TB_Chambres_Prix.Enabled = true;
                    BR_TB_Chambres_Prix.Focus();
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Affaire pour sortir du mode saisie
                    BR_TB_Chambres_Prix.Enabled = true;
                    BR_TB_Chambres_Prix.Focus();
                    return true;
                }
                MessageBox.Show("Aucun des deux!");
            }

            errorMessage = "Entrez une bonne commodité svp.\n" + "Par exemple 'disponible ou non disponible svp' ";
            BR_TB_Chambres_Etat.BackColor = Color.Red;
            return false;
        }

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
        }
        public bool ValidPrix(string Etat, out string errorMessage)
        {

            if (Etat.Length == 0)
            {
                errorMessage = "Entrer un prix de chambre valide : 150 ou 200 svp.";
                return false;
            }

            if (BR_TB_Chambres_Prix.Text.ToLower() == "disponible" || BR_TB_Chambres_Prix.Text.ToLower() == "non disponible")
            {
                errorMessage = "";
                BR_TB_Chambres_Prix.BackColor = Color.GreenYellow;
                BR_TB_Chambres_Prix.Enabled = false;

                DialogResult result = MessageBox.Show("Souhaitez-vous continuer?", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    return true;
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Vous avez annuler l'ajout de la nouvelles chambres et toutes les modifications ont été annulées!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Affaire pour sortir du mode saisie
                    
                    return true;
                }
                MessageBox.Show("Aucun des deux!");
            }

            errorMessage = "Entrez une bonne commodité svp.\n" + "Par exemple 'disponible ou non disponible svp' ";
            BR_TB_Chambres_Prix.BackColor = Color.Red;
            return false;
        }

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

        private void BR_Button_LS_S_MouseHover(object sender, EventArgs e)
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
        }

        private void BR_Button_LS_S_MouseLeave(object sender, EventArgs e)
        {
            BR_LA_ListeSelection_S.Visible = false;
        }
        

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            BR_LA_ListeSelection_S.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            BR_LA_ListeSelection_S.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            BR_LA_ListeSelection_S.Visible = true;
        }

        private void BR_Button_LS_Chambre_S_MouseHover(object sender, EventArgs e)
        {
            BR_LA_ListeSelection_S.Visible = true;

            BR_Button_LS_CodeLoc_S.Visible = false;
        }

        private void BR_Button_LS_Chambre_S_MouseLeave(object sender, EventArgs e)
        {
            BR_LA_ListeSelection_S.Visible = false;
        }
    }

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
}
